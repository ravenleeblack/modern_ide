In this lesson We are going to set up the terminal window. I havent figured out what I am going to use it for yet but I figure I will add it in until I do figure it out. So we are going to use the TabControl again and name it.

```
<TabControl x:Name="terminal_window">
</TabControl>
```

We will want to set the dcok in layout to bottom this time. If we set it to bottom it will go into the middle or on top of our StatusBar which is want we want because the actual text editor will be on top of this window in the future. We want to change the Background to rgb 20, 20, 20 to match the rest of the ui, We can make the foreground a white for now. We need to set a BorderBrush with rgb 0, 0, 0, and then in layout we need to change the width to 1320 nad the height to 270.

```
<TabControl x:Name="terminal_window" DockPanel.Dock="Bottom"  Background="#FF141414" Foreground="White" BorderBrush="Black" Width="1320" Height="270">
</TabControl>
```

If you have done it right then it should look like this:

![screen_7](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/419bdf6f-fd54-4ecd-add6-4f603dcc6cf3)

When the Text Editor window gets put in the Terminal Window will move into place at the bottom. Now lets put in the TabItem.

```
<TabControl x:Name="terminal_window" DockPanel.Dock="Bottom"  Background="#FF141414" Foreground="White" BorderBrush="Black" Width="1320" Height="270">
      <TabItem x:Name="terminal_tab" Header="Output" Background="#FF141414" BorderBrush="Black" Height="20" Width="80" Foreground="Teal">
           Some sample text
       </TabItem>
</TabControl>
```

![screen_8](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/16d5e519-d088-4e26-a457-c7c243caabb1)



I am still working on it.
