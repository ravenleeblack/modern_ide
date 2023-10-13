In this lesson, we will be adding the toolbar menu. Ideally, we should have included this lesson right after the main menu, but let's dive in now. Similar to what we did with the main menu, we'll create a `Label` to serve as the background:

```xml
<Label x:Name="toolbar_menu" Grid.Row="1" Grid.Column="0" Grid.ColumnSpan="22" Background="#FF141414" BorderBrush="Black" BorderThickness="1,0,1,1" />
```

Since this is a toolbar, we'll use the row below the main menu (Grid.Row 1), and we need to start in Grid.Column 0 and extend to Column.Span 22. The background color is set to RGB 20, 20, 20, with a border color of RGB 0, 0, 0. In the `BorderThickness` property, we set the left, right, and bottom borders to 1, while leaving the top border as 0. This is because the main menu already has four border lines, and adding a top border to the toolbar would result in overlapping lines and a less appealing appearance.

Now, let's add buttons to the toolbar. While adding buttons is familiar, we'll add icons to the "Run" and "Stop" buttons. You've seen the image before, but here it is again:

![compiler_options](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/ca695e70-6ad0-4086-95a6-e9a06cdecfdb)

We have a total of four buttons on the toolbar. Note that you may need to find or create your own free icons, as I cannot verify the legality of using the ones provided. Here's how you can define the buttons:

```xml
<Button x:Name="play_button" Grid.Row="1" Grid.Column="8" Background="#FF141414" BorderBrush="#00707070" BorderThickness="0" Foreground="Teal" Width="100" Height="18" Padding="0,-2,0,0">
    <StackPanel Orientation="Horizontal">
        <Image Width="16" Height="16" Margin="20,0,0,0" Source="C:\projects\skeletion_code\Illeshian\Illeshian\icons\play_3.png" />
        <TextBlock VerticalAlignment="Center" Text="Run" />
    </StackPanel>
</Button>

<Button x:Name="stop_button" Grid.Row="1" Grid.Column="9" Background="#FF141414" BorderBrush="#00707070" BorderThickness="0" Foreground="Teal" Width="100" Height="18" Padding="0,-2,0,0">
    <StackPanel Orientation="Horizontal">
        <Image Width="16" Height="16" Margin="20,0,0,0" Source="C:\projects\skeletion_code\Illeshian\Illeshian\icons\stop.png" />
        <TextBlock VerticalAlignment="Center" Text="Stop" />
    </StackPanel>
</Button>

<Button x:Name="program_button" Content="Program" Grid.Row="1" Grid.Column="10" Background="#FF141414" Foreground="Teal" BorderBrush="#00707070" BorderThickness="0" Width="100" Height="18" Padding="0,-2,0,0"/>
<Button x:Name="path_button" Content="Project Path" Grid.Row="1" Grid.Column="11" Background="#FF141414" Foreground="Teal" BorderBrush="#00707070" BorderThickness="0" Width="100" Height="18" Padding="0,-2,0,0"/>
```

To summarize, we now have a sleek toolbar, with buttons. Here's how the toolbar looks:

![screen_11](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/5176ec68-2eb9-4ba4-b0e1-a975e5375fdc)
