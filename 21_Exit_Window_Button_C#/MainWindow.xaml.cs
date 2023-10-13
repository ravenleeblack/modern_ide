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
using System.Reflection;


namespace Illeshian_Ide_
{
    public partial class MainWindow : Window
    {
        private compiler_manager CompilerManager { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            CompilerManager = new compiler_manager(status_bar, status_text);
        }

        public void run_program(object sender, RoutedEventArgs e)
        {
            CompilerManager.run_program(sender, e);
        }

        public void stop_program(object sender, RoutedEventArgs e)
        {
            CompilerManager.stop_program(sender, e);
        }

        private void exit_program(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

