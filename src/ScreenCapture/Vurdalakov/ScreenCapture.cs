namespace Vurdalakov
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public enum ScreenCaptureSource
    {
        ActiveWindow = 1,
        ActiveScreen = 2,
        PrimaryScreen = 3,
        AllScreens = 4
    };

    public static class ScreenCapture
    {
        public static void CaptureToClipboard(ScreenCaptureSource screenCaptureSource)
        {
            var action = new Action<Bitmap>((bitmap) => Clipboard.SetImage(bitmap));

            Capture(screenCaptureSource, action);
        }

        public static void CaptureToFile(ScreenCaptureSource screenCaptureSource, String fileName, ImageFormat imageFormat)
        {
            var action = new Action<Bitmap>((bitmap) => bitmap.Save(fileName, imageFormat));

            Capture(screenCaptureSource, action);
        }

        private static void Capture(ScreenCaptureSource screenCaptureSource, Action<Bitmap> action)
        {
            switch (screenCaptureSource)
            {
                case ScreenCaptureSource.ActiveWindow:
                    CaptureActiveWindow(action);
                    break;
                case ScreenCaptureSource.ActiveScreen:
                    CaptureScreen(Screen.FromHandle(WinApi.GetForegroundWindow()), action);
                    break;
                case ScreenCaptureSource.PrimaryScreen:
                    CaptureScreen(Screen.PrimaryScreen, action);
                    break;
                case ScreenCaptureSource.AllScreens:
                    CaptureAllScreens(action);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private static void CaptureActiveWindow(Action<Bitmap> action)
        {
            var handle = WinApi.GetForegroundWindow();
            if (IntPtr.Zero == handle) // The foreground window can be NULL in certain circumstances, such as when a window is losing activation
            {
                return;
            }

            using (var bitmap = GetWindowBitmap(handle))
            {
                action.Invoke(bitmap);
            }
        }

        private static void CaptureScreen(Screen screen, Action<Bitmap> action)
        {
            using (var bitmap = GetScreeenBitmap(screen))
            {
                action.Invoke(bitmap);
            }
        }

        private static void CaptureAllScreens(Action<Bitmap> action)
        {
            var screens = Screen.AllScreens.OrderBy(s => s.Bounds.X);

            var width = 0;
            var height = 0;
            foreach (var screen in screens)
            {
                width += screen.Bounds.Width;
                height = Math.Max(height, screen.Bounds.Height);
            }

            using (var bitmap = new Bitmap(width, height))
            {
                var x = 0;
                foreach (var screen in screens)
                {
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, x, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
                    }

                    x += screen.Bounds.Width;
                }

                action.Invoke(bitmap);
            }
        }

        private static Bitmap GetScreeenBitmap(Screen screen)
        {
            var bitmap = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
            }

            return bitmap;
        }

        private static Bitmap GetWindowBitmap(IntPtr handle)
        {
            WinApi.GetWindowRect(handle, out var rect);
            var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left + 1, rect.bottom - rect.top + 1);
            var bounds2 = DesktopWindowManager.GetExtendedFrameBounds(handle);
            bounds = bounds2;

            var bitmap = new Bitmap(bounds.Width, bounds.Height);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
            }

            return bitmap;
        }
    }
}
