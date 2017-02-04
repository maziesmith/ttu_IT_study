using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication {
    class MainWindow: Window {
        private Button btnExitApp = new Button();

        public MainWindow(string windowTitle, int height, int width) {
            // Configure button and set the child control.
            btnExitApp.Click += new RoutedEventHandler(btnExitApp_Clicked);
            btnExitApp.Content = "Exit";
            btnExitApp.Height = 25;
            btnExitApp.Width = 100;

            // A fancy brush for the background.
            LinearGradientBrush fancyPrush = new LinearGradientBrush(Colors.DarkGreen, Colors.LightGreen, 45);

            btnExitApp.Background = fancyPrush;

            // Set the conent of this window to a single button.
            this.Content = btnExitApp;

            // Configure the window.
            this.Title = windowTitle;
            this.Height = height;
            this.Width = width;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            // Events!
            this.Closing += MainWindow_Closing;
            this.Closed += MainWindow_Closed;
            this.MouseMove += MainWindow_MouseMove;
            this.KeyDown += MainWindow_KeyDown;
        }

        private void btnExitApp_Clicked(object sender, RoutedEventArgs e) {
            // Application-wide data can be accesed from anywhere within the WPF application.
            if ((bool)Application.Current.Properties["GodMode"]) {
                MessageBox.Show("Cheater!");
            }

            this.Close();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            // See if the user really wants to shut down this window.
            string msg = "Do you want to close without saving?";
            MessageBoxResult result = MessageBox.Show(msg, "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.No) {
                // If user does not want to close, cancel closure.
                e.Cancel = true;
            }
        }

        private void MainWindow_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) {
            // Set the title of the window to the current (x, y) of the mouse.
            this.Title = e.GetPosition(this).ToString();
        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e) {
            btnExitApp.Content = e.Key.ToString();
        }

        private void MainWindow_Closed(object sender, EventArgs e) {
            MessageBox.Show("See ya!");
        }
    }

    class Program: Application {
        // The Main() method of a WPF application must be attributed with the [STAThread]
        // attribute, which ensures any legacy COM objects used by your application are thread safe.
        // If you do not annote Main() in this way, you will encounter a runtime exception.
        // p. 1101 Chapter 26 - A. Tolstein C# 6.0
        [STAThread]
        static void Main(string [] args) {
            Program app = new Program();

            app.Startup += new StartupEventHandler(AppStartUp);
            app.Exit += new ExitEventHandler(AppExit);

            app.Run();
        }

        static void AppExit(object sender, ExitEventArgs e) {
            MessageBox.Show("App has exited");
        }

        static void AppStartUp(object sender, StartupEventArgs e) {
            // Check the incoming command-line arguments and see if they specified a flag for /GODMODE
            Application.Current.Properties["GodMode"] = false;

            foreach (string arg in e.Args) {
                if (arg.ToLower() == "/godmode") {
                    Application.Current.Properties["GodMode"] = true;
                    break;
                }
            }

            // Create a MainWindow object.
            MainWindow main = new MainWindow("Hello word!", 300, 300);

            main.Show();
        }
    }
}