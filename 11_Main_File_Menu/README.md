In this lesson we are going to make a menu for the main menu;s file buttton.

1. **Create a Label for the Submenu Background:**
   
   First, we want to create a label to serve as the background for our submenu. This label will be named "file_label."

   ```xml
   <Label x:Name="file_label">
   </Label>
   ```

2. **Position the Label in the Grid:**

   We want the label to appear right beneath the file button, so we need to place it in the same grid. In this grid, we set it to be in "Row 1" (where the file button is) and make it as tall as necessary (spanning 4 rows).

   ```xml
   <Label x:Name="file_label" Grid.Row="1" Grid.RowSpan="4" Grid.Column="0">
   ```

3. **Styling the Label:**

   To make it look good, we'll style the label. We'll set the background color to match the grid color (RGB 40, 40, 40). We'll add a border with thickness around the left, right, and bottom, but not the top, to make it look like it's connected at the top. The label's width will be 100, the height 220, and it will be aligned to the top. Initially, we'll hide it by setting its visibility to "Collapsed."

   ```xml
   <Label x:Name="file_label" Grid.Row="1" Grid.RowSpan="4" Grid.Column="0" Background="#FF282828" BorderBrush="Black" BorderThickness="1,0,1,1" Width="100" Height="220" VerticalAlignment="Top" Visibility="Collapsed">
   ```

4. **Create a Grid Inside the Label:**

   Inside this label, we'll create a grid to organize our submenu buttons.

   ```xml
   <Grid>
   ```

5. **Defining Row Heights:**

   We specify the heights of the rows in the grid. Each row is used to position a button in the submenu. For example, each "RowDefinition" corresponds to a specific button.

   ```xml
   <Grid.RowDefinitions>
        <RowDefinition Height="20" />
        <RowDefinition Height="20" />
        <RowDefinition Height="20" />
        <RowDefinition Height="10" />
        <RowDefinition Height="20" />
        <RowDefinition Height="20" />
        <RowDefinition Height="10" />
        <RowDefinition Height="20" />
        <RowDefinition Height="20" />
        <RowDefinition Height="10" />
        <RowDefinition Height="20" />
        <RowDefinition Height="20" />
   </Grid.RowDefinitions>
   ```

6. **Adding Buttons:**

   Inside the grid, we add buttons for different submenu items. Each button is placed in a specific row to align them vertically.

   ```xml
   <Button Grid.Row="0" Width="88" Height="18" Content="Main Project" Foreground="Teal" />
   <Button Grid.Row="1" Width="88" Height="18" Content="New Project" Foreground="Teal" />
   <Button Grid.Row="2" Width="88" Height="18" Content="Load Project" Foreground="Teal" />
   <Button Grid.Row="3" Width="88" Height="18" Content="`````````````````````````````" Foreground="#FF505050" />
   <Button Grid.Row="4" Width="88" Height="18" Content="New File" Foreground="Teal" />
   <Button Grid.Row="5" Width="88" Height="18" Content="Load File" Foreground="Teal" />
   <Button Grid.Row="6" Width="88" Height="18" Content="`````````````````````````````" Foreground="#FF505050" />
   <Button Grid.Row="7" Width="88" Height="18" Content="Save File" Foreground="Teal" />
   <Button Grid.Row="8" Width="88" Height="18" Content="Save As" Foreground="Teal" />
   <Button Grid.Row="9" Width="88" Height="18" Content="`````````````````````````````" Foreground="#FF505050" />
   <Button Grid.Row="10" Width="88" Height="18" Content="Preference" Foreground="Teal" />
   <Button Grid.Row="11" Width="88" Height="18" Content="Exit" Foreground="Teal" />

   ```

7. **Closing Tags:*

   ```xml
               </Grid>
        </Label>
   ```
