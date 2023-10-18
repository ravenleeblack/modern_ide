In this lesson we are going to use a label as a menu for the file button on our main menu. Like I said I couldnt figure out how to remove the icon and white from the normal main menu so this hohw we have to do it.

So we need to create a label and name it:
```xml
<Lbael x:Name="file_label">
</Label>
```

Next we need to set the where we want it in the grid system. If also need to make sure its at the top and it spans right:
```xml
 <Label x:Name="file_label" Grid.Row="1" Grid.RowSpan="4" Grid.Column="0"  Background="#FF1E1E1E" BorderBrush="Black" BorderThickness="1,0,1,1" Width="100" Height="220" VerticalAlignment="Top" Visibility="Collapsed">
</Label>
```

Since this is going to be a file menu we need to add in a new grid that is a child of the label. This will allow us to place our buttons nicely:
```xml
        <Label x:Name="file_label" Grid.Row="1" Grid.RowSpan="4" Grid.Column="0"  Background="#FF1E1E1E" BorderBrush="Black" BorderThickness="1,0,1,1" Width="100" Height="220" VerticalAlignment="Top" Visibility="Collapsed">
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="10" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="10" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="10" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />

                </Grid.RowDefinitions>
</Label>
```

Then finally we need to add all the button we will want to use:

```xml
        <Label x:Name="file_label" Grid.Row="1" Grid.RowSpan="4" Grid.Column="0"  Background="#FF1E1E1E" BorderBrush="Black" BorderThickness="1,0,1,1" Width="100" Height="220" VerticalAlignment="Top" Visibility="Collapsed">
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="10" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="10" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="10" />
                    <RowDefinition Height="20" />
                    <RowDefinition Height="20" />

                </Grid.RowDefinitions>

                <Button Grid.Row="0" Width="88" Height="18" Content="Main Project" Foreground="Teal" Background="#FF141414" BorderBrush="Black" />
                <Button Grid.Row="1" Width="88" Height="18" Content="New Project" Foreground="Teal" Background="#FF141414" BorderBrush="Black" />
                <Button Grid.Row="2" Width="88" Height="18" Content="Load Project" Foreground="Teal" Background="#FF141414" BorderBrush="Black" />
                <Button Grid.Row="3" Width="88" Height="18" Content="`````````````````````````````" Foreground="#FF505050" Background="#FF1E1E1E" BorderBrush="{x:Null}" />
                <Button Grid.Row="4" Width="88" Height="18" Content="New File" Foreground="Teal" Background="#FF141414" BorderBrush="Black" Click="new_file_menu_click" />
                <Button Grid.Row="5" Width="88" Height="18" Content="Load File" Foreground="Teal" Background="#FF141414" BorderBrush="Black" />
                <Button Grid.Row="6" Width="88" Height="18" Content="`````````````````````````````" Foreground="#FF505050" Background="#FF1E1E1E" BorderBrush="{x:Null}" />
                <Button Grid.Row="7" Width="88" Height="18" Content="Save File" Foreground="Teal" Background="#FF141414" BorderBrush="Black" />
                <Button Grid.Row="8" Width="88" Height="18" Content="Save As" Foreground="Teal" Background="#FF141414" BorderBrush="Black" />
                <Button Grid.Row="9" Width="88" Height="18" Content="`````````````````````````````" Foreground="#FF505050" Background="#FF1E1E1E" BorderBrush="{x:Null}" />
                <Button Grid.Row="10" Width="88" Height="18" Content="Preference" Foreground="Teal" Background="#FF141414" BorderBrush="Black" />
                <Button Grid.Row="11" Width="88" Height="18" Content="Exit" Foreground="Teal" Background="#FF141414" BorderBrush="Black" />

            </Grid>
        </Label>
```


It should look like this:

![file_menu](https://github.com/ravenleeblack/modern_ide/assets/76606152/9bdbdad9-9f65-47a9-a1d0-3ed1daa3933f)


Right now it wont close because we need to do some mouse event handling but we have a menu with options for us to start working out how to add in tabbed file handling.




