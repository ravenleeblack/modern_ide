
In this lesson we are going to make the UI element for the Output window. Basically the same thing we did last lesson with a few changes. In order to do this we will use the TabControl tag again. Lets name it like we usally do.

```
<TabControl x:Name="output_window">
</TabControl>
```

Since we are starting to get familiar with the properties tab we need to go to layout, dock and set the tab windows dock to be left this time, next we change the background color to rgb 20, 20, 20 so that it matches with the rest of our ui. We can set our foreground color to white rgb 250, 250, 250 for later use. We can set BorderBrush to be rgb 0, 0, 0 so that we have a nice dark border. Under layout we need to set the width to 300 and the height to 974.

```
<TabControl x:Name="output_window" DockPanel.Dock="Left"  Background="#FF141414" Foreground="White" BorderBrush="Black" Width="290" Height="974">
</TabControl>
```

If you have done everything properly your window should look like this:

![screen_5](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/2631e900-facb-4041-a41f-90d6ba42fc27)

Lets go ahead and add the add TabItem code:

```
<TabControl x:Name="output_window" DockPanel.Dock="Right"  Background="#FF141414" Foreground="White" BorderBrush="Black" Width="290" Height="974">
     <TabItem x:Name="output_tab" Header="Output" Background="#FF141414" BorderBrush="Black" Height="20" Width="80" Foreground="Teal">
          Some sample text
     </TabItem>
</TabControl>
```

![screen_6](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/28170aca-6585-4424-9e56-9da1c85b218f)


I just did the last lesson so I havent figured out the TabItem works just yet so until I do figure it out I am going to just keep trucking forward. Ill come back eventually and update them.

