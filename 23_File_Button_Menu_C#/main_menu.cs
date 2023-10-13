using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls.Primitives;


namespace Illeshian_Ide_
{
    public partial class main_menu : Window
    {
        private MainWindow mainWindow;
        private Label file_label;

        public main_menu(MainWindow mainWindow, Label fileLabel)
        {
            this.mainWindow = mainWindow;
            this.file_label = fileLabel;
        }

        public void file_program(object sender, RoutedEventArgs e)
        {
            file_label.Visibility = Visibility.Visible;
        }
    }
}
