namespace Vurdalakov
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    // https://docs.microsoft.com/en-us/windows/desktop/api/_dwm/
    public class DesktopWindowManager
    {
        public static Boolean DisableTransitions(IntPtr windowHandle)
        {
            var value = new IntPtr(1U);  // TRUE to disable
            return 0 == DwmSetWindowAttribute(windowHandle, DWMWA_TRANSITIONS_FORCEDISABLED, ref value, (UInt32)Marshal.SizeOf(value));
        }

        public static Rectangle GetExtendedFrameBounds(IntPtr windowHandle)
        {
            var rect = new WinApi.RECT();

            if (DwmGetWindowAttribute(windowHandle, DWMWA_EXTENDED_FRAME_BOUNDS, ref rect, (UInt32)Marshal.SizeOf(typeof(WinApi.RECT))) != 0)
            {
                // fallback
                WinApi.GetWindowRect(windowHandle, out rect);
            }

            return new Rectangle(rect.left, rect.top, rect.right - rect.left + 1, rect.bottom - rect.top + 1);
        }

        private const UInt32 DWMWA_TRANSITIONS_FORCEDISABLED = 3;
        private const UInt32 DWMWA_EXTENDED_FRAME_BOUNDS = 9;

        [DllImport("dwmapi", PreserveSig = true)]
        private static extern int DwmGetWindowAttribute(IntPtr hwnd, UInt32 dwAttribute, ref WinApi.RECT pvAttribute, UInt32 cbAttribute);

        [DllImport("dwmapi", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, UInt32 dwAttribute, ref IntPtr pvAttribute, UInt32 cbAttribute);
    }
}
