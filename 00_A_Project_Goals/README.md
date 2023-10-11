
The goal of this ide project:

Some of these, may be just pipe dreams, but nevertheless i'll add them. We will defiantly work on the main things that make an ide.

1) Make a usuable ide that others and myself can learn from to create a real ide.
2) The main goal is to be able to open up files into a tabbed window, edit them in a tabbed window, and save them so they can be reopened another time like a normal ide text editor.
3) A plugin framework so that most of these things can work properly.
4) Get the run button working with a couple of backends.  (compiler/assembler)
5) Dockable windows
6) Syntax formatting for previous languages / multiple options to create new sytanx formatting for new languages
7) Theme setting so the user can set thier own.
8) Precise and wordy debugger that displays in output window. (In my compiler I get down on describing where the errors are coming from).
9) Eventually a plug in that will allow the use of the terminal window. Would like to create my own terminal commands (lexer) and a new version of make eventually.
10) Hex reader and converter(displays in it's own window) with color formatting
11) Binary reader and converter (displays in it's own window) with color formatting

12) Create an ide that will allow multiple projects to be in progress in the main project directory. (Solution explorer, File Archive, Folder Directory)

12_A) We always create a main folder when starting a new project. So when we create a main folder that folder is usually what holds all our projects files but if we allowed the sub-folders of that main folder to be set on the command line and put into the sub folders path  into the project path button as a list of paths then we could have multiple projects in one main project. 

12_B) When we want to run and debug one of the projects then we would pick our compiler/assembler from the program button because we are choosing the program we are wanting to use to compile or assemble and then we set the path of that project through the project path button so there are no compilation errors.

              ide <------------------- main folder
               |
           ----------------
           |              |
           |              |
           |              |_ preprocessor  <------------------ sub folder 1
           |                         |
           |_ compiler <-------------|------------------ sub folder 2
           |                         |
           |                         |_ main.c
           |                    
           |_ main.c                    


![compiler_options](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/aedea48b-15cb-4834-8d80-f31305f03432)

Any folders or files in side the sub folder would not be subjected to the same course of action as the sub folder itself. This would allow you to work on two related projects and test them as you go and it would allow you to share more easily between shared libs between projects/programs.

13) As part of the program button, I would like to create small programs, that can be ran out of the program in this ide. For example a pre-written lexer exectuable that will lex the file. And other similiar programs. These programs could be added though the plugin system and allow it to be in the drop down list of the program button if plugin for it is enabled.

The need for a plugin framework isnt to plugin third party software but to create the plugins needed for this project ourselves.
