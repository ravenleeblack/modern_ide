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
    public class editor_manager : Window
    {
        public TabControl fileWindow;
        private archive_manager archiveManager;


        public editor_manager(TabControl fileWindow, archive_manager archiveManager)
        {
            this.fileWindow = fileWindow;
            this.archiveManager = archiveManager;
        }

        public TabItem find_existing_tab(string filePath)
        {
            foreach (TabItem tab in fileWindow.Items)
            {
                if (tab.Header.ToString() == System.IO.Path.GetFileName(filePath))
                {
                    return tab;
                }
            }
            return null;
        }


        public RichTextBox load_file_into_tab(string filePath)
        {
            // Create a new RichTextBox for file content
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Style = (Style)FindResource("ColoredBorderNoFocusCaret");
            richTextBox.IsInactiveSelectionHighlightEnabled = false;

            // Apply the custom style to the RichTextBox
            richTextBox.Style = (Style)FindResource("ColoredBorderNoFocusCaret");

            string fileContent = File.ReadAllText(filePath);
            FlowDocument doc = new FlowDocument(new Paragraph(new Run(fileContent)));
            richTextBox.Document = doc;

            // Set the background and foreground colors of the RichTextBox
            SolidColorBrush richTextBoxBackground = new SolidColorBrush(Color.FromRgb(30, 30, 30)); // Background color
            SolidColorBrush richTextBoxForeground = new SolidColorBrush(Color.FromRgb(100, 100, 100)); // Foreground color
            richTextBox.Background = richTextBoxBackground;
            richTextBox.Foreground = richTextBoxForeground;

            return richTextBox;
        }

        public TabItem load_tab_item(string filePath)
        {
            TabItem tabItem = new TabItem();
            tabItem.Header = System.IO.Path.GetFileName(filePath);

            Grid grid = new Grid();

            // Create two columns for line numbers and file content
            ColumnDefinition columnWithNumbers = new ColumnDefinition();
            columnWithNumbers.Width = new GridLength(40); // Adjust the width as needed
            ColumnDefinition columnWithContent = new ColumnDefinition();
            grid.ColumnDefinitions.Add(columnWithNumbers);
            grid.ColumnDefinitions.Add(columnWithContent);

            // Load line numbers column
            ListView lineNumberListView = load_file_num_count(filePath);
            Grid.SetColumn(lineNumberListView, 0);
            grid.Children.Add(lineNumberListView);


            // Load file content column
            RichTextBox richTextBoxForFileContent = load_file_into_tab(filePath);
            Grid.SetColumn(richTextBoxForFileContent, 1);
            grid.Children.Add(richTextBoxForFileContent);

            tabItem.Content = grid;
            return tabItem;
        }

        public ListView load_file_num_count(string filePath)
        {
            ListView listView = new ListView();
            listView.Width = 40;
            listView.Background = new SolidColorBrush(Color.FromRgb(30, 30, 30));
            listView.Foreground = new SolidColorBrush(Color.FromRgb(47, 79, 79));
            listView.BorderThickness = new Thickness(0);
            listView.Padding = new Thickness(0);
            listView.Margin = new Thickness(0);
            listView.Focusable = false;
            listView.IsHitTestVisible = false;

            // Disable selection highlight
            listView.ItemContainerStyle = new Style(typeof(ListViewItem));
            listView.ItemContainerStyle.Setters.Add(new Setter(ListViewItem.FocusableProperty, false));

            // Set the line height
            listView.ItemTemplate = new DataTemplate(typeof(TextBlock));
            FrameworkElementFactory textBlockFactory = new FrameworkElementFactory(typeof(TextBlock));
            textBlockFactory.SetValue(TextBlock.LineHeightProperty, 12.0); // Adjust line height as needed
            listView.ItemTemplate.VisualTree = textBlockFactory;

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                listView.Items.Add((i + 1).ToString());
            }

            return listView; // Return the ListView directly
        }
    }
}
