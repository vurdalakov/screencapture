namespace Vurdalakov
{
    using System;
    using System.Runtime.InteropServices;

    public static partial class WinApi
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public Int32 left;
            public Int32 top;
            public Int32 right;
            public Int32 bottom;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern Boolean GetWindowRect(IntPtr hWnd, out RECT lpRect);
    }
}
