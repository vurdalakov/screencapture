namespace Vurdalakov
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Vurdalakov.Properties;

    public partial class MainForm : Form
    {
        private List<FileFormat> _fileFormats = new List<FileFormat>();

        public MainForm()
        {
            this.InitializeComponent();

            this._fileFormats.Add(new FileFormat(ImageFormat.Bmp, "bmp", "BMP"));
            this._fileFormats.Add(new FileFormat(ImageFormat.Gif, "gif", "GIF"));
            this._fileFormats.Add(new FileFormat(ImageFormat.Jpeg, "jpg", "JPEG"));
            this._fileFormats.Add(new FileFormat(ImageFormat.Png, "png", "PNG"));
            this._fileFormats.Add(new FileFormat(ImageFormat.Tiff, "tif", "TIFF"));
        }

        private void MainForm_Load(Object sender, EventArgs e)
        {
            this.UpgradeUserSettings();

            //this.RestoreWindowPlacement();
            //this.FormClosing += (s1, e1) => this.SaveWindowPlacement();

            DesktopWindowManager.DisableTransitions(this.Handle); // no need to sleep after hide

            CheckRadioButton(this.groupBoxSource, Settings.Default.Source);
            CheckRadioButton(this.groupBoxTarget, Settings.Default.Target);
            this.linkLabelTargetDirectory.Text = String.IsNullOrEmpty(Settings.Default.TargetDirectory) ? Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) : Settings.Default.TargetDirectory;
            this.SetCheckBoxBitmask(this.groupBoxHotKey, Settings.Default.HotKeyModifiers);
            this.checkBoxOpenExplorerAfter.Checked = Settings.Default.OpenFileExplorer;

            for (var i = 0; i < 24; i++)
            {
                this.comboBoxHotKey.Items.Add(new VirtualKeyCodeItem(VirtualKeyCode.F1, i));
            }
            for (var i = 0; i < 10; i++)
            {
                this.comboBoxHotKey.Items.Add(new VirtualKeyCodeItem(VirtualKeyCode.Key0, i));
            }
            for (var i = 0; i < 26; i++)
            {
                this.comboBoxHotKey.Items.Add(new VirtualKeyCodeItem(VirtualKeyCode.KeyA, i));
            }
            var virtualKeyCode = (VirtualKeyCode)Settings.Default.HotKeyVirtualKey;
            this.comboBoxHotKey.SelectedItem = this.comboBoxHotKey.Items.Cast<VirtualKeyCodeItem>().FirstOrDefault(i => i.VirtualKeyCode == virtualKeyCode) ?? this.comboBoxHotKey.Items[0];

            var fileExtension = Settings.Default.Format;
            foreach (var fileFormat in this._fileFormats)
            {
                var index = this.comboBoxFileFormat.Items.Add(fileFormat);
                if (fileFormat.Extension.Equals(fileExtension))
                {
                    this.comboBoxFileFormat.SelectedIndex = index;
                }
            }

            if (this.comboBoxFileFormat.SelectedIndex < 0)
            {
                this.comboBoxFileFormat.SelectedIndex = 0;
            }

            this.checkBoxHideOnCapture.Checked = true;

            for (var i = 1; i < 10; i++)
            {
                this.comboBoxDelay.Items.Add(i);
            }
            this.comboBoxDelay.SelectedIndex = 4;

            this._systemWideHotKeys.KeyPressed += (s2, e2) => this.CaptureScreen();

            void CheckRadioButton(GroupBox groupBox, Int32 tag)
            {
                var radioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Tag.ToString().Equals(tag.ToString())) as RadioButton ?? groupBox.Controls.OfType<RadioButton>().FirstOrDefault();
                if (radioButton != null)
                {
                    radioButton.Checked = true;
                }
            }
        }

        private void buttonClose_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCapture_Click(Object sender, EventArgs e)
        {
            if (this.checkBoxDelay.Checked)
            {
                var timer = new Timer { Interval = ((Int32)this.comboBoxDelay.SelectedItem) * 1000 };
                timer.Tick += (_, __) => this.CaptureScreen();
                timer.Tick += (_, __) => timer.Enabled = false;
                timer.Enabled = true;
            }
            else
            {
                this.CaptureScreen();
            }
        }

        private void CaptureScreen()
        {
            this.toolStripStatusLabel.Text = "";
            this.EnableControls(false);

            var source = GetTag(this.groupBoxSource);
            var target = GetTag(this.groupBoxTarget);

            Settings.Default.Source = source;
            Settings.Default.Target = target;

            if (1 == target)
            {
                ScreenCapture.CaptureToClipboard((ScreenCaptureSource)source);
            }
            else
            {
                var fileFormat = this.comboBoxFileFormat.SelectedItem as FileFormat;
                Settings.Default.Format = fileFormat.Extension;

                var targetDirectory = 2 == target ? Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) : this.linkLabelTargetDirectory.Text;
                if (!Directory.Exists(targetDirectory))
                {
                    this.ErrorBox("Directory does not exist");
                    return;
                }

                var fileNamePrefix = "ScreenCapture-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                fileNamePrefix = Path.Combine(targetDirectory, fileNamePrefix);

                var fileName = $"{fileNamePrefix}.{fileFormat.Extension}";

                var sequenceNumber = 1;
                while (File.Exists(fileName))
                {
                    sequenceNumber++;
                    fileName = $"{fileNamePrefix}-{sequenceNumber}.{fileFormat.Extension}";
                }

                ScreenCapture.CaptureToFile((ScreenCaptureSource)source, fileName, fileFormat.ImageFormat);

                this.toolStripStatusLabel.Text = $"Saved to '{fileName}'";

                Settings.Default.OpenFileExplorer = this.checkBoxOpenExplorerAfter.Checked;
                if (this.checkBoxOpenExplorerAfter.Checked)
                {
                    Process.Start("explorer.exe", $"/select,\"{fileName}\"");
                }
            }

            Settings.Default.Save();

            this.EnableControls(true);

            Int32 GetTag(GroupBox groupBox)
            {
                var tag = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Tag as String;
                return !String.IsNullOrEmpty(tag) && Int32.TryParse(tag, out var tagValue) ? tagValue : throw new Exception();
            }
        }

        private void EnableControls(Boolean enable)
        {
            if (!enable && this.checkBoxHideOnCapture.Checked)
            {
                this.Hide();
            }

            this.buttonCapture.Enabled = enable;
            this.groupBoxSource.Enabled = enable;
            this.groupBoxTarget.Enabled = enable;
            this.groupBoxOptions.Enabled = enable;
            this.groupBoxHotKey.Enabled = enable;

            if (enable && this.checkBoxHideOnCapture.Checked)
            {
                this.Show();
            }
        }

        private SystemWideHotKeys _systemWideHotKeys = new SystemWideHotKeys();
        private Int32 _systemWideHotKeyId = 0;

        private void checkBoxHotKey_CheckedChanged(Object sender, EventArgs e)
        {
            if (this.checkBoxHotKey.Checked)
            {
                var modifierKeys = (SystemWideModifierKey)this.GetCheckBoxBitmask(groupBoxHotKey);
                var virtualKeyCode = (this.comboBoxHotKey.SelectedItem as VirtualKeyCodeItem)?.VirtualKeyCode ?? VirtualKeyCode.None;

                if (VirtualKeyCode.None == virtualKeyCode)
                {
                    return;
                }

                this._systemWideHotKeyId = this._systemWideHotKeys.Register(virtualKeyCode, modifierKeys | SystemWideModifierKey.NoRepeat);

                Settings.Default.HotKeyVirtualKey = (Int32)virtualKeyCode;
                Settings.Default.HotKeyModifiers = (Int32)modifierKeys;
            }
            else
            {
                if (this._systemWideHotKeyId > 0)
                {
                    this._systemWideHotKeys.Unregister(this._systemWideHotKeyId);
                    this._systemWideHotKeyId = 0;
                }
            }

            var enable = !this.checkBoxHotKey.Checked;
            this.groupBoxHotKey.Controls.OfType<CheckBox>().Where(c => c.Tag != null).ForEach(c => c.Enabled = enable);
            this.comboBoxHotKey.Enabled = enable;
        }

        private Int32 GetCheckBoxBitmask(GroupBox groupBox)
        {
            var bitmask = 0;
            var checkboxes = this.groupBoxHotKey.Controls.OfType<CheckBox>();
            foreach (var checkbox in checkboxes)
            {
                if (Int32.TryParse(checkbox.Tag as String, out var bit))
                {
                    bitmask |= bit;
                }
            }

            return bitmask;
        }

        private void SetCheckBoxBitmask(GroupBox groupBox, Int32 bitmask)
        {
            var checkboxes = this.groupBoxHotKey.Controls.OfType<CheckBox>();
            foreach (var checkbox in checkboxes)
            {
                if (Int32.TryParse(checkbox.Tag as String, out var modifierKey) && (modifierKey == (bitmask & modifierKey)))
                {
                    checkbox.Checked = true;
                }
            }
        }

        private void buttonTargetDirectory_Click(Object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select directory to store screen captures:";
                dialog.SelectedPath = Directory.Exists(linkLabelTargetDirectory.Text) ? linkLabelTargetDirectory.Text : Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (DialogResult.OK == dialog.ShowDialog(this))
                {
                    linkLabelTargetDirectory.Text = dialog.SelectedPath;
                }
            }
        }

        private void linkLabelTargetDirectory_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", $"\"{this.linkLabelTargetDirectory.Text}\"");
        }

        private void radioButtonClipboard_CheckedChanged(Object sender, EventArgs e)
        {
            this.checkBoxOpenExplorerAfter.Enabled = !this.radioButtonClipboard.Checked;
        }

        private void radioButtonAnyFile_CheckedChanged(Object sender, EventArgs e)
        {
            this.buttonTargetDirectory.Enabled = this.radioButtonAnyFile.Checked;
            this.linkLabelTargetDirectory.Enabled = this.radioButtonAnyFile.Checked;
        }

        private void linkLabelAbout_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm.ShowDialog(this, "https://github.com/vurdalakov/screencapture");
        }

        private class VirtualKeyCodeItem
        {
            public VirtualKeyCode VirtualKeyCode { get; }

            public VirtualKeyCodeItem(VirtualKeyCode baseVirtualKeyCode, Int32 shift)
            {
                this.VirtualKeyCode = (VirtualKeyCode)((Int32)baseVirtualKeyCode + shift);
            }

            public override String ToString() => this.VirtualKeyCode.GetDisplayName();
        }
    }
}
