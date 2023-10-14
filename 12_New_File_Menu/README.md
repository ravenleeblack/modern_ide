STILL IN PROGRESS. MOST LESSONS ARE:

In a previous lesson we created a placeholder to push our window into place. Now it seems we have a new issue. Windows provides us with a pre-made dialog window for handling open and save files, but I have not yet seen, a pre-made menu for handling new files. This means that we will have to create a custom new file menu, that can be accessed in 2 different locations of our IDE, since it is custom to have a new file menu in the main menu and another new file menu in the right click menu.

The way we are going to appproach this, is we are going to create a whole new window, this will help clean our code up some that is already starting to get pretty long in MainWindow.xaml.

1) Lets create a new xaml window and name it new_file_menu.xaml.

![window_menu](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/5587ae2e-0e8d-4647-aebd-5f4a8b605bff)


I think this time around we will leave the header and window size. In the title tag we need to rename it to New File.

```xml
Title="New File" Height="450" Width="800">
```

Then we can make sure the window is centered when opened:

```xml
 Title="New File" WindowStartupLocation="CenterScreen"  Height="450" Width="800">
```

Next we will use the grid to place our ui controls in the right place for layout so we can start with the background color. 

```xml
    <Grid Background="#FF3C3C3C">
    </Grid>
```
I chose the same background color that we used for the main window rgb 40, 40, 40:

Lets set up the Grid.ColumnDefinitions. This will give us 1 column of 150 to use for the name of the language installed, 1 column of 400 to create a ListBox for the avaiable list of file that language provides, 3 coulumns the 100, 20, 100 we will have to span these in order to create the file types decription but these 3 columns also allow us to set up our ok and cancel button up nicely at the bottom:

```xml
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="150" />
            <ColumnDefinition Width="400" />
            <ColumnDefinition Width="10" />
            <ColumnDefinition Width="100" />
            <ColumnDefinition Width="10" />
            <ColumnDefinition Width="100" />
            <ColumnDefinition Width="10" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
```

For the rows we will need to make many to allow a list of files so we have 18 at 20 for file types and 1 row at a height of 30 for the buttons then we just use a variable row for the last row:
```xml
       <Grid.RowDefinitions>
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

            <RowDefinition Height="30" />
            
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
```

We can create a Label for the middle:

```xml
       <Label x:Name="new_file_label" Grid.Column="1" Grid.Row="1" Grid.RowSpan="17" Background="#FF141414">
        </Label>
```






