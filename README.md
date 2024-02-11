Show a specified message during a specified time delay. Then automatically close the window.

Pass two Command-line parameters when starting the Application:
1. Delay duration in milliseconds, after which the window with message will automatically close and application will finish
2. The message text to display

It may be thought of as an equivalent to the VBScript command:

    WScript.CreateObject("WScript.Shell").Popup ...
