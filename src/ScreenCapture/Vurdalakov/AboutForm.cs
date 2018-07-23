namespace Vurdalakov
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public class AboutForm
    {
        private IWin32Window _owner;
        private String _productUrl;

        public static void ShowDialog(IWin32Window owner, String productUrl = null)
        {
            var aboutForm = new AboutForm(owner, productUrl);
            aboutForm.ShowDialog();
        }

        public AboutForm(IWin32Window owner, String productUrl = null)
        {
            this._owner = owner;
            this._productUrl = productUrl;
        }

        public void ShowDialog()
        {
            using (var form = new Form())
            {
                var assemblyInformation = new AssemblyInformation();

                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.ShowIcon = false;
                form.ShowInTaskbar = false;
                form.StartPosition = FormStartPosition.CenterParent;

                form.Text = "About";

                const Int32 dy = 8;
                var top = dy * 2;

                var label = AddLabel(assemblyInformation.Product);
                label.Font = new Font(label.Font, FontStyle.Bold);
                AddLabel($"Version {assemblyInformation.ProductVersion}");
                AddLabel(assemblyInformation.Copyright);

                if (!String.IsNullOrEmpty(this._productUrl))
                {
                    var linkLabel = AddControl(new LinkLabel() { Text = "OK", Width = form.Width, TextAlign = ContentAlignment.MiddleCenter }) as LinkLabel;
                    linkLabel.Text = this._productUrl;
                    linkLabel.Click += (s, e) => Process.Start(this._productUrl);
                }

                top += dy;

                var okButton = AddControl(new Button() { Text = "OK" }) as Button;
                okButton.Click += (s, e) => form.Close();
                form.AcceptButton = okButton;
                form.CancelButton = okButton;

                form.Height = form.RectangleToScreen(form.ClientRectangle).Top - form.Top + top + dy * 2;

                form.ShowDialog(this._owner);

                Control AddLabel(String labelText)
                {
                    return AddControl(new Label() { Text = labelText, Width = form.Width, TextAlign = ContentAlignment.MiddleCenter });
                }

                Control AddControl(Control control)
                {
                    form.Controls.Add(control);

                    control.Left = (control.Parent.ClientRectangle.Width - control.Width) / 2;
                    control.Top = top;
                    top += control.Height + dy;

                    return control;
                }
            }
        }
    }
}
