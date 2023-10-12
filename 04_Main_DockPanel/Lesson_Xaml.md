
In this lesson we are going to set up the DockPanel that will hold our windows and status bar. The DockPanel control is a container that will allow us to dock the windows we want into the dock panel.

Since we have 5 rows available to us from the previous lessons, we are going to choose the 4th row that is a non-fixed row, remember when it come to the Grid system its the rows and columns start from 0 so the 5th row would be the 4th row counting from 0. Then we want to span the DockPanel across all 22 columns. The DockPanel control exposes a property called LastChildFill which can be set to true or false. When set to true the last control added to the dock panel layout will fill in the remaining space.

```
<DockPanel Grid.Row="4" Grid.Column="0" Grid.ColumnSpan="22" LastChildFill="True">
</DockPanel>
```

In the example above, we have an opening DockPanel tag and a closing DockPanel. DockPanel like the Grid allows for us to put the other controls inbetween the opening and ending tags so its good to set it up that way beforehand. There really is not much more we nned to do here in this tuterial so we will move onto the next lesson.



