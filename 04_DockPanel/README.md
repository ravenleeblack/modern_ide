**Setting Up the DockPanel**

In this lesson, we will configure the DockPanel, which will serve as a container for our windows and the status bar. The DockPanel control allows us to easily dock the desired windows within it.

As we have 5 rows available from our previous lessons, we will select the 4th row (remember, in the Grid system, rows and columns start from 0, so the 5th row is the 4th row in this context). Additionally, we want the DockPanel to span across all 22 columns. The DockPanel control exposes a property called `LastChildFill`, which can be set to true or false. When set to true, the last control added to the DockPanel layout will occupy the remaining space.

```xml
<DockPanel Grid.Row="4" Grid.Column="0" Grid.ColumnSpan="22" LastChildFill="True">
</DockPanel>
```

The example provided above includes both the opening and closing tags for the DockPanel. Similar to the Grid, we can place other controls between these tags. There is no further configuration needed in this tutorial, so let's proceed to the next lesson.
