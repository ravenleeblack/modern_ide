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
    public class right_click_manager
    {
        public Label customContextMenuLabel;  // Now public
        public Grid MainGrid;
        public TreeViewItem currentSelectedTreeViewItem;
        public ContextMenu customContextMenu;

        public right_click_manager(Grid mainGrid, Label contextMenuLabel)
        {
            MainGrid = mainGrid;
            customContextMenuLabel = contextMenuLabel;

            // Create the context menu
            customContextMenu = new ContextMenu();
            customContextMenuLabel = new Label();
            customContextMenuLabel.Content = "Menu";
            customContextMenuLabel.Background = new SolidColorBrush(Color.FromRgb(30, 30, 30));
            customContextMenuLabel.Foreground = new SolidColorBrush(Color.FromRgb(47, 79, 79));
            customContextMenuLabel.FontSize = 14;
            customContextMenuLabel.Padding = new Thickness(10);
            customContextMenu.Items.Add(new MenuItem { Header = customContextMenuLabel });
        }

        public void TreeViewItem_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            TreeViewItem treeViewItem = sender as TreeViewItem;
            Point position = e.GetPosition(treeViewItem);
            customContextMenuLabel.Margin = new Thickness(position.X, position.Y, 0, 0);
            customContextMenuLabel.Visibility = Visibility.Visible;
        }

        public void TreeViewItem_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            e.Handled = true;
            currentSelectedTreeViewItem = sender as TreeViewItem;  // This should now be fine

            Point position = Mouse.GetPosition(MainGrid); // Use MainGrid as reference
            customContextMenuLabel.Margin = new Thickness(position.X, position.Y, 0, 0);
            customContextMenuLabel.Visibility = Visibility.Visible;
        }
    }
}
