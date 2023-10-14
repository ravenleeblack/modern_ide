In a previous lesson we created a placeholder to push our window into place. Now it seems we have a new issue. Windows provides us with a pre-made dialog window for handling open and save files, but I have not yet seen, a pre-made menu for handling new files. This means that we will have to create a custom new file menu, that can be accessed in 2 different locations of our IDE, since it is custom to have a new file menu in the main menu and another new file menu in the right click menu.

The way we are going to appproach this, is we are going to create a whole new window, this will help clean our code up some that is already starting to get pretty long in MainWindow.xaml.

1) Lets create a new window and name it new_file_menu.xaml.



