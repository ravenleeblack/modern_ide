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

namespace Illeshian
{
    public partial class new_file_menu : Window
    {
        private string SelectedFileExtension;
        public string SelectedFileName;

        public new_file_menu()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Accept button clicked.");

            // Determine the selected file extension based on the clicked TextBlock
            if (!string.IsNullOrEmpty(SelectedFileExtension))
            {
                SelectedFileName = SelectedFileExtension;

                Console.WriteLine("Selected Extension: " + SelectedFileExtension);
            }
            else
            {
                Console.WriteLine("No file extension selected.");
            }

            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string enteredText = NameTextBox.Text;
            Console.WriteLine("Entered text in NameTextBox: " + enteredText);
        }

        private void FileExtension_Clicked(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("ListBox clicked.");

            if (sender is TextBlock textBlock)
            {
                SelectedFileExtension = textBlock.Text.Trim();
                Console.WriteLine("Selected file extension: " + SelectedFileExtension);
            }
            else
            {
                Console.WriteLine("Event handler triggered but sender is not TextBlock.");
            }
        }
    }
}
