In this lesson we are going to connect up our main menu's file button to the file label we created in lesson 11. Since we name everything else program we are going to just name our click event file_program. 

```xml
 <Button x:Name="main_menu_file" Content="File" Grid.Row="0" Grid.Column="0" Width="100" Height="18" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}" Click="file_program" />
```

This will create a new function named file_program in the MainWindow.xaml.cs file.

```xml
        private void file_program(object sender, RoutedEventArgs e)
        {
            try
            {
                topMenuInstance.top_menu_file_button(sender, e);
            }
            catch (NullReferenceException ex)
            {
                // Log the exception or display a message
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
        }
```



