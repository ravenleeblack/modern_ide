This lesson will be fairly short cause its only setting up the grid and explaining the reasoning behind it.

A grid is a tool we use so that we can keep control over our ui elements. We can imagine that our grid is like a table and we have rows and columns to help us keep organized. So for the grid line in xaml we have Grid.ColumnDefinitions and Grid.RowDefinitions that we can use.

In the previous lesson we maximized our main window. For me at least this means that our window is now 1920 x 1080 minus the taskbar. So we can do a little math here to help us set up our grid to become more precise. Im going to start with the width of our main window or the columns because we need to know how many columns we need to get across the screen.

So what I did was 1920 / 100 which give us 1900 pixels and leaves us 20 pixels. This means we would have 19 columns that would be 100 pixels long and 1 column with 20 pixels left. But we have to take into consideration that when we make the main menu that will be creating 3 custom buttons for min, max, and exit. So I had to alter it to become 18 columns at 100 pixels for main menu buttons, 1 column at 60 pixels used as a spacer, and 3 columns at 20 pixels used for our 3 headers buttons. Really doubt we will ever need 18 buttons for the main menu so this gives us plenty of room. At 20 pixels for width and soon 20 pixels in row height that would give a 2 pixel padding all around a 16x16 icon for the min. max, exit button if you chose to use an icon.

![grid_width](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/2bc01221-eaa9-4d81-a4a5-88f1e7977bf2)

I am not really sure how many pixels the taskbar is so it is always trial and error when it comes to dealing the rows or height of the window. For the rows I have choose to do 5 rows with 4 rows at 20 pixels in height and used the asterik * to cover the remaining fifth row. Here it would give us the first row of 20 pixels for the main menu, the second row for a toolbar then 2 rows of 20 pixels as spacer so the window doesnt become too overcrowded and ugly.

![grid_height](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/50730772-8ebd-4efd-ba1a-be834e331cab)



