In this lesson we will be setting up our main windows grid so that we have a table or system that we can keep control of our ui elements. We can imagine that our grid is like a table and we have rows and columns to help us keep organized. So for the grid line we have Grid.ColumnDefinitions and Grid.RowDefinitions that we can use.

So we know at this moment that we have maximized our main window, so this means we have a 1920 x 1080 window, minus the taskbar from the 1080. We need to do a little math here and we will start with the columns or width of the window. So what I did was 1920 / 100 which give us 1900 and leaves 20. This gives us 19 columns that would be 100 pixels long and 1 column with 20 pixels left. But we have to take into consideration that when we make the main menu that will be creating 3 custom buttons for min, max, and exit. So I had to alter it to become 18 columns at 100 pixels for main menu buttons, 1 column at 60 pixels used as a spacer, and 3 columns at 20 pixels used for our 3 headers buttons. Really doubt we will ever need 18 buttons for the main menu so this gives us plenty of room.

![grid_width](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/2bc01221-eaa9-4d81-a4a5-88f1e7977bf2)

I am not really sure how many pixels the taskbar is so it is always trial and error when it comes to dealing the rows or height of the window. For the rows I have choose to do 5 rows with 4 rows 20 pixels high and used the asterik * to cover the remaining fifth row. Here it would give us the first row of 20 pixels for the main menu, the second row for a toolbar 2 rows of 20 pixels as spacer so the window doesnt become too overcrowded and ugly.

![grid_height](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/50730772-8ebd-4efd-ba1a-be834e331cab)


