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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kodutöö_05 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void buttonClick(object sender, RoutedEventArgs e) {
            textBlock.Text = PasswordGenerator.Password;
        }

        private void updateSize(object sender, RoutedPropertyChangedEventArgs<double> e) {
            PasswordGenerator.Length = (int)e.NewValue;
        }
    }

    public class PasswordGenerator {
        private static Random _rand = new Random();

        private static string _alphabet = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static int Length { get; set; } = 13;

        public static string Password {
            get {
                char[] passwordCharacters = new char[Length];

                for (int i = 0; i < Length; i++) {
                    passwordCharacters[i] = _alphabet[_rand.Next(_alphabet.Length)];
                }

                return new string(passwordCharacters);
            }
        }
    }
}