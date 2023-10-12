In this lesson we are going to make the UI element for the File Archive window. In order to do this we will use the TabControl tag. Lets name it like we usally do.

```
<TabControl x:Name="archive_window">
</TabControl>
```

Seen we are starting to get familiar with the properties tab we need to go to layout, dock and set the tab windows dock to be right, next we change the background color to rgb 20, 20, 20 so that it matches with the rest of our ui. We can set our foreground color to white rgb 250, 250, 250 for later use. We can set or BorderBrush to be rgb 0, 0, 0 so that we have a nice dark border. Under layout we need to set the width to 290 and the height to 974.

```
<TabControl x:Name="archive_window" DockPanel.Dock="Right"  Background="#FF141414" Foreground="White" BorderBrush="Black" Width="290" Height="974">
</TabControl>
```

If you have done everything properly your window should look like this:

![screen_3](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/5681d8e5-d086-4fd0-a989-929a4d0e01d5)


Again this new window is going to stay in the middle of the screen until we add another window. Once we add another window the File Archive window will move into place. As you can see from the image the StatusBar from our last lesson has moved down into the proper place as it should. I know you cant tell by the image above but there should be a 1 pixel gap between the  File Archive and the StatusBar based off the width and height I have provided.

Its a plain looking window isnt it? Well, lets add onto it some more. This time we are going to add the actual tab by using TabItem.

```
<TabControl x:Name="archive_window" DockPanel.Dock="Right"  Background="#FF141414" Foreground="White" BorderBrush="Black" Width="290" Height="974">
     <TabItem x:Name="archive_tab" Header="File Archive" Background="#FF141414" BorderBrush="Black" Height="20" Width="80" Foreground="Teal">
          Some sample text
     </TabItem>
</TabControl>
```

Well this gives a tab on top but its staying white. I will have to look more into it to figure how to change the TabItems actual color but for now least we have one.

![screen_4](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/7ccebc7a-1489-4f99-aa49-6c1a0e1a7068)


Until I figure it out I am going to just keep trucking forward. 

