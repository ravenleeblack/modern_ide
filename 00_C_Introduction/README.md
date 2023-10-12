WPF is the successor to Window Forms for desktop application development. The user interface is written in xaml, and is seperate from the code that makes the user interface or ui work, which will be written in C#. There will be lessons in xaml and then there will be lessons in c# so that we can connect the ui elements up with the right code to make it work. In order to create this large project we are going to take it step by step. With every new lesson we will add a new feature until we are finished and have our desired ide.

If you followed the setup lesson correctly then you should have a new project opened and it look something like this:

![opened_project](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/1f3efc7e-d439-4d49-8657-a8acec31fa70)

In our file solution we should have:

![file_solution](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/bca19738-27fd-4c96-b6a7-fd7839a23db5)

In future lessons I will not be be adding the Properties, References, app.config, or app.xaml files into each of the lessons. These are automatically added when the project is created. I will only add if there has been a change  in any of them but for the most part I do not see a reason that they will change.

I will only be adding the files mainwindow.xaml and any new files that are created as we progress in order to keep the project as clean as possible. Be aware that even doe these files will be provided in all lessons, some of them may not have any changes while some do.

As the lessons progress, I will use less images to explain things, that we have already covered. 

To me, I think the most logical way to progress, would be to start off by setting up our ui elements in xaml first. Lets get the ui elements laid out and get them looking good before we move onto hooking the code up. Afterwards we can set up the mechanics, events or code behind to make all the nice ui elements work as intended. We dont need to be worrying about styles and other ui related stuff while trying to code it all together that would be kinda messy and take us all over the place. I am trying to figure out how to do this in general and then do so by getting straight to the point with just enough information to understand what were doing without overly complicating things. Remember I warned you at the front xaml and C# isnt my strong point so I am in a learning curve as much as you are right now but even with that being said something or someone trying to provide the information to build a real ide is better then nothing so...  Lets begin???


