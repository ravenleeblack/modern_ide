In this lesson I finally added the much needed click event in our xaml for the exit button. I named the click event exit_program because it makes sense.

```
<Button x:Name="main_header_exit" Content="X"  Grid.Column="21" Width="16" Height="16" Padding="0" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}" Click="exit_program" />
```

Once the click event has been added, it will make an exit_program function, in the file MainWindow.xaml.cs.

```
     private void exit_program(object sender, RoutedEventArgs e)
     {
          Application.Current.Shutdown();
     }
```

Then we add the ```Application.Current.Shutdown();``` to the new function to make the exit button properly. Now if you compile the program you can exit our main window by using the main menus exit button.
