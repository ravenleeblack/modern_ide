using System;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace Illeshian
{
    public class terminal_manager
    {
        private TextBox in_put_box;
        private TextBlock out_put_box;

        public terminal_manager(TextBlock out_put_box, TextBox in_put_box)
        {
            this.out_put_box = out_put_box;
            this.in_put_box = in_put_box;

            // Handle user input
            in_put_box.KeyDown += InputTextBox_KeyDown;
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                HandleInput();
                e.Handled = true;
            }
        }

        public void HandleInput()
        {
            string userInput = in_put_box.Text.Trim();
            string output = "";

            // Check if the input command is for Windows or Linux
            if (userInput.StartsWith("wsl "))
            {
                // Remove "wsl " prefix and execute on Linux
                output = ExecuteLinuxCommand(userInput.Substring(4));
            }
            else
            {
                // Execute on Windows
                output = ExecuteCommand(userInput);
            }

            // Append the input and output to the TextBlock
            out_put_box.Text += $"> {userInput}{Environment.NewLine}{output}";

            in_put_box.Clear();
        }

        private string ExecuteCommand(string command)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output;
            }
            catch (Exception ex)
            {
                return $"Error executing command: {ex.Message}";
            }
        }

        private string ExecuteLinuxCommand(string command)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "wsl";
                process.StartInfo.Arguments = command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output;
            }
            catch (Exception ex)
            {
                return $"Error executing command: {ex.Message}";
            }
        }

    }
}
