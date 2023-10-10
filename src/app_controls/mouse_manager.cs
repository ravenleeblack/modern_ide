using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Illeshian
{
    public class mouse_manager : Window
    {
        public TextBlock mouse_info { get; set; }
        private Control file_file;
        private Control edit_file;
        private FrameworkElement file_label;
        private FrameworkElement edit_label;
        private bool isMouseMoving;

        public mouse_manager(TextBlock mouseInfo, Control fileFile, Control editFile, FrameworkElement fileLabel, FrameworkElement editLabel)
        {
            this.mouse_info = mouseInfo;
            this.file_file = fileFile;
            this.edit_file = editFile;
            this.file_label = fileLabel;
            this.edit_label = editLabel;
            this.Loaded += InitializeMouseHandlers;
        }

        private void InitializeMouseHandlers(object sender, RoutedEventArgs e)
        {
            // Attach event handlers to the controls where you want to track mouse events
            file_file.MouseEnter += OnMouseEnter;
            file_file.MouseLeave += OnMouseLeave;
            file_file.MouseDown += OnMouseDown;
            file_file.MouseMove += OnMouseMove;

            edit_file.MouseEnter += OnMouseEnter;
            edit_file.MouseLeave += OnMouseLeave;
            edit_file.MouseDown += OnMouseDown;
            edit_file.MouseMove += OnMouseMove;
        }

        public void OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Control control)
            {
                Point enterPos = e.GetPosition((IInputElement)sender);
                mouse_info.Text = "Mouse Entered: " + control.Name + " Position: " + enterPos.ToString();
                control.Background = Brushes.SlateGray;

                if (control == file_file)
                {
                    file_label.Visibility = Visibility.Visible;
                }
                else if (control == edit_file)
                {
                    edit_label.Visibility = Visibility.Visible;
                }
            }
        }

        public void OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Control control)
            {
                if (control == file_file)
                {
                    file_label.Visibility = Visibility.Collapsed;
                }
                else if (control == edit_file)
                {
                    edit_label.Visibility = Visibility.Collapsed;
                }
            }
            if (mouse_info != null)
            {
                mouse_info.Text = "Mouse Leave";
            }
        }


        public void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Control control)
            {
                Point clickPos = e.GetPosition((IInputElement)sender);
                mouse_info.Text = "Mouse Click (" + control.Name + "): " + clickPos.ToString();
                control.Background = Brushes.Beige;
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            Point movePos = e.GetPosition((IInputElement)sender);
            mouse_info.Text = "Mouse Hover: " + movePos.ToString();
        }

        public bool IsMouseOverElement(FrameworkElement element)
        {
            Point mousePos = Mouse.GetPosition(element);
            return new Rect(new Point(0, 0), element.RenderSize).Contains(mousePos);
        }
    }
}
