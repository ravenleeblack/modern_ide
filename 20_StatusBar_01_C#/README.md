In this lesson, we will use C# to implement a feature that changes the color of the status bar to orange (RGB) and displays the text "Status: Running" when the "Run" button is pressed. It will return to its normal state when the "Stop" button is pressed. This behavior is similar to the one found in Visual Studio, which helps users stay informed about the compiler's status. It's a useful feature to prevent distractions and indicate that a process is still running.

In this code, we use event handlers for the "Run" and "Stop" buttons. When the "Run" button is clicked, it changes the status bar's background color to orange and displays the "Status: Running" text. When the "Stop" button is clicked, it restores the status bar to its normal state and clears the status text. The isRunning variable is used to track the running status, ensuring that we don't change the status bar's appearance if it's already in a running state.

The end result is a feature that enhances your IDE, providing a visual indicator of the running status in the status bar, as shown in the image:

![screen_12](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/1fa5e29d-fb64-473f-8b7c-30780edcb04c)
