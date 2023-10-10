using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Illeshian
{
    public partial class new_project_menu : Window
    {
        private string projectName;
        private archive_manager archiveManager;

        public new_project_menu()
        {
            InitializeComponent();
        }

        public new_project_menu(string directory)
        {
            InitializeComponent();
            projectName = directory;
        }


        // Overloaded constructor to accept archive_manager
        public new_project_menu(archive_manager archiveManager)
        {
            InitializeComponent();
            this.archiveManager = archiveManager;
        }


        private void new_project_click(object sender, RoutedEventArgs e)
        {
            string folderName = file_name_textbox.Text.Trim(); // Assuming file_name_textbox contains the folder name

            Close();
        }

        private void exit_project_click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void file_name_changed(object sender, TextChangedEventArgs e)
        {
            projectName = file_name_textbox.Text.Trim();
            New_Project.IsEnabled = !string.IsNullOrEmpty(projectName);
        }
    }
}
