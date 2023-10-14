In a previous lesson we created a placeholder to push our window into place. Now it seems we have a new issue. Windows provides us with a pre-made dialog window for handling open and save files, but I have not yet seen, a pre-made menu for handling new files. This means that we will have to create a custom new file menu, that can be accessed in 2 different locations of our IDE, since it is custom to have a new file menu in the main menu and another new file menu in the right click menu.

The next issue is we have to decide if we want to code all of this new file window into the current files, which is already getting pretty long in the MainWindow.xaml, or we can create a whole new window for new file window. I think at this point it would be better to create a whole new window and then we can just make some calls from our current code to make it work.



