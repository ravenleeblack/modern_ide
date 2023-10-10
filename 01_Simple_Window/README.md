We have set up our project. So now when we press the compile or run button we should have a window displaying that looks like this.
![simple_window](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/003f135f-4c64-47b1-8715-96fb86282b15)

Lets go ahead and set up the main window. 

The first thing were going to do is maximize our screen. In our mainwindow.xaml file we are going to add WindowState="Maximized" to the the title line.

    Title="MainWindow" Height="450" Width="800" WindowState="Maximized">

Next we will remove the window's header, so that we re-gain some space, so we need to add WindowStyle="none" to the title line.

    Title="MainWindow" Height="450" Width="800" WindowState="Maximized" WindowStyle="none">

We will be making our own custom min, max, and exit buttons so dont worry. If you compile now it wont be easy to exit so you will need to click on the vs icon in your taskbar and shut down the window by stopping the compiler. This is far more easy if you have 2 monitors lmao.

Now for the color of the background, I am not sure if adding the background color to the title line, would be the proper way of doing things. The reason being is that the grid line in our code seems to indicate that the grid itself overlays the title. So I suppose its assumed that we will use the grid more often, so adding the background color to the grid, seems would be more efficient unless your great at styles.

If you use your cursor and click on the grid line it will select the grid. We should now have a properties tab window open under the solution explorer.

![prop](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/f4938c84-51d0-4940-aa7c-64c4bd594100)

Under brush we want to choose the solid color tab, which is the second option, and pick ourselves a rgb color.

![prop_2](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/ccb62dfa-9963-44bb-a358-c9e80446a021)

I chose rbg 60, 60, 60 for the background this time to kinda lighten everything up. For rgb colors a good site to bookmark for colors would be:
https://www.rapidtables.com/web/color/RGB_Color.html




