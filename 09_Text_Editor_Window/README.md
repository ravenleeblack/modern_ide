In this lesson I am not even going to lie!! I have no clue what the proper way to handle tabbed window files. 

The first issue we have is that we def need a placeholder tabbed window to push our Terminal window down. Which we can handle now.

```
<TabControl x:Name="file_window" DockPanel.Dock="Top" Background="#FF141414" BorderBrush="Black" Width="1320" Height="700" Visibility="Hidden">
</TabControl>
```

The next issue is when we open a file we need we need to be able to call a control's name but if we havent made a name yet then were kina 
