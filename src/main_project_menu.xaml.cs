using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Illeshian
{

    public partial class main_project_menu : Window
    {
        private string mainProjectDirectory;
        private archive_manager archiveManager;
        private TreeView archive_tree_view; // Declare the field here


        public main_project_menu(TreeView treeView) // Update the constructor
        {
            InitializeComponent();
        }


        private void main_project_click(object sender, RoutedEventArgs e)
        {  
            Close();
        }


        private void exit_project_click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void file_name_changed(object sender, TextChangedEventArgs e)
        {
            string projectName = file_name_textbox.Text.Trim();
            New_Project.IsEnabled = !string.IsNullOrEmpty(projectName);
        }
    }
}
