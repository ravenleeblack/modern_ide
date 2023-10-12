The Grid control is the most commonly used layout panel for creating user interface in xaml. The Grid is a tool, that we can use, to keep control over the ui elements. With the Grid control, you can define the width (Columns) and the height (Rows) of the grid layout which will create what I call cells. You can then assign child controls, to the cells of that grid, in order to create a more structured layout. 

In the xaml code, we have a Grid tag and inbetween the Grid's starting and ending tag, we have to create some properties that we can use, so Columns and Rows are defined by creating ColumnDefinition and RowDefinition properties. As you will see soon in the images below the properties for columns is width and the properties of rows is height.

In the previous lesson we maximized our main window. For me at least this means that our window is now 1920 x 1080 minus the taskbar. I want to make the main menu as long or wide as the window so the full 1920 in pixels and then I want the height of the main menu to be 20 pixels in height. So we can do a little math here to help us set up our grid to become more precise. Im going to start with the width of our main window to calculate the columns needed. So what I did was to start with 1920 / 100 which give us 1900 pixels and leaves us 20 pixels. This means we would have 19 columns that would be 100 pixels long and 1 column with 20 pixels left. But we have to take into consideration that when we make the main menu that will be creating 3 custom buttons for min, max, and exit. So I had to alter it to become 18 columns at 100 pixels for main menu buttons, 1 column at 60 pixels used as a spacer, and 3 columns at 20 pixels in width used for our 3 headers buttons. Really doubt we will ever need 18 buttons for the main menu so this gives us plenty of room. 

![grid_width](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/2bc01221-eaa9-4d81-a4a5-88f1e7977bf2)

For the rows I did 4 fixed rows of 20 pixels in height. 1 row for the main menu, 1 row for the toolbar and 2 rows used as a spacer to make sure the ui interface doesnt become too overcrowded. I then used the asterik * to make the remaining 5th row a variable sized row which means it can be adjusted as needed. 

![grid_height](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/50730772-8ebd-4efd-ba1a-be834e331cab)

So now we have 5 rows of 22 columns that we are able to use to layout th ui for our ide program.





