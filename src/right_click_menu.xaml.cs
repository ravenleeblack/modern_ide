using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;


namespace Illeshian
{

    public partial class right_click_menu : Window
    {
        private main_window mainWindow;
        private archive_manager archiveManager;
        private List<string> filePaths = new List<string>();



        public right_click_menu(main_window mainWin)
        {
            InitializeComponent();
            mainWindow = mainWin; // Store the reference to the MainWindow instance
        }

        private void right_click_new_project(object sender, RoutedEventArgs e)
        {
            Close();
            // Pass the existing archive_manager instance to new_project_menu
            new_project_menu newProjectMenu = new new_project_menu(archiveManager);

            // Show the new window
            newProjectMenu.Show();
        }

        private void right_click_load_project(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void right_click_new_file(object sender, RoutedEventArgs e)
        {
            Close();
            new_project_menu newProjectMenu = new new_project_menu(archiveManager);
            newProjectMenu.Show();
        }


        // Inside right_click_menu.xaml.cs
        public void right_click_load_file(object sender, RoutedEventArgs e)
        {
            Close();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                TabItem existingTab = mainWindow.FileManager.find_existing_tab(filePath); // Use FileManager
                if (existingTab != null)
                {
                    mainWindow.file_window.SelectedItem = existingTab;
                }
                else
                {
                    TabItem tabItem = mainWindow.FileManager.load_tab_item(filePath); // Use FileManager
                    mainWindow.file_window.Items.Add(tabItem);
                    mainWindow.file_window.SelectedItem = tabItem;
                }
                mainWindow.file_window.Visibility = Visibility.Visible;
            }
        }

        private void right_click_copy(object sender, RoutedEventArgs e)
        {

        }

        private void right_click_delete(object sender, RoutedEventArgs e)
        {

        }

        private void right_click_settings(object sender, RoutedEventArgs e)
        {

        }
    }
}
