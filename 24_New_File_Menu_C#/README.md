This lesson will be an easy lesson. All we are doing is connecting the up the new file button under file in the main menu with the new_file_menu we created in lesson 12.

In MainWindow.xaml we need to add a click event to our new file button and name it new_file_menu_click:
```xml
  <Button Grid.Row="4" Width="88" Height="18" Content="New File" Foreground="Teal" Background="#FF141414" BorderBrush="Black" Click="new_file_menu_click" />
```

This will create a new function in MainWindow.xaml.cs:
```c#
      private void new_file_menu_click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the new window
            new_file_menu newWindow = new new_file_menu();

            // Show the new window
            newWindow.Show();
        }
```

We now should be able to open our new file menu.
