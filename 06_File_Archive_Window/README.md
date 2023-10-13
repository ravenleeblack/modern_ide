In this lesson, we'll be creating the UI element for the File Archive window using the TabControl tag. Let's start by giving it a name:

```xml
<TabControl x:Name="archive_window">
</TabControl>
```

Since you're becoming familiar with the properties tab, we'll configure the TabControl as follows:

1. Go to the layout section and set the tab window's dock to "Right."
2. Change the background color to match the rest of the UI, which is RGB 20, 20, 20.
3. Set the foreground color to white (RGB 250, 250, 250) for later use.
4. Set the BorderBrush to RGB 0, 0, 0 for a nice dark border.
5. In the layout section, set the width to 290 and the height to 974.

Here's the revised code:

```xml
<TabControl x:Name="archive_window" DockPanel.Dock="Right" Background="#FF141414" Foreground="White" BorderBrush="Black" Width="290" Height="974">
</TabControl>
```

If you've followed these instructions correctly, your window should look like this:

![screen_3](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/5681d8e5-d086-4fd0-a989-929a4d0e01d5)

The new window will stay in the middle of the screen until we add another window. Once you add another window, the File Archive window will move into its proper place. There should be a 1-pixel gap between the File Archive window and the StatusBar based on the width and height provided.

Now, let's add the actual tab using the TabItem:

```xml
<TabControl x:Name="archive_window" DockPanel.Dock="Right" Background="#FF141414" Foreground="White" BorderBrush="Black" Width="290" Height="974">
     <TabItem x:Name="archive_tab" Header="File Archive" Background="#FF141414" BorderBrush="Black" Height="20" Width="80" Foreground="Teal">
          Some sample text
     </TabItem>
</TabControl>
```

While this gives you a tab at the top, it appears white. I'll need to explore how to change the TabItem's actual color, but for now, you have the basic structure in place.

Here's how it should look for now:

![screen_4](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/7ccebc7a-1489-4f99-aa49-6c1a0e1a7068)

