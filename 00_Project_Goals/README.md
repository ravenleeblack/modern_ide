The goals of this project:

Some of these, may be just pipe dreams, but nevertheless ill add them. We will defiantly work on the main things that make an ide.

1) Make a usuable ide that can others and myself can learn from to create a real ide.
2) The main goal is to be able to open up files, edit them in a tabbed window, and save them so they can be reopened another time like a normal ide text editor.
3) A plugin framwork so that most of these things can work properly.
4) Get the run button working with a couple of backends.  (compiler/assembler)
5) Dockable windows
6) Syntax formatting
7) Theme setting so the user can set thier own.
8) precise and wordy debugger that displays in output window. (In my compiler I get down on describing where the errors are coming from).
9) Evetually a plug in that will allow to use the terminal window. Would like to create my own terminal commands and a new version of make eventually.
10) hex reader (displays in it's own window) with color formatting
11) binary reader (displays in it's own window) with color formatting

12) Create an ide that will allow multiple projects to be in progress in the main directory. If we create a main project folder, we could in theory use a button to direct the ide to a particular sub folder or sub directory to be compiled at runtime, or the path as we say, then when the run button is pressed it will only compile the sub-folder so there is no conflictions with the other folders in main directory. An example of this would be:

![example](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/246263ee-71a0-4deb-913d-cbc50172b700)

Here Illeshian_Ide_ is our main project folder now ill_compiler and preprocessor folders are sub folders. In this new ide we would choose what languange we want to use by using the program button drop down then set the path we want by using the project path button before pressing the run button. The project path button should have a list of the the available sub folders and of course be put on the command line so it can be used. Any child folders of the main would be considered a project so you would always have to create your files in any one of the sub folders. This would allow 2 projects to be going on during development that are related. It would also allow for any 2 projects to openly use a shared library more easily.

![compiler_options](https://github.com/ravenleeblack/Illeshian-Ide/assets/76606152/aedea48b-15cb-4834-8d80-f31305f03432)

The program button should be a drop down list of the availabe compilers or assemblers connected to it. With the compiler selected and the path set it wold compile the right files on the right path.


