In this lesson, we're creating the UI element for the Output window using the TabControl tag. Let's start by naming it:

```xml
<TabControl x:Name="output_window">
</TabControl>
```

You're getting familiar with the properties tab, so we can configure the TabControl as follows:

1. Go to the layout section and set the tab window's dock to "Left" this time.
2. Change the background color to match the rest of your UI, which is RGB 20, 20, 20.
3. Set the foreground color to white (RGB 250, 250, 250) for later use.
4. Set BorderBrush to RGB 0, 0, 0 for a nice dark border.
5. In the layout section, set the width to 300 and the height to 974.

Here's the revised code:

```xml
<TabControl x:Name="output_window" DockPanel.Dock="Left" Background="#FF141414" Foreground="White" BorderBrush="Black" Width="300" Height="974">
</TabControl>
```

If you've done everything correctly, your window should look like this:

![screen_5](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/2631e900-facb-4041-a41f-90d6ba42fc27)

Now let's add the TabItem code:

```xml
<TabControl x:Name="output_window" DockPanel.Dock="Right" Background="#FF141414" Foreground="White" BorderBrush="Black" Width="290" Height="974">
     <TabItem x:Name="output_tab" Header="Output" Background="#FF141414" BorderBrush="Black" Height="20" Width="80" Foreground="Teal">
          Some sample text
     </TabItem>
</TabControl>
```

With these changes, your window should now look like this:

![screen_6](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/28170aca-6585-4424-9e56-9da1c85b218f)

