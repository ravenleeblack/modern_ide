We have set up our project. So now when we press the compile or run button we should have a window displaying that looks like this.
![simple_window](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/003f135f-4c64-47b1-8715-96fb86282b15)

Lets go ahead and set up the main window. 

The first thing were going to do is maximize our screen. In our mainwindow.xaml file we are going to add WindowState="Maximized" to the the title line.

    Title="MainWindow" Height="450" Width="800" WindowState="Maximized">

Next we will remove the window's header so that we re-gain some space. In order to do this we will need to add WindowStyle="none" to the the title line.

    Title="MainWindow" Height="450" Width="800" WindowState="Maximized" WindowStyle="none">

Now for the color of the background, I am not sure if adding the background color to the title line, would be the proper way of doing things. The reason being is that the grid line in our code seems to overlay the title. So I suppose its assumed that we will use the grid more often, so adding the background color to the grid, would be more efficient.

If you use your cursor and click on the grid line it will select the grid. We should now have a properties tab window open.

![prop](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/f4938c84-51d0-4940-aa7c-64c4bd594100)

We want to choose solid color which is the second option and pick ourselves a rgb color.

![prop_2](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/ccb62dfa-9963-44bb-a358-c9e80446a021)

I chose rbg 60, 60, 60 for the background this time to kinda lighten everything up.




