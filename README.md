# BackgroundTaskRunner

A simple Visual Basic app that starts/stops an executable of your choosing automatically.
The executable will be started when either the computer is locked, or when the screensaver starts.
Likewise, the executable will be stopped when the computer is unlocked, or when the screensaver stops.

### Building The Project

This is a Visual Basic project built with Visual Studio 2017:  
https://www.visualstudio.com

Guide linking to a git project VS:  
https://docs.microsoft.com/en-us/vsts/git/gitquickstart?tabs=visual-studio

### Direct Download

Direct download for the release executable can be found here:  
https://github.com/jospete/BackgroundTaskRunner/tree/master/BackgroundTaskRunner/bin/Release

### Tips

- Make sure that you either lock your computer manually (Windows+L) or have a screensaver set for this runner to activate.
- This runner will not run on startup, and must remain open for the selected executable to be run in the background.
- Once you've entered a valid "exe" or "bat" path into the "Executable" box, you can test the runner by pressing the "Start" and "Stop" buttons.
- If the runner becomes slow to respond, try clearing the logs and hitting the "Stop" button to make sure there's no lingering funk.
- Un-checking "Stop on Awake" will allow a process to keep running when your computer wakes up. This is useful if you want to check the history of the running app before closing it.
