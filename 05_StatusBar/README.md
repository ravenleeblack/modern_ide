In the previous lesson, we prepared the DockPanel, a necessary step for this lesson. Now, we'll focus on setting up the status bar at the bottom of our window and integrating it into the DockPanel. The StatusBar control is primarily used to host controls that display information, such as Label and ProgressBar controls.

With the DockPanel already in place, here's how to configure the StatusBar:

```xml
<DockPanel Grid.Row="4" Grid.Column="0" Grid.ColumnSpan="22" LastChildFill="True">

      <StatusBar x:Name="status_bar" DockPanel.Dock="Bottom" Background="#FF1E1E1E" Foreground="DarkOrange" BorderBrush="Black" BorderThickness="1">
           <StatusBarItem>
                 <TextBlock x:Name="status_text" Text="Status: Ready" />
           </StatusBarItem>
      </StatusBar>

</DockPanel>
```

In this code:

- We've named our StatusBar as `x:Name="status_bar"` for future reference.
- The `DockPanel.Dock="Bottom"` attribute ensures that the StatusBar is placed at the bottom of the DockPanel.
- We've set the background color to `Background="#FF1E1E1E"`, matching the main menu's color.
- The foreground color is set to `Foreground="DarkOrange"`, providing a contrasting bright orange color to offset the darkness at the bottom. The RGB values for this orange are 255, 140, 0.
- The BorderBrush is set to black with RGB values of 0, 0, 0, and the BorderThickness is set to 1 on all four sides.
- We've adjusted the StatusBar's width to 1920 and the height to 20.

Regarding the StatusBar's TextBlock, we've named it and set its text to "Status: Ready" for now. We plan to make the StatusBar fully orange when the run button is pressed and display "Status: Running." Therefore, having the initial text as "Status: Ready" is appropriate.

For the time being, the StatusBar will remain in the middle of the DockPanel. So at this stage, your window should look like this at runtime:

![screen_2](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/4a5934e0-769d-4703-96bb-4420f5753a9f)

And the new StatusBar:

![statusbar](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/29696fe4-8fb5-4baf-8441-735818b13290)

