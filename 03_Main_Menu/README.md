**Creating a Custom Main Menu**

In this lesson, we'll craft a custom main menu using label controls and add buttons for File, Edit, Minimize, Maximize, and Exit. Our aim is to focus on the visual design, keeping the mechanics for later lessons, as we want to maintain a clear separation between the UI (XAML) and the mechanics (C#), as explained in the introduction.

**Setting Up the Main Menu Label Control**

Begin by reopening the MainWindow.xaml file and create a label tag to serve as the menu's background:

```xml
<label x:Name="main_menu"/>
```

Naming the label is crucial for future reference. We want to set its properties, considering that our grid structure is already in place.

```xml
<label x:Name="main_menu" Grid.Row="0" Grid.Column="0" Grid.ColumnSpan="22"/>
```

Now, we can modify the appearance of the label. Set the background color, border color, and border thickness:

```xml
<label x:Name="main_menu" Grid.Row="0" Grid.Column="0" Grid.ColumnSpan="19" Background="#FF141414" BorderBrush="Black" BorderThickness="1"/>
```

**Creating Buttons for the Main Menu**

Let's create buttons for File and Edit. Start with the File button:

```xml
<Button x:Name="main_menu_file" Content="File" Grid.Row="0" Grid.Column="0" Width="100" Height="18" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>
```

To ensure the button blends seamlessly with the menu, remove the border by setting BorderBrush to null.

For the Edit button, name it "main_menu_edit" and place it in the next column (column 1):

```xml
<Button x:Name="main_menu_edit" Content="Edit" Grid.Row="0" Grid.Column="1" Width="100" Height="18" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>
```

**Customizing Header Buttons**

For the main header buttons (Minimize, Maximize, and Exit), we can't use icons, so we'll use characters: _, [], and X, respectively. Position them in columns 19, 20, and 21, and add a bit of padding:

```xml
<Button x:Name="main_header_min" Content="_" Grid.Column="19" Width="16" Height="16" Padding="0,-2,0,0" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>
<Button x:Name="main_header_max" Content="[]" Grid.Column="20" Width="16" Height="16" Padding="0,-2,0,0" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>
<Button x:Name="main_header_exit" Content="X" Grid.Column="21" Width="16" Height="16" Padding="0" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>
```

By removing the border, the buttons seamlessly blend with the menu.

**Final Result**

With these modifications, your window should now resemble this:

![Window with Main Menu](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/2b2a16c8-33e7-443c-99ac-dd2b5f22b9b1)

Feel free to refer to the attached MainWindow.xaml code for verification.
