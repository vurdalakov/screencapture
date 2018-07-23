namespace Vurdalakov
{
    using System;
    using System.Drawing.Imaging;

    // BMP, GIF, JPEG, PNG, TIFF
    public class FileFormat
    {
        public ImageFormat ImageFormat { get; }
        public String Extension { get; }
        public String DisplayName { get; }

        public FileFormat(ImageFormat imageFormat, String extension, String displayName)
        {
            this.ImageFormat = imageFormat;
            this.Extension = extension;
            this.DisplayName = displayName;
        }

        public override String ToString() => this.DisplayName;
    }
}
