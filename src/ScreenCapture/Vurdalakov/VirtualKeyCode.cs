namespace Vurdalakov
{
    using System;

    // https://msdn.microsoft.com/en-us/library/dd375731.aspx
    public enum VirtualKeyCode : UInt16
    {
        None = 0,
        LButton = 0x01,
        RButton = 0x02,
        Break = 0x03,
        MButton = 0x04,
        XButton1 = 0x05,
        XButton2 = 0x06,
        Back = 0x08,
        Tab = 0x09,
        Clear = 0x0C,
        Return = 0x0D,
        Shift = 0x10,
        Control = 0x11,
        [DisplayName("Alt")]
        Menu = 0x12,
        Pause = 0x13,
        [DisplayName("Caps Lock")]
        Capital = 0x14,
        Escape = 0x1B,
        Accept = 0x1E,
        Space = 0x20,
        [DisplayName("Page Up")]
        Prior = 0x21,
        [DisplayName("Page Down")]
        Next = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25, // Arrow Left
        Up = 0x26, // Arrow Up
        Right = 0x27, // Arrow Right
        Down = 0x28, // Arrow Down
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        [DisplayName("Print Screen")]
        Snapshot = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,
        [DisplayName("0")]
        Key0 = 0x30,
        [DisplayName("1")]
        Key1 = 0x31,
        [DisplayName("2")]
        Key2 = 0x32,
        [DisplayName("3")]
        Key3 = 0x33,
        [DisplayName("4")]
        Key4 = 0x34,
        [DisplayName("5")]
        Key5 = 0x35,
        [DisplayName("6")]
        Key6 = 0x36,
        [DisplayName("7")]
        Key7 = 0x37,
        [DisplayName("8")]
        Key8 = 0x38,
        [DisplayName("9")]
        Key9 = 0x39,
        [DisplayName("A")]
        KeyA = 0x41,
        [DisplayName("B")]
        KeyB = 0x42,
        [DisplayName("C")]
        KeyC = 0x43,
        [DisplayName("D")]
        KeyD = 0x44,
        [DisplayName("E")]
        KeyE = 0x45,
        [DisplayName("F")]
        KeyF = 0x46,
        [DisplayName("G")]
        KeyG = 0x47,
        [DisplayName("H")]
        KeyH = 0x48,
        [DisplayName("I")]
        KeyI = 0x49,
        [DisplayName("J")]
        KeyJ = 0x4A,
        [DisplayName("K")]
        KeyK = 0x4B,
        [DisplayName("L")]
        KeyL = 0x4C,
        [DisplayName("M")]
        KeyM = 0x4D,
        [DisplayName("N")]
        KeyN = 0x4E,
        [DisplayName("O")]
        KeyO = 0x4F,
        [DisplayName("P")]
        KeyP = 0x50,
        [DisplayName("Q")]
        KeyQ = 0x51,
        [DisplayName("R")]
        KeyR = 0x52,
        [DisplayName("S")]
        KeyS = 0x53,
        [DisplayName("T")]
        KeyT = 0x54,
        [DisplayName("U")]
        KeyU = 0x55,
        [DisplayName("V")]
        KeyV = 0x56,
        [DisplayName("W")]
        KeyW = 0x57,
        [DisplayName("X")]
        KeyX = 0x58,
        [DisplayName("Y")]
        KeyY = 0x59,
        [DisplayName("Z")]
        KeyZ = 0x5A,
        [DisplayName("Windows Left")]
        LWin = 0x5B,
        [DisplayName("Windows Right")]
        RWin = 0x5C,
        Apps = 0x5D,
        Sleep = 0x5F,
        Numpad0 = 0x60,
        Numpad1 = 0x61,
        Numpad2 = 0x62,
        Numpad3 = 0x63,
        Numpad4 = 0x64,
        Numpad5 = 0x65,
        Numpad6 = 0x66,
        Numpad7 = 0x67,
        Numpad8 = 0x68,
        Numpad9 = 0x69,
        Multiply = 0x6A,
        Add = 0x6B,
        Separator = 0x6C,
        Subtract = 0x6D,
        Decimal = 0x6E,
        Divide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
        NumLock = 0x90,
        [DisplayName("Scroll Lock")]
        Scroll = 0x90,
        [DisplayName("Shift Left")]
        LShift = 0xA0,
        [DisplayName("Shift Right")]
        RShift = 0xA1,
        [DisplayName("Control Left")]
        LControl = 0xA2,
        [DisplayName("Control Right")]
        RControl = 0xA3,
        [DisplayName("Alt Left")]
        LMenu = 0xA4,
        [DisplayName("Alt Right")]
        RMenu = 0xA5,
        BrowserBack = 0xA6,
        BrowserForward = 0xA7,
        BrowserRefresh = 0xA8,
        BrowserStop = 0xA9,
        BrowserSearch = 0xAA,
        BrowserFavorites = 0xAB,
        BrowserHome = 0xAC,
        VolumeMute = 0xAD,
        VolumeDown = 0xAE,
        VolumeUp = 0xAF,
        MediaNextTrack = 0xB0,
        MediaPrevTrack = 0xB1,
        MediaStop = 0xB2,
        MediaPlayPause = 0xB3,
        LaunchMail = 0xB4,
        LaunchMediaSelect = 0xB5,
        LaunchApp1 = 0xB6,
        LaunchApp2 = 0xB7,
        Oem1 = 0xBA, // For the US standard keyboard, the ';:' key 
        OemPlus = 0xBB,
        OemComma = 0xBC,
        OemMinus = 0xBD,
        OemPeriod = 0xBE, // dot (.)
        Oem2 = 0xBF, // For the US standard keyboard, the '/?' key
        Oem3 = 0xC0, // For the US standard keyboard, the '`~' key
        Oem4 = 0xDB, // For the US standard keyboard, the '[{' key
        Oem5 = 0xDC, // For the US standard keyboard, the '\|' key
        Oem6 = 0xDD, // For the US standard keyboard, the ']}' key
        Oem7 = 0xDE, // For the US standard keyboard, the 'single-quote/double-quote' key
        Oem8 = 0xDF, // Used for miscellaneous characters; it can vary by keyboard
        Oem102 = 0xE2, // Either the angle bracket key or the backslash key on the RT 102-key keyboard
        ProcessKey = 0xE5,
        Packet = 0xE7,
        Attn = 0xF6,
        CrSel = 0xF7,
        Exsel = 0xF8,
        Ereof = 0xF9,
        Play = 0xFA,
        Zoom = 0xFB,
        Noname = 0xFC,
        Pa1 = 0xFD,
        OemClear = 0xFE,
    }
}
