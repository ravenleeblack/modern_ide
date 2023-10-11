In this lesson we will be using some label controls to make our own main menu, we will add the file and edit buttons, then we will add the min, max, and exit button. We will not be hooking the mechanics for the button until another lesson. If you remember back to the introduction lesson the ui interface is written in xaml and the the mechanics are written in C# so I want to try and keep them as seperate as possible in the lessons until we have no choice.

For the main menu we will be using a label control. It doesnt seem like it will hold the buttons like a container should, so we will just use the label as a background, with the menu button we create overlaying the label. So I suppose its not techinally a custom menu because its not connected as a single ui control working together as a unit but doing it this way is better then having to deal with a normal main menu that will not let me remove the ugly white from the context drop downs.

The first thing we are going to do is open up our MainWindow.xaml file again. This time we are going to create a label tag that we will use as a menu background. 
>     <label/>

We are going to name our label tag so that if we ever need to refer back to this label we can.
>     <label x:Name="main_menu"/>

In the previous lesson we have already set up our Grid so now all we have to do is use it by adding a child control. The child control we will be using is the label we just created so we need to set some properties in the label tag. 

Rows and Columns in the Grid start from zero like an array so the first row is actually row zero and the first column is column zero. We needed to know that so we can set up our controls properly. We want to put our label or main menu in row zero and start in column zero. Since we need to have our label or main menu in more then one coulumn we can use ColumnSpan and tell it how many columns we want the span across on the Grid. Since we previously set up 22 columns to span 1920 pixels we would have to set ColumnSpan to 22.
>     <label x:Name="main_menu" Grid.Row="0" Grid.Column="0" Grid.ColumnSpan="22"/>

Next we can change the color of our label, provide an outline or border, and set the thickness of that border so that it looks nice. If you click on the label tag in the xaml code, the properties tab will be updated with the label type, and we can start editing our label. You always want to verify that you are indeed on the right control when you are working in the properties tab.

![type](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/9ce02f8d-369a-4e2e-b393-d05abf5766e3)

Under Brush we can set the background color. I set mine to rgb 20, 20, 20. We can also set the BorderBrush color. I set mine to rgb 0, 0, 0 so that its a little darker then the label itself and will stand out a little bit. Then under the appearance tab, there is a down arrow that needs to be expanded to show the BorderThickness options. We will all to 1 pixel thick.
>     <label x:Name="main_menu" Grid.Row="0" Grid.Column="0" Grid.ColumnSpan="19" Background="#FF141414" BorderBrush="Black" BorderThickness="1"/>


Now we can create our first button for the main menu. We are going to name it main_menu_file. We will set the content text to be File. Take note that naming the control and setting the content text for a control are two different things. When we name the control we are naming the control itself so that we can reference it later in C# and when we fill out the content text we are setting the foreground text that will be shown on or in our control at runtime. With the button tag below only file will be shown at runtime.
>      <Button x:Name="main_menu_file" Content="File"/>

So now that we have named it, and set the text for its foreground text, we need to tell the tag where we want our button control to be. Since this is the first button, we would want it in row zero and column zero, but we do not want it to span into other columns like before so we would write it like so:
>      <Button x:Name="main_menu_file" Content="File" Grid.Row="0" Grid.Column="0"/>

Now that we have it named and placed into the grid we can work on the visuals of the button control. We want to set the background color of the button and set the buttons foregroud color which is the  buttons text or content text but this time we are going to set the BorderBrush to null. With our main menu being so small in height, adding a border around each of the buttons, is going to make the main menu label control and button look very overcrowded. From what I read the less, the better, when you can. So what we need to do is make the background color of the button be the same as the label and remove the buttons border so that it looks like the button is aprt of the menu and blends in.
>      <Button x:Name="main_menu_file" Content="File" Grid.Row="0" Grid.Column="0" Width="100" Height="18" Background="#FF141414" Foreground="Teal" BorderBrush="{x:Null}"/>

As you can see, with the border, its kinda overcrowded. ITs making the touching pixels or lines look thicker then they should be:

![border](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/dd6daa12-f5d3-494b-972a-921008af7e9c)

While this one without the border blends in a little better and looks more correct:

![noborder](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/4ca6fa27-46f8-4b35-b885-70d164fee461)


Since we previously created the grisd to have 18 usable columns we ca not start placing buttons inside. Here we are still in the first row so Grid.Row zero and we are placing the button in the first column so Grid.Column zero but we do not want to span across the columns so no Column.Span this time. Next we click the button label line in our xaml and move into the properties tab, under layout, we want to set width to 100 and height to 18 since our row height is 20 we are giving our button a little room. We can also set the buttons background color now to maybe the same color as our main menu rgb 20, 20, 20. We can also add in the foreground color which is the text color for our button. I chose a teal color rgb 0, 128, 128.
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

![menu_1](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/f2fc24f5-cedf-4871-b8d5-5e7911fd99e2)

![menu_2](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/833f5370-1dfa-4649-b45a-3485de379a19)

If you need to verify the code please refer to the MainWindow.xaml attached to this lesson.
