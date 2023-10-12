So we have a new project setup. If you press the compile or run button you should have a simple window that looks something like this displaying:

![simple_window](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/d52c1456-4a2e-4c0d-af76-3c4066110823)

Its a really basic window, but thats ok, we will work on our visual representation and turn it into something. Before getting into the more difficult controls in later lessons lets go ahead and set this window up to look a little better and provide us with some more room to work with.

The first thing were going to do is maximize our screen. In our mainwindow.xaml file we are going to add WindowState="Maximized" to the the xaml title tag line.

    Title="MainWindow" Height="450" Width="800" WindowState="Maximized">

Next we will remove the window's header, so that we can re-gain some space, so lets add WindowStyle="none" to the title tag line as well.

    Title="MainWindow" Height="450" Width="800" WindowState="Maximized" WindowStyle="none">

We will be making our own custom min, max, and exit buttons later so dont worry. If you compile now it wont be easy to exit, so you will have to click on the vs icon, thats located  on your taskbar. Then shut down the vs compiler that is running so the window will close. This is alot easier to do if you have 2 monitors lmao. The reason why is because we have not written any code to exit the window yet and we just removed the previous way to close it when we removed the windows header.

Now for the color of the background, I am not sure if adding the background color to the title tag line, would be the proper way of doing things. The reason being is that the grid tag line in our code seems to indicate that the grid itself overlays the title. So I suppose since we will be using the grid it would be better to add the background color to the grid. Later other ui elements will overlay the grid and the grid will still provide the nice background color that we chose.

If you use your cursor and click on the grid tag line in the xaml file it will select the grid. We should now have a properties tab window open under the solution explorer that shows the options for our grid. We can double check that we have indeed clicked on the grid tag because in properties under Name will be a Tyoe and it should say Grid. This will change anytime you click on a new tag in xaml and a good way to make sure you are on the right ui element or control so you are not messing your own work up because you werent on the right control or element.

![prop](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/f4938c84-51d0-4940-aa7c-64c4bd594100)

Under brush we want to choose the solid color tab, which is the second option, and pick ourselves a rgb color.

![prop_2](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/ccb62dfa-9963-44bb-a358-c9e80446a021)


Now we should have a main window that looks like this:

![screen_1](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/70a62453-6fdc-4f64-af2a-8912a36ac6f3)

If you want to verify the xaml code:

![grid](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/385874f5-6342-4c52-a68d-627bb350074a)

Just a maximized window with no header and some background color.

For rgb colors a good site to bookmark would be:
https://www.rapidtables.com/web/color/RGB_Color.html

In the next lesson we will set up the grid so that we can put the main menu, toolbar, statusbar, an all the tabbed windows we will need.

