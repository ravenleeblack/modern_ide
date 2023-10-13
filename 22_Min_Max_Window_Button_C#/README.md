In this lesson we are going to add the click events needed to make the minamize button and the maximize button work. The only issue here is that since we removed the header from the main window the maximize button is kind of trash.

In our xaml we need to add a click event named min_program at the end of our min button tag and a click event named max_program at the end of our max button tag.

```
<Button x:Name="main_header_min"  Content="_"  Grid.Column="19" Width="16" Height="16" Padding="0,-2,0,0" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}" Click="min_program" />
<Button x:Name="main_header_max"  Content="[]" Grid.Column="20" Width="16" Height="16" Padding="0,-2,0,0" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}" Click="max_program" />
```

After we have created the click events, just like with the exit button, it will make a function in the MainWindow.xaml.cs file.

```
        private void min_program(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void max_program(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }
```
