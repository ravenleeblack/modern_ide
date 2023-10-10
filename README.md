# Illeshian-Ide
                            
As we all know, making the ui and the code realted to make that ui work for a real ide, simply doesnt exist in the coding community as far learning how to build a usable one. Making anything ui isnt easy per say. Even worse we are starting to use too many of the same words for the different types of projects. For instance a text editor like vim that is strictly used in a terminal should be called a terminal editor or terminal text editor. A normal text editor like notepad should be called a text editor while a text editor inside an ide should be called an ide text editor. Thats away when searching google, we ourselves have opted to clarify and classify, in order to provide better search results so that we can access the correct info we want to code quicker. The way you approach one editor is different then the way you approach the others. For instance an ide text editor uses tabbed windows and doesnt take up the whole window like a text editor.

I am not the best in C# or xaml so I am hoping others will help contribute to this project. I have been building my own language and a compiler for it in pure c, and I am almost finished with it, so I would love to have the ui or ide part of it ready for when I do. As well as provide a spot for others to find a beginning in thier own ide journey.

![Illeshian_ide](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/59f95599-8e48-4abe-a98e-481588dc6ae5)

1) MENUS:
The window header and main menu are combined since the window header is usually a waste of space and we normally do not use all of the main menu. I combined them in a single custom made menu, with custom made drop downs and custom made buttons for min, max, and exit. I could not figure out how to remove all the white from the menu and dropdowns and I do not understand styles yet so custom was the best way to go. The button menus are suppose to close once they are outside of the buttons menu but it doesnt really work well at the moment because the mouse events are not registering well because of the dock panel.

![menu](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/63d00b19-8a91-4c5b-8779-0b5ec285d598)

2) WINDOWS:
If you ever wondered if you are suppose to use labels vs windows vs tabbed then the answer is: I read from the MS website that all modern ide's use tabbed windows. So all the windows are tabbed and inside a dock panel. The downside to this so far is that dock panel is preventing mouse events in the menu buttons above.

3) STATUS BAR:
At the bottom we have a status bar. In the tool bar we have a run button for our ide and when pressed at the moment it will turn the status bar dark orange to show that it is working or eventually that the compiler is running. Which is a feature of a normal ide. When the stop button is pressed  in our toolbar the status bar will return to it normal color. I di have at one point the status of the mouse events in the right part of the status bar but it seems to be broken at the moment.

![compiler_options](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/39fad417-eb80-4384-ba41-f6d11d88f92a)

5) FILE ARCHIVE:
 When creating a new project we should be creating a main folder to work out of. The file archive should be displaying the main project folder that we created and all its subfolders that would be evetually created.

6) OUTPUT WINDOW:
The output window like usual should just giving us feedback on whats going on in our program.  We will need to create a console window that displays at runtime like a normal ide.

16) TERMINAL WINDOW: In progress lmao

I would like to see the program button in the tool bar become a drop down of what language you would like to use, so that when you press the run button, it will only compile the files related to that compiler or assembler that you have chosen. (For multiple stage compilation). I would also like to be able to create a main project or folder, then  have multiple projects within, lets say that we create a seperate preprocessor and we have a compiler, then we would have two children folders one for the preprocessor and one for the compiler. The issue with this, is that the ide would try to compile everything in the directory, so I created a project path button in the toolbar so that we could evetually guide the ide to compile or assemble the exact folder and files in a sub directory folder if possible rather then trying to compile the whole main directory. This way you can have more then one related projects going on inside of the ide at once.

 ![compiler_options](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/df0dd4fb-07eb-4939-ab17-d0f9b85ddb49)

I would def be interested in a way to set themes so that the color of ui and text be changed. This still needs alot of work. I had new iles working and opening up a tabbed window for new files and saving the files but I broke it recently messing with the chatai.

If you want to help I am around my computer alot so I can return convos fairly quick. If you dont want to submit here then I welcome emails and even would to see anyone make a video.
