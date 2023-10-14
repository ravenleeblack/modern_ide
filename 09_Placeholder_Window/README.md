In this lesson I am not even going to lie!! I have no clue what the proper way to handle tabbed window files is. 

The first issue we have is that we def need a placeholder tabbed window to push our Terminal window down. Which we can handle now. Same as before we need to name our TabControl, set the Dock to top this time, set the background color to rgb 20, 20, 20, add a BorderBrush rgb 0, 0, 0. Go to layout and change the width to 1320 and the height to 700. Now I have added the visibility line but you can remove it if you want to see the window but remember its suppose to be a placeholder.

```
<TabControl x:Name="file_window" DockPanel.Dock="Top" Background="#FF141414" BorderBrush="Black" Width="1320" Height="700" Visibility="Hidden">
</TabControl>
```

The main window with the editor window visisble:

![screen_9](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/f08fc475-7259-49cc-b9b7-1ff350e0d544)


The main window with the editor window hidden:

![screen_10](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/ded43f30-3deb-4127-978d-e9a1386f2e23)

Now the next is a little bit different and the part I am unsure of. When we create a new file. It will create a new tabbed window and add it alongside this one I think. I dont know ill work on it and hopefully fix it soon.
