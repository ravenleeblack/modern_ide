
In the previous lesson we set up the DockPanel. We had to set it up before we could move on to this lesson. In this lesson we will be setting up the status bar at the bottom of our window. We will be adding it into the DockPanel. The StatusBar control is used primary to host controls that display information such as the Label and ProgressBar controls.

We have already set up the DockPanel so we dont need to worry about it in the code below. It is just an example of how the statusbar is suppose to look inside the opening and closing tags. First we are going to name our statusbar ```x:Name="status_bar"``` just in case we need it call it for future reference. Nexr we are going to set the statusbar into the DockPanel and put it into the bottom panel. ```DockPanel.Dock="Bottom"```. Like before I like to keep code somewhat uniform we will set our background color, foreground color, BorderBrush, and then our BorderThickness. I try to keep using the samein all areas so that its read and access when we use a certain pattern the same way everytime. I chose to make the Background color ```Background="#FF1E1E1E"``` rgb 20, 20, 20 which should match our main menu. I chose to make the foreground color ```Foreground="DarkOrange"``` a bright orange this time to offset the darkness at the bottom and to show a new area of infomation since we used Teal for the the main menu area. The orange rgb is 255, 140, 0.  Then we need to set a border ```BorderBrush="Black"``` which has been rgb 0, 0, 0  and finally we set the border thickness which has been 1 on all 4 sides. ```BorderThickness="1"```. Under layout we need to make sure the Statusbar's width is 1920 and the height is at 20 otherwise you will get some funky results because its set at 300 something.

Ill get back to you with more infomation about the the StatusBarItem itself but here we are using one so that we can use the TextBlock. Again we name the TextBlock  and then we set the text we need which is just the status of our ide. We are going to be making the StatusBar change fully to an orange later when the run button is pressed and it will say Status: Running so having the StatusBar TxtBlock be set to Status: Ready seems to make sense.

```
<DockPanel Grid.Row="4" Grid.Column="0" Grid.ColumnSpan="22" LastChildFill="True">

      <StatusBar x:Name="status_bar" DockPanel.Dock="Bottom" Background="#FF1E1E1E" Foreground="DarkOrange" BorderBrush="Black" BorderThickness="1">
           <StatusBarItem>
                 TextBlock x:Name="status_text" Text="Status: Ready" />
           </StatusBarItem>
      </StatusBar>

</DockPanel>

```




For the moment, I think the StatusBar will stay in the middle of the DockPanel, until we add in more windows. So at the moment you should have a window that looks like this at runtime:

![screen_2](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/4a5934e0-769d-4703-96bb-4420f5753a9f)

And the new StatusBar:

![statusbar](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/29696fe4-8fb5-4baf-8441-735818b13290)



