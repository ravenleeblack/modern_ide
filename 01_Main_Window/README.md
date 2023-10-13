**Enhancing the Initial Window Setup**

After successfully creating your project, when you press the compile or run button, you'll be greeted with a simple window that looks like this:

![Simple Window](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/d52c1456-4a2e-4c0d-af76-3c4066110823)

The window is quite basic, that's perfectly fine, because we're going to refine its visual appeal and functionality step by step. Before delving into more complex controls in later lessons, let's start by giving ourselfs some more room to work with.

**Maximize the Screen**

To give us more space to work with, the first step is to maximize the window. In your MainWindow.xaml file, add `WindowState="Maximized"` to the XAML title tag line:

```xml
Title="MainWindow" Height="450" Width="800" WindowState="Maximized">
```

**Remove the Window's Header**

Next, we'll remove the window's header to regain some screen real estate. Add `WindowStyle="None"` to the title tag line as well:

```xml
Title="MainWindow" Height="450" Width="800" WindowState="Maximized" WindowStyle="None">
```

You might wonder how to exit the window since the previous method is no longer available. For now, clicking the Visual Studio icon in your taskbar and shutting down the running VS instance will close the window. Don't worry; we'll implement our own custom min, max, and exit buttons in future lessons.

**Set the Background Color**

Choosing the background color for the window requires a different approach. Adding it to the title tag line may not be the most appropriate method because the grid tag line in our code suggests that the grid overlays the title. We'll use the grid to set the background color, which will remain consistent even as we add more UI elements that overlay the grid.

To select the grid, click on its tag line in the XAML file. You'll notice a Properties tab window open under the Solution Explorer, displaying the grid's options.

To confirm that you've selected the grid, check the Properties tab, where the Name property should be "Grid." This helps ensure you're working on the right UI element or control and avoid unintended changes.

Under the Brushes property, choose the "Solid Color" option (the second one) and select an RGB color.

With these changes, your main window should now appear like this:

![Maximized Window with Background Color](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/70a62453-6fdc-4f64-af2a-8912a36ac6f3)

For RGB colors, you can bookmark this useful site: [RGB Color Chart](https://www.rapidtables.com/web/color/RGB_Color.html)

In our next lesson, we'll set up the grid, enabling us to incorporate the main menu, toolbar, status bar, and all the tabbed windows we'll need for our project.
