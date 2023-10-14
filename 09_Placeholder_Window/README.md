In this lesson I am not even going to lie!! I have no idea how to properly set up tabbed windows for file handling but I am trying to learn.  

The issue we have here in this lesson is the Termanal window we created is still in the middle of the screen so we need to push it into place, but this is normally where we would want our Text Editor window to fall into place, the issue is the Text Editor window doesnt come into existence until we create or open a file so until then, we need something to be a placeholder in the area to keep our window formation until we actually do create or open a file.

So to create a placeholder we will use TabControl and name our tab control hold_window. We need to set the DockPanel.Dock to top. Then we can set our background color rgb 20, 20, 20. We can add a BorderBrsuh even doe it will be hidden. We need to set the width to 1320 and the height 700. Finally we set the visibility to hidden so it will hide our window.

```xml
<TabControl x:Name="hold_window" DockPanel.Dock="Top" Background="#FF141414" BorderBrush="Black" Width="1320" Height="700" Visibility="Hidden">
</TabControl>
```

The window with the placeholder window visisble:

![screen_9](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/f08fc475-7259-49cc-b9b7-1ff350e0d544)


The window with the placeholder window hidden:

![screen_10](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/ded43f30-3deb-4127-978d-e9a1386f2e23)

This forces all the windows in the DockPanel to be in the correct position. In another lesson we can learn how to actually setting up creating and opening windows.

