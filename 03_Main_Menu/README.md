In this lesson we will be a making a custom main menu, we will add the file and edit buttons and the min, max, and exit button but we will not be hooking up the button events until another lesson since that deals with c#.

The first thing we are going to do is open up our MainWindow.xaml file again. This time we are going to create a couple labels that we will use as menu backgrounds. 
>     <label/>

We are going to name our label so if we need to refer to it anywhere later in our code then we can.
>     <label x:Name="main_menu"/>

Now we need to set what row and column we want to use. Rows and columns in xaml start from zero like an array so we want to start in the zero row so we set Grid.Row to zero and we want to start in the zero column so we set the Grid.Column to zero but we want the main menu to be longer then one column so we need to use ColumnSpan to span across 19 of the columns. This will cover our 18 usable button columns and our 1 spacer column. This will keep our actual main menu and its buttons seperate from our custom made menu for the header buttons we are about to create.

Next we need to click on the xaml line label so that we can use the properties tabbed window to change our background color again. I set mine to rgb 20, 20, 20. We also need to set the BorderBrush to rgb 0, 0, 0 that away it is noticable against our already near black background. In the properties window, under appearance, there is a down arrow that needs to be clicked to open up the options for border thickness. We will put left to 1, right to 1, bottom to 1 and top to 1. Once all of these have been set your xaml code should look like mine below:
>     <label x:Name="main_menu" Grid.Row="0" Grid.Column="0" Grid.ColumnSpan="19" Background="#FF141414" BorderBrush="Black" BorderThickness="1"/>

Since we have 22 usuable columns and we only used 19 of them for our main menu we can now create another label but this time we name it main_menu_header for later reference. Next we set the row to zero since were are still using the first row but this time we start the column at the 19th column where we left off and use ColumnSpan to span up to column 21. So we now have 19, 20, 21 to use for our 3 header buttons. We want to make it the same color as the main menu with the same border color but this time on appearance we want to have left at zero otherwise there will be a double line there from both menus so we need to remove one from somewhere so we will do it here.
>     <Label x:Name="main_menu_header" Grid.Row="0" Grid.Column="19" Grid.ColumnSpan="21" Padding="0" Background="#FF141414" BorderBrush="Black" BorderThickness="1" />

Now we can create our first button for the main menu. We are going to name it main_menu_file then we will set the content text to be File. Since we previously created the grisd to have 18 usable columns we ca not start placing buttons inside. Here we are still in the first row so Grid.Row zero and we are placing the button in the first column so Grid.Column zero but we do not want to span across the columns so no Column.Span this time. Next we click the button label line in our xaml and move into the properties tab, under layout, we want to set width to 100 and height to 18 since our row height is 20 we are giving our button a little room. We can also set the buttons background color now to maybe the same color as our main menu rgb 20, 20, 20. We can also add in the foreground color which is the text color for our button. I chose a teal color rgb 0, 128, 128.
>      <Button x:Name="main_menu_file" Content="File" Grid.Row="0" Grid.Column="0" Width="100" Height="18" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>

We would do the same thing for the edit button but this time we name it main_menu_edit then change the Grid.Column to 1 this time.
>      <Button x:Name="main_menu_edit" Content="Edit" Grid.Row="0" Grid.Column="1" Width="100" Height="18" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>

For the main header buttons there is a way to add in an icon but I chose to just use _,[], and x for the buttons content. Otherwise there really are no changes except for putting the min button at 19, the max at 20, and the exit button at 21 in the column section and adding a lilttle padding whcih can be found under layout. 
>     <Button x:Name="main_header_min"  Content="_"  Grid.Column="19" Width="16" Height="16" Padding="0,-2,0,0" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>
>     <Button x:Name="main_header_max"  Content="[]" Grid.Column="20" Width="16" Height="16" Padding="0,-2,0,0" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>
>     <Button x:Name="main_header_exit" Content="X"  Grid.Column="21" Width="16" Height="16" Padding="0"        Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>

We also need to turn BorderBrush for all these buttons so they look better like they just blend into the menu. You can do ths under properties, brush, BorderBrush and select the first option.

At this point the window should like this:
![window_menu](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/2b2a16c8-33e7-443c-99ac-dd2b5f22b9b1)

If you need to verify the code please refer to the MainWindow.xaml attached to this lesson.
