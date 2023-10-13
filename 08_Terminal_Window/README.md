In this lesson, we're setting up the terminal window using the TabControl tag. Let's start by naming it:

```xml
<TabControl x:Name="terminal_window">
</TabControl>
```

Now, here are the steps to configure the TabControl:

1. In the layout section, set the tab window's dock to "Bottom" to place it at the bottom, on top of the StatusBar.
2. Change the background color to match the rest of your UI, which is RGB 20, 20, 20.
3. Set the foreground color to white.
4. Set the BorderBrush to RGB 0, 0, 0.
5. In the layout section, change the width to 1320 and the height to 270.
6. Set the bottom margin to 1. This ensures that when you add the Text Editor window later, there's a 1-pixel gap to keep the look uniform.

Here's the revised code:

```xml
<TabControl x:Name="terminal_window" DockPanel.Dock="Bottom" Background="#FF141414" Foreground="White" BorderBrush="Black" Width="1320" Height="270" Margin="0,0,0,1">
</TabControl>
```

If you've done it correctly, it should look like this:

![screen_7](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/419bdf6f-fd54-4ecd-add6-4f603dcc6cf3)

Now, let's add the TabItem:

```xml
<TabControl x:Name="terminal_window" DockPanel.Dock="Bottom" Background="#FF141414" Foreground="White" BorderBrush="Black" Width="1320" Height="270">
      <TabItem x:Name="terminal_tab" Header="Output" Background="#FF141414" BorderBrush="Black" Height="20" Width="80" Foreground="Teal">
           Some sample text
       </TabItem>
</TabControl>
```

With these changes, your window should now look like this:

![screen_8](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/16d5e519-d088-4e26-a457-c7c243caabb1)

