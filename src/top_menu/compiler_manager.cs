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
    public class compiler_manager : Window
    {
        public StatusBar Status_bar { get; set; }
        public TextBlock Status_text { get; set; }

        private Brush originalBackground;
        private Brush originalForeground;
        private string originalStatusText;

        public compiler_manager(StatusBar status_bar, TextBlock status_text)
        {
            Status_bar = status_bar;
            Status_text = status_text;
        }


        public void run_program(object sender, RoutedEventArgs e)
        {
            originalBackground = Status_bar.Background;
            originalForeground = Status_bar.Foreground;
            originalStatusText = Status_text.Text;

            Color backgroundColor = Color.FromRgb(136, 48, 0);
            Color foregroundColor = Color.FromRgb(255, 140, 0);

            Brush backgroundBrush = new SolidColorBrush(backgroundColor);
            Brush foregroundBrush = new SolidColorBrush(foregroundColor);

            Status_bar.Background = backgroundBrush;
            Status_bar.Foreground = foregroundBrush;
            Status_text.Text = "Status: Running...";
            Console.WriteLine(" The run button has been pressed");
        }

        public void stop_program(object sender, RoutedEventArgs e)
        {
            Status_bar.Background = originalBackground;
            Status_bar.Foreground = originalForeground;
            Status_text.Text = originalStatusText;
            Console.WriteLine(" The stop button has been pressed");
        }
    }
}
