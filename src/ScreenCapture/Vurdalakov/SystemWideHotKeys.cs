namespace Vurdalakov
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [Flags]
    public enum SystemWideModifierKey
    {
        None = 0x0000,
        Alt = 0x0001, // MOD_ALT
        Control = 0x0002, // MOD_CONTROL
        Shift = 0x0004, // MOD_SHIFT
        Windows = 0x0008, // MOD_WIN
        NoRepeat = 0x4000 // MOD_NOREPEAT
    }

    public class SystemWideHotKeyPressedEventArgs : EventArgs
    {
        public Int32 HotKeyId { get; }
        public UInt32 VirtualKeyCode { get; }
        public SystemWideModifierKey ModifierKeys { get; }

        public SystemWideHotKeyPressedEventArgs(Int32 hotKeyId, UInt32 virtualKeyCode, SystemWideModifierKey modifierKeys)
        {
            this.HotKeyId = hotKeyId;
            this.VirtualKeyCode = virtualKeyCode;
            this.ModifierKeys = modifierKeys;
        }
    }

    public class SystemWideHotKeys : MessageOnlyWindow
    {
        private Int32 _lastHotKeyId = 0;
        private List<Int32> _registeredHotKeyIds = new List<Int32>();

        public event EventHandler<SystemWideHotKeyPressedEventArgs> KeyPressed;

        public SystemWideHotKeys()
        {
            this.CreateWindow("SystemWideHotKeysMessageOnlyWindow");
        }

        public Int32 Register(VirtualKeyCode virtualKeyCode, SystemWideModifierKey modifierKeys)
        {
            this._lastHotKeyId++;

            if (!RegisterHotKey(this.WindowHandle, _lastHotKeyId, (UInt32)modifierKeys, (UInt32)virtualKeyCode))
            {
                Tracer.Trace($"RegisterHotKey failed with error {Marshal.GetLastWin32Error()}");
                return 0;
            }

            this._registeredHotKeyIds.Add(this._lastHotKeyId);
            return this._lastHotKeyId;
        }

        public void Unregister(Int32 hotKeyId)
        {
            if (!this._registeredHotKeyIds.Contains(this._lastHotKeyId))
            {
                return;
            }

            if (!UnregisterHotKey(this.WindowHandle, hotKeyId))
            {
                Tracer.Trace($"UnregisterHotKey failed with error {Marshal.GetLastWin32Error()}");
                return;
            }

            this._registeredHotKeyIds.Remove(this._lastHotKeyId);
        }

        public void UnregisterAll()
        {
            foreach (var registeredHotKeyId in this._registeredHotKeyIds.ToArray())
            {
                this.Unregister(registeredHotKeyId);
            }
        }

        protected override IntPtr OnWindowProc(IntPtr hWnd, UInt32 msg, UIntPtr wParam, IntPtr lParam)
        {
            if (WM_HOTKEY == msg)
            {
                var hotKeyId = (Int32)wParam;
                var virtualKeyCode = lParam.HiWord();
                var modifierKeys = (SystemWideModifierKey)lParam.LoWord();

                this.KeyPressed?.Invoke(this, new SystemWideHotKeyPressedEventArgs(hotKeyId, virtualKeyCode, modifierKeys));
            }

            return base.OnWindowProc(hWnd, msg, wParam, lParam);
        }

        protected override void Dispose(Boolean disposing)
        {
            this.UnregisterAll();

            base.Dispose(disposing);
        }

        private static UInt32 WM_HOTKEY = 0x0312;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern Boolean RegisterHotKey(IntPtr hWnd, Int32 id, UInt32 fsModifiers, UInt32 vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern Boolean UnregisterHotKey(IntPtr hWnd, Int32 id);
    }
}
