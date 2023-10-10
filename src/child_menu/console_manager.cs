using Microsoft.Win32;
using System;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Illeshian
{
    public class console_manager
    {
        private TabControl tabControl;
        private TextBlock outputTextBlock;

        public console_manager(TabControl tabControl)
        {
            this.tabControl = tabControl;

            // Find the TextBlock in the TabItem
            TabItem outputTab = tabControl.FindName("output_tab") as TabItem;
            TextBlock outputTextBlock = outputTab?.Content as TextBlock;

            // Redirect console output
            Console.SetOut(new TextBlockWriter(outputTextBlock));
        }
    }

    public class TextBlockWriter : TextWriter
    {
        private TextBlock textBlock;

        public TextBlockWriter(TextBlock textBlock)
        {
            this.textBlock = textBlock ?? throw new ArgumentNullException(nameof(textBlock));
        }

        public override void Write(char value)
        {
            if (textBlock != null)
            {
                textBlock.Dispatcher.Invoke(() =>
                {
                    textBlock.Text += value;
                });
            }
        }

        public override Encoding Encoding => Encoding.UTF8;
    }

}
