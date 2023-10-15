STILL IN PROGRESS. MOST LESSONS ARE:

In a previous lesson we created a placeholder to push our window into place. Now it seems we have a new issue. Windows provides us with a pre-made dialog window for handling open and save files, but I have not yet seen, a pre-made menu for handling new files. This means that we will have to create a custom new file menu, that can be accessed in 2 different locations of our IDE, since it is custom to have a new file menu in the main menu and another new file menu in the right click menu.

The way we are going to appproach this, is we are going to create a whole new window, this will help clean our code up some that is already starting to get pretty long in MainWindow.xaml.

Lets create a new xaml window and name it new_file_menu.xaml. Right click on the Illeshian_ide_ folder, add, new item, under Visual C# we need to choose the WPF line, then we need to pick Window (WPF), and the nfinally we need to name the new window new_file_menu.xaml and click on the add button.

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

STILL WORKING ON THIS LESSON. THE BACK GROUND FOR XAML IS HERE DOE.

Since we do not have the code behind or mechanics connected here yet is an image of what it should look like:

![new_menu](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/c9b0035f-a79d-4cd4-b111-8c0c4b9ba786)

It is not the best looking new file menu yet but I will work on it and update.







