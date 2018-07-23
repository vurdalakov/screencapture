# Screen Capture C# application

## Features

* Captures active application, active or primary screen or all screens.
* Copies capture to Clipboard.
* Saves capture to BMP, GIF, JPEG, PNG or TIFF file on Desktop or any other selected location.
* Optionally opens Windows Explorer with capture file selected.
* Optionally hides application when taking screenshot.
* Optionally delays screen capture by 1-9 seconds.
* Optionally sets system-wide hot key.

## Points of interest

* [AssemblyInformation class](https://github.com/vurdalakov/screencapture/blob/master/src/UsbDevicesDotNet/Vurdalakov/AssemblyInformation.cs) - reads all fields of AssemblyInfo.cs file from any assembly.
* [DesktopWindowManager class](https://github.com/vurdalakov/screencapture/blob/master/src/UsbDevicesDotNet/Vurdalakov/DesktopWindowManager.cs)- access to some functions of [Desktop Window Manager (DWM)](https://docs.microsoft.com/en-us/windows/desktop/api/_dwm/).
* [MessageOnlyWindow class](https://github.com/vurdalakov/screencapture/blob/master/src/UsbDevicesDotNet/Vurdalakov/MessageOnlyWindow.cs) - a message-only WinApi window.
* [ScreenCapture class](https://github.com/vurdalakov/screencapture/blob/master/src/UsbDevicesDotNet/Vurdalakov/ScreenCapture.cs) - captures active application, active or primary screen or all screens to Clipboard or file.
* [SystemWideHotKeys class](https://github.com/vurdalakov/screencapture/blob/master/src/UsbDevicesDotNet/Vurdalakov/SystemWideHotKeys.cs) - sets system-wide hot key using [RegisterHotKey](https://msdn.microsoft.com/en-us/library/windows/desktop/ms646309.aspx) function.

## License

Distributed under the terms of the [MIT license](https://opensource.org/licenses/MIT).

## Acknowledgments

* [Camera Icon](http://www.iconarchive.com/show/circle-icons-by-martz90/camera-icon.html) by Martz90 under [CC Attribution-Noncommercial-No Derivate 4.0 license](https://creativecommons.org/licenses/by-nc-nd/4.0/).
