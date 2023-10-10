using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;


namespace Illeshian
{

    public partial class main_window : Window
    {
        private archive_manager archiveManager;
        public editor_manager FileManager { get; private set; }
        private compiler_manager CompilerManager { get; set; }
        private top_menu topMenuInstance;
        private Control someControl1;
        private Control someControl2;



        public main_window()
        {
            InitializeComponent();

            someControl1 = new Control();
            someControl2 = new Control();

            archiveManager = new archive_manager();
            archiveManager.load_directory(archive_tree_view);

            FileManager = new editor_manager(file_window, archiveManager); 

            CompilerManager = new compiler_manager(status_bar, status_text);

            topMenuInstance = new top_menu(this, file_label, edit_label);

            var mouseManagerInstance = new mouse_manager(status_text, someControl1, someControl2, file_label, edit_label);
            // this.Loaded += mouseManagerInstance.InitializeMouseHandlers;


        }


        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Your InputTextBox key down logic here
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Your mouse down logic here
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            // Your mouse move logic here
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            // Your mouse enter logic here
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            // Your mouse leave logic here
        }

        private void file_selection(object sender, RoutedEventArgs e)
        {
            // Your file selection logic here
        }

        private void edit_selection(object sender, RoutedEventArgs e)
        {
            // Your edit selection logic here
        }

        private void exit_app(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void run_program(object sender, RoutedEventArgs e)
        {
            CompilerManager.run_program(sender, e);
        }

        public void stop_program(object sender, RoutedEventArgs e)
        {
            CompilerManager.stop_program(sender, e);
        }

        private void main_project_button(object sender, RoutedEventArgs e)
        {
            main_project_menu mainProjectWindow = new main_project_menu(archive_tree_view);
            mainProjectWindow.Show();
        }

        private void new_project_button(object sender, RoutedEventArgs e)
        {
          
        }

        private void load_project_button(object sender, RoutedEventArgs e)
        {
            // Your load project button logic here
        }

        private void new_file_button(object sender, RoutedEventArgs e)
        {
            // Your new file button logic here
        }

        private void load_file_button(object sender, RoutedEventArgs e)
        {
            // Your load file button logic here
        }

        private void save_file_button(object sender, RoutedEventArgs e)
        {
            // Your save file button logic here
        }

        public void top_menu_file_button(Object sender, RoutedEventArgs e)
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

        public void top_menu_edit_button(Object sender, RoutedEventArgs e)
        {
            try
            {
                topMenuInstance.top_menu_edit_button(sender, e);
            }
            catch (NullReferenceException ex)
            {
                // Log the exception or display a message
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
        }
    }
}
