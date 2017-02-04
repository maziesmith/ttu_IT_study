using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace VisualLayoutTesterApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            SetF1CommandBinding();
        }

        private void SetF1CommandBinding() {
            CommandBinding helpBinding = new CommandBinding(ApplicationCommands.Help);

            helpBinding.CanExecute += CanHelpExecute;
            helpBinding.Executed += HelpExecuted;

            CommandBindings.Add(helpBinding);
        }

        private void CanHelpExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = true;
        }

        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e) {
            MessageBox.Show("Look, it is not that difficult. Just type something!", "Help!");
        }

        private void exit_MouseEnter(object sender, MouseEventArgs e) {
            statBarText.Text = "Exit the Application";
        }

        private void exit_MouseLeave(object sender, MouseEventArgs e) {
            statBarText.Text = "Ready";
        }

        private void exit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void spelling_MouseEnter(object sender, MouseEventArgs e) {
            statBarText.Text = "Show Spelling Suggestions!";
        }

        private void spelling_MouseLeave(object sender, MouseEventArgs e) {
            statBarText.Text = "Ready";
        }

        private void spelling_Click(object sender, RoutedEventArgs e) {
            string spellingHints = string.Empty;

            // Try to get a spelling error at the current caret location.
            SpellingError error = txtData.GetSpellingError(txtData.CaretIndex);

            if (error != null) {
                // Build a string of spelling suggestions.
                foreach (string s in error.Suggestions) {
                    spellingHints += $"{s}\n";
                }

                lblSpellingHints.Content = spellingHints;
                expanderSpelling.IsExpanded = true;
            }
        }

        private void OpenCmdExecuted(object sender, ExecutedRoutedEventArgs e) {
            // Create an open file dialog box and only show txt files.
            OpenFileDialog openDialog = new OpenFileDialog { Filter = "Text Files|*.txt" };

            // If click on the OK button
            if (openDialog.ShowDialog() == true) {
                string dataFromFile = File.ReadAllText(openDialog.FileName);
                txtData.Text = dataFromFile;
            }
        }

        private void SaveCmdExecuted(object sender, ExecutedRoutedEventArgs e) {
            SaveFileDialog saveDialog = new SaveFileDialog { Filter = "Text Files |*.txt" };

            if (saveDialog.ShowDialog() == true) {
                File.WriteAllText(saveDialog.FileName, txtData.Text);
            }
        }

        private void OpenCmdCanExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = true;
        }

        private void SaveCmdCanExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = true;
        }
    }
}
