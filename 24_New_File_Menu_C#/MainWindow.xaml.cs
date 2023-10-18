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
using System.Reflection;


namespace Illeshian_Ide_
{
    public partial class MainWindow : Window
    {
        private compiler_manager CompilerManager { get; set; }
        private main_menu topMenuInstance;

        public MainWindow()
        {
            InitializeComponent();

            CompilerManager = new compiler_manager(status_bar, status_text);
            topMenuInstance = new main_menu(this, file_label);
        }

        public void run_program(object sender, RoutedEventArgs e)
        {
            CompilerManager.run_program(sender, e);
        }

        public void stop_program(object sender, RoutedEventArgs e)
        {
            CompilerManager.stop_program(sender, e);
        }

        private void exit_program(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void min_program(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void max_program(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }

        public void file_program(object sender, RoutedEventArgs e)
        {
            try
            {
                topMenuInstance.file_program(sender, e); // Change to file_program
            }
            catch (NullReferenceException ex)
            {
                // Log the exception or display a message
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
        }

        private void new_file_menu_click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the new window
            new_file_menu newWindow = new new_file_menu();

            // Show the new window
            newWindow.Show();
        }
    }
}

