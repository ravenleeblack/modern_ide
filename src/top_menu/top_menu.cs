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


namespace Illeshian
{
    public partial class top_menu : Window
    {
        private main_window mainWindowInstance;
        private Label file_label;
        private Label edit_label;

        public top_menu(main_window mainWindowInstance, Label file_label, Label edit_label)
        {
            this.mainWindowInstance = mainWindowInstance;
            this.file_label = file_label;
            this.edit_label = edit_label;
        }

        public void top_menu_file_button(object sender, RoutedEventArgs e)
        {
            file_label.Visibility = Visibility.Visible;
        }

        public void top_menu_edit_button(object sender, RoutedEventArgs e)
        {
            edit_label.Visibility = Visibility.Visible;
        }
    }
}
