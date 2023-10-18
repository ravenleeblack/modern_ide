In a previous lesson we created a placeholder to push our window into place. Now it seems we have a new issue. Windows provides us with a pre-made dialog window for handling open and save files, but I have not yet seen, a pre-made menu for handling new files. This means that we will have to create a custom new file menu, that can be accessed in 2 different locations of our IDE, since it is custom to have a new file menu in the main menu and another new file menu in the right click menu.

The way we are going to appproach this, is we are going to create a whole new window, this will help keep our code clean since MainWindow.xaml is already starting to get long.

Lets create a new xaml window and name it new_file_menu.xaml. Right click on the Illeshian_ide_ folder, add, new item, under Visual C# we need to choose the WPF line, then we need to pick Window (WPF), and then finally we need to name the new window new_file_menu.xaml and click on the add button.

![new_window](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/7636899d-dbb2-46e6-9d1e-da58e7d18072)


This time we are going to keep the windows header so we can close it properly if we need to exit out of the new file menu. We need to rename the title name to New File. We can change the window size to 900 in width and 500 in height.

```xml
Title="New File" Height="450" Width="800">
```

Then we can make sure the window is centered when opened:

```xml
 Title="New File" WindowStartupLocation="CenterScreen"  Height="450" Width="800">
```

We need to set the grid up for the right layout and again we will add the background color to the grid tag. I chose the same background color that we used for the main window rgb 40, 40, 40:

```xml
    <Grid Background="#FF3C3C3C">
    </Grid>
```


next lets set the grid up:
```xml
    <Grid Background="#FF282828">
        
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="10" />
            <ColumnDefinition Width="200" />
            <ColumnDefinition Width="10" />
            <ColumnDefinition Width="400" />
            <ColumnDefinition Width="40" />
            <ColumnDefinition Width="10" />
            <ColumnDefinition Width="100" />
            <ColumnDefinition Width="10" />
            <ColumnDefinition Width="100" />
            <ColumnDefinition Width="10" />
        </Grid.ColumnDefinitions>

        <Grid.RowDefinitions>
            <RowDefinition Height="10" />
            
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />

            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />

            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />
            <RowDefinition Height="20" />

            <RowDefinition Height="10" />
            <RowDefinition Height="20" />

            <RowDefinition Height="10" />
            <RowDefinition Height="10" />

        </Grid.RowDefinitions>
```
Then we make the background labels, suppose we didnt really need them, but yea it stands out. We need add some listbox to our labels. The first label will be our installed languages at some point, the second will be the type of files  and the last label will be a descripton of the file type.

```xml
        <Label x:Name="language_label" Grid.Column="1" Grid.Row="1"  Grid.RowSpan="20" Background="#FF141414" BorderBrush="Black" BorderThickness="1" Padding="5,5,5,0">
            <ListBox x:Name="language_listbox"  Padding="0" Width="190" Height="400" BorderBrush="Black" Background="#FF282828" Foreground="Teal">
                <ListBoxItem> Files: </ListBoxItem>
 
            </ListBox>
        </Label>

        <Label x:Name="file_type_label" Grid.Column="3" Grid.Row="1" Grid.ColumnSpan="2" Grid.RowSpan="20" Background="#FF141414" BorderBrush="Black" BorderThickness="1" Padding="5,5,5,0">
            <ListBox x:Name="file_typ_listbox"  Padding="0" Width="450" Height="400" BorderBrush="Black" Background="#FF282828" Foreground="Teal">
                <ListBoxItem> .c   </ListBoxItem>
                <ListBoxItem> .asm </ListBoxItem>
                <ListBoxItem> .ill </ListBoxItem>
                <ListBoxItem> .txt </ListBoxItem>
            </ListBox>
        </Label>

        <Label x:Name="descrip_label" Grid.Column="6" Grid.Row="1" Grid.ColumnSpan="3" Grid.RowSpan="20" Background="#FF141414" BorderBrush="Black" BorderThickness="1" Padding="5,5,5,0">
            <ListBox x:Name="descrip_listbox"  Padding="5,5,5,0" Width="198" Height="400" BorderBrush="Black" Background="#FF282828">
            </ListBox>
        </Label>
```

We can create a name label:

```xml
        <Label x:Name="name_label" Content="File Name:" Grid.Column="1" Grid.Row="22" Grid.RowSpan="2" Background="#FF141414" Foreground="Teal" BorderThickness="1" BorderBrush="Black"/>
```

A textbox for the future file name:
```xml
   <TextBox x:Name="text_box" Grid.Row="22" Grid.Column="3" Grid.RowSpan="2" Grid.ColumnSpan="2" Background="#FF141414" BorderBrush="Black" Foreground="Teal">
            
        </TextBox>
```

Finally 2 buttons. 1 for the ok button and 1 for the cancel button:
```xml

        <Button x:Name="ok_button" Content="OK" Grid.Column="6" Grid.Row="22" Grid.RowSpan="2" BorderBrush="Black" Background="#FF141414" Foreground="Teal"/>
        <Button x:Name="cancel_button" Content="Cancel" Grid.Column="8" Grid.Row="22" Grid.RowSpan="2" BorderBrush="Black" Background="#FF141414" Foreground="Teal"/>
```

WE now have something that looks like this:

![new_menu](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/c9b0035f-a79d-4cd4-b111-8c0c4b9ba786)



It is not the best looking new file menu yet but I will work on it and update it. I know this lesson kinda felt less descriptive then normal and I will rewrite most of the lessons once I get it all done. Right now I am mainly just trying to get all the info together, out, and correct.







