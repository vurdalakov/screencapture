namespace Vurdalakov
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxTarget = new System.Windows.Forms.GroupBox();
            this.buttonTargetDirectory = new System.Windows.Forms.Button();
            this.linkLabelTargetDirectory = new System.Windows.Forms.LinkLabel();
            this.radioButtonAnyFile = new System.Windows.Forms.RadioButton();
            this.checkBoxOpenExplorerAfter = new System.Windows.Forms.CheckBox();
            this.radioButtonDesktopFile = new System.Windows.Forms.RadioButton();
            this.radioButtonClipboard = new System.Windows.Forms.RadioButton();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.radioButtonAllScreens = new System.Windows.Forms.RadioButton();
            this.radioButtonPrimaryScreen = new System.Windows.Forms.RadioButton();
            this.radioButtonActiveScreen = new System.Windows.Forms.RadioButton();
            this.radioButtonActiveWindow = new System.Windows.Forms.RadioButton();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxHideOnCapture = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxFileFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDelay = new System.Windows.Forms.ComboBox();
            this.checkBoxDelay = new System.Windows.Forms.CheckBox();
            this.groupBoxHotKey = new System.Windows.Forms.GroupBox();
            this.checkBoxHotKey = new System.Windows.Forms.CheckBox();
            this.comboBoxHotKey = new System.Windows.Forms.ComboBox();
            this.checkBoxHotKeyShift = new System.Windows.Forms.CheckBox();
            this.checkBoxHotKeyControl = new System.Windows.Forms.CheckBox();
            this.checkBoxHotKeyAlt = new System.Windows.Forms.CheckBox();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxTarget.SuspendLayout();
            this.groupBoxSource.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxHotKey.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTarget
            // 
            this.groupBoxTarget.Controls.Add(this.buttonTargetDirectory);
            this.groupBoxTarget.Controls.Add(this.linkLabelTargetDirectory);
            this.groupBoxTarget.Controls.Add(this.radioButtonAnyFile);
            this.groupBoxTarget.Controls.Add(this.checkBoxOpenExplorerAfter);
            this.groupBoxTarget.Controls.Add(this.radioButtonDesktopFile);
            this.groupBoxTarget.Controls.Add(this.radioButtonClipboard);
            this.groupBoxTarget.Location = new System.Drawing.Point(254, 13);
            this.groupBoxTarget.Name = "groupBoxTarget";
            this.groupBoxTarget.Size = new System.Drawing.Size(200, 151);
            this.groupBoxTarget.TabIndex = 0;
            this.groupBoxTarget.TabStop = false;
            this.groupBoxTarget.Text = "Target";
            // 
            // buttonTargetDirectory
            // 
            this.buttonTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTargetDirectory.Location = new System.Drawing.Point(148, 62);
            this.buttonTargetDirectory.Name = "buttonTargetDirectory";
            this.buttonTargetDirectory.Size = new System.Drawing.Size(34, 22);
            this.buttonTargetDirectory.TabIndex = 5;
            this.buttonTargetDirectory.Text = "...";
            this.buttonTargetDirectory.UseVisualStyleBackColor = true;
            this.buttonTargetDirectory.Click += new System.EventHandler(this.buttonTargetDirectory_Click);
            // 
            // linkLabelTargetDirectory
            // 
            this.linkLabelTargetDirectory.AutoEllipsis = true;
            this.linkLabelTargetDirectory.Location = new System.Drawing.Point(15, 91);
            this.linkLabelTargetDirectory.Name = "linkLabelTargetDirectory";
            this.linkLabelTargetDirectory.Size = new System.Drawing.Size(179, 15);
            this.linkLabelTargetDirectory.TabIndex = 4;
            this.linkLabelTargetDirectory.TabStop = true;
            this.linkLabelTargetDirectory.Text = "linkLabel1";
            this.linkLabelTargetDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTargetDirectory_LinkClicked);
            // 
            // radioButtonAnyFile
            // 
            this.radioButtonAnyFile.AutoSize = true;
            this.radioButtonAnyFile.Location = new System.Drawing.Point(16, 67);
            this.radioButtonAnyFile.Name = "radioButtonAnyFile";
            this.radioButtonAnyFile.Size = new System.Drawing.Size(126, 17);
            this.radioButtonAnyFile.TabIndex = 3;
            this.radioButtonAnyFile.Tag = "3";
            this.radioButtonAnyFile.Text = "File in specified folder";
            this.radioButtonAnyFile.UseVisualStyleBackColor = true;
            this.radioButtonAnyFile.CheckedChanged += new System.EventHandler(this.radioButtonAnyFile_CheckedChanged);
            // 
            // checkBoxOpenExplorerAfter
            // 
            this.checkBoxOpenExplorerAfter.AutoSize = true;
            this.checkBoxOpenExplorerAfter.Enabled = false;
            this.checkBoxOpenExplorerAfter.Location = new System.Drawing.Point(16, 121);
            this.checkBoxOpenExplorerAfter.Name = "checkBoxOpenExplorerAfter";
            this.checkBoxOpenExplorerAfter.Size = new System.Drawing.Size(175, 17);
            this.checkBoxOpenExplorerAfter.TabIndex = 2;
            this.checkBoxOpenExplorerAfter.Text = "Open File Explorer after capture";
            this.checkBoxOpenExplorerAfter.UseVisualStyleBackColor = true;
            // 
            // radioButtonDesktopFile
            // 
            this.radioButtonDesktopFile.AutoSize = true;
            this.radioButtonDesktopFile.Location = new System.Drawing.Point(16, 44);
            this.radioButtonDesktopFile.Name = "radioButtonDesktopFile";
            this.radioButtonDesktopFile.Size = new System.Drawing.Size(99, 17);
            this.radioButtonDesktopFile.TabIndex = 1;
            this.radioButtonDesktopFile.Tag = "2";
            this.radioButtonDesktopFile.Text = "File on &Desktop";
            this.radioButtonDesktopFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonClipboard
            // 
            this.radioButtonClipboard.AutoSize = true;
            this.radioButtonClipboard.Checked = true;
            this.radioButtonClipboard.Location = new System.Drawing.Point(16, 20);
            this.radioButtonClipboard.Name = "radioButtonClipboard";
            this.radioButtonClipboard.Size = new System.Drawing.Size(69, 17);
            this.radioButtonClipboard.TabIndex = 0;
            this.radioButtonClipboard.TabStop = true;
            this.radioButtonClipboard.Tag = "1";
            this.radioButtonClipboard.Text = "Clip&board";
            this.radioButtonClipboard.UseVisualStyleBackColor = true;
            this.radioButtonClipboard.CheckedChanged += new System.EventHandler(this.radioButtonClipboard_CheckedChanged);
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.Controls.Add(this.radioButtonAllScreens);
            this.groupBoxSource.Controls.Add(this.radioButtonPrimaryScreen);
            this.groupBoxSource.Controls.Add(this.radioButtonActiveScreen);
            this.groupBoxSource.Controls.Add(this.radioButtonActiveWindow);
            this.groupBoxSource.Location = new System.Drawing.Point(28, 13);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(200, 151);
            this.groupBoxSource.TabIndex = 1;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Source";
            // 
            // radioButtonAllScreens
            // 
            this.radioButtonAllScreens.AutoSize = true;
            this.radioButtonAllScreens.Location = new System.Drawing.Point(16, 97);
            this.radioButtonAllScreens.Name = "radioButtonAllScreens";
            this.radioButtonAllScreens.Size = new System.Drawing.Size(78, 17);
            this.radioButtonAllScreens.TabIndex = 3;
            this.radioButtonAllScreens.TabStop = true;
            this.radioButtonAllScreens.Tag = "4";
            this.radioButtonAllScreens.Text = "&All Screens";
            this.radioButtonAllScreens.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrimaryScreen
            // 
            this.radioButtonPrimaryScreen.AutoSize = true;
            this.radioButtonPrimaryScreen.Location = new System.Drawing.Point(16, 74);
            this.radioButtonPrimaryScreen.Name = "radioButtonPrimaryScreen";
            this.radioButtonPrimaryScreen.Size = new System.Drawing.Size(96, 17);
            this.radioButtonPrimaryScreen.TabIndex = 2;
            this.radioButtonPrimaryScreen.TabStop = true;
            this.radioButtonPrimaryScreen.Tag = "3";
            this.radioButtonPrimaryScreen.Text = "&Primary Screen";
            this.radioButtonPrimaryScreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonActiveScreen
            // 
            this.radioButtonActiveScreen.AutoSize = true;
            this.radioButtonActiveScreen.Location = new System.Drawing.Point(16, 51);
            this.radioButtonActiveScreen.Name = "radioButtonActiveScreen";
            this.radioButtonActiveScreen.Size = new System.Drawing.Size(92, 17);
            this.radioButtonActiveScreen.TabIndex = 1;
            this.radioButtonActiveScreen.TabStop = true;
            this.radioButtonActiveScreen.Tag = "2";
            this.radioButtonActiveScreen.Text = "Active &Screen";
            this.radioButtonActiveScreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonActiveWindow
            // 
            this.radioButtonActiveWindow.AutoSize = true;
            this.radioButtonActiveWindow.Location = new System.Drawing.Point(16, 28);
            this.radioButtonActiveWindow.Name = "radioButtonActiveWindow";
            this.radioButtonActiveWindow.Size = new System.Drawing.Size(97, 17);
            this.radioButtonActiveWindow.TabIndex = 0;
            this.radioButtonActiveWindow.TabStop = true;
            this.radioButtonActiveWindow.Tag = "1";
            this.radioButtonActiveWindow.Text = "Active &Window";
            this.radioButtonActiveWindow.UseVisualStyleBackColor = true;
            // 
            // buttonCapture
            // 
            this.buttonCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapture.Location = new System.Drawing.Point(28, 182);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(200, 79);
            this.buttonCapture.TabIndex = 2;
            this.buttonCapture.Text = "&Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(254, 205);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(200, 32);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBoxHideOnCapture
            // 
            this.checkBoxHideOnCapture.AutoSize = true;
            this.checkBoxHideOnCapture.Location = new System.Drawing.Point(15, 21);
            this.checkBoxHideOnCapture.Name = "checkBoxHideOnCapture";
            this.checkBoxHideOnCapture.Size = new System.Drawing.Size(102, 17);
            this.checkBoxHideOnCapture.TabIndex = 4;
            this.checkBoxHideOnCapture.Text = "&Hide on capture";
            this.checkBoxHideOnCapture.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.comboBoxFileFormat);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.comboBoxDelay);
            this.groupBoxOptions.Controls.Add(this.checkBoxDelay);
            this.groupBoxOptions.Controls.Add(this.checkBoxHideOnCapture);
            this.groupBoxOptions.Location = new System.Drawing.Point(479, 13);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(200, 114);
            this.groupBoxOptions.TabIndex = 2;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // comboBoxFileFormat
            // 
            this.comboBoxFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileFormat.FormattingEnabled = true;
            this.comboBoxFileFormat.Location = new System.Drawing.Point(77, 74);
            this.comboBoxFileFormat.Name = "comboBoxFileFormat";
            this.comboBoxFileFormat.Size = new System.Drawing.Size(107, 21);
            this.comboBoxFileFormat.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "&File format:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "seconds";
            // 
            // comboBoxDelay
            // 
            this.comboBoxDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelay.FormattingEnabled = true;
            this.comboBoxDelay.Location = new System.Drawing.Point(100, 41);
            this.comboBoxDelay.Name = "comboBoxDelay";
            this.comboBoxDelay.Size = new System.Drawing.Size(34, 21);
            this.comboBoxDelay.TabIndex = 6;
            // 
            // checkBoxDelay
            // 
            this.checkBoxDelay.AutoSize = true;
            this.checkBoxDelay.Location = new System.Drawing.Point(15, 45);
            this.checkBoxDelay.Name = "checkBoxDelay";
            this.checkBoxDelay.Size = new System.Drawing.Size(87, 17);
            this.checkBoxDelay.TabIndex = 5;
            this.checkBoxDelay.Text = "Capt&ure after";
            this.checkBoxDelay.UseVisualStyleBackColor = true;
            // 
            // groupBoxHotKey
            // 
            this.groupBoxHotKey.Controls.Add(this.checkBoxHotKey);
            this.groupBoxHotKey.Controls.Add(this.comboBoxHotKey);
            this.groupBoxHotKey.Controls.Add(this.checkBoxHotKeyShift);
            this.groupBoxHotKey.Controls.Add(this.checkBoxHotKeyControl);
            this.groupBoxHotKey.Controls.Add(this.checkBoxHotKeyAlt);
            this.groupBoxHotKey.Location = new System.Drawing.Point(479, 143);
            this.groupBoxHotKey.Name = "groupBoxHotKey";
            this.groupBoxHotKey.Size = new System.Drawing.Size(200, 123);
            this.groupBoxHotKey.TabIndex = 4;
            this.groupBoxHotKey.TabStop = false;
            this.groupBoxHotKey.Text = "Hot Key";
            // 
            // checkBoxHotKey
            // 
            this.checkBoxHotKey.AutoSize = true;
            this.checkBoxHotKey.Location = new System.Drawing.Point(15, 19);
            this.checkBoxHotKey.Name = "checkBoxHotKey";
            this.checkBoxHotKey.Size = new System.Drawing.Size(143, 17);
            this.checkBoxHotKey.TabIndex = 11;
            this.checkBoxHotKey.Text = "Use system-wide hot key";
            this.checkBoxHotKey.UseVisualStyleBackColor = true;
            this.checkBoxHotKey.CheckedChanged += new System.EventHandler(this.checkBoxHotKey_CheckedChanged);
            // 
            // comboBoxHotKey
            // 
            this.comboBoxHotKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotKey.FormattingEnabled = true;
            this.comboBoxHotKey.Location = new System.Drawing.Point(128, 58);
            this.comboBoxHotKey.Name = "comboBoxHotKey";
            this.comboBoxHotKey.Size = new System.Drawing.Size(56, 21);
            this.comboBoxHotKey.TabIndex = 10;
            // 
            // checkBoxHotKeyShift
            // 
            this.checkBoxHotKeyShift.AutoSize = true;
            this.checkBoxHotKeyShift.Location = new System.Drawing.Point(72, 85);
            this.checkBoxHotKeyShift.Name = "checkBoxHotKeyShift";
            this.checkBoxHotKeyShift.Size = new System.Drawing.Size(47, 17);
            this.checkBoxHotKeyShift.TabIndex = 2;
            this.checkBoxHotKeyShift.Tag = "4";
            this.checkBoxHotKeyShift.Text = "Shift";
            this.checkBoxHotKeyShift.UseVisualStyleBackColor = true;
            // 
            // checkBoxHotKeyControl
            // 
            this.checkBoxHotKeyControl.AutoSize = true;
            this.checkBoxHotKeyControl.Location = new System.Drawing.Point(72, 62);
            this.checkBoxHotKeyControl.Name = "checkBoxHotKeyControl";
            this.checkBoxHotKeyControl.Size = new System.Drawing.Size(59, 17);
            this.checkBoxHotKeyControl.TabIndex = 1;
            this.checkBoxHotKeyControl.Tag = "2";
            this.checkBoxHotKeyControl.Text = "Control";
            this.checkBoxHotKeyControl.UseVisualStyleBackColor = true;
            // 
            // checkBoxHotKeyAlt
            // 
            this.checkBoxHotKeyAlt.AutoSize = true;
            this.checkBoxHotKeyAlt.Location = new System.Drawing.Point(72, 39);
            this.checkBoxHotKeyAlt.Name = "checkBoxHotKeyAlt";
            this.checkBoxHotKeyAlt.Size = new System.Drawing.Size(38, 17);
            this.checkBoxHotKeyAlt.TabIndex = 0;
            this.checkBoxHotKeyAlt.Tag = "1";
            this.checkBoxHotKeyAlt.Text = "Alt";
            this.checkBoxHotKeyAlt.UseVisualStyleBackColor = true;
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Location = new System.Drawing.Point(644, 269);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(35, 13);
            this.linkLabelAbout.TabIndex = 5;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "About";
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 291);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(706, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(691, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonCapture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(706, 313);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.groupBoxHotKey);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.groupBoxSource);
            this.Controls.Add(this.groupBoxTarget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Capture";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxTarget.ResumeLayout(false);
            this.groupBoxTarget.PerformLayout();
            this.groupBoxSource.ResumeLayout(false);
            this.groupBoxSource.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxHotKey.ResumeLayout(false);
            this.groupBoxHotKey.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTarget;
        private System.Windows.Forms.RadioButton radioButtonDesktopFile;
        private System.Windows.Forms.RadioButton radioButtonClipboard;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.RadioButton radioButtonPrimaryScreen;
        private System.Windows.Forms.RadioButton radioButtonActiveScreen;
        private System.Windows.Forms.RadioButton radioButtonActiveWindow;
        private System.Windows.Forms.RadioButton radioButtonAllScreens;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxHideOnCapture;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDelay;
        private System.Windows.Forms.CheckBox checkBoxDelay;
        private System.Windows.Forms.ComboBox comboBoxFileFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxHotKey;
        private System.Windows.Forms.CheckBox checkBoxHotKeyShift;
        private System.Windows.Forms.CheckBox checkBoxHotKeyControl;
        private System.Windows.Forms.CheckBox checkBoxHotKeyAlt;
        private System.Windows.Forms.ComboBox comboBoxHotKey;
        private System.Windows.Forms.CheckBox checkBoxHotKey;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.CheckBox checkBoxOpenExplorerAfter;
        private System.Windows.Forms.RadioButton radioButtonAnyFile;
        private System.Windows.Forms.LinkLabel linkLabelTargetDirectory;
        private System.Windows.Forms.Button buttonTargetDirectory;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

