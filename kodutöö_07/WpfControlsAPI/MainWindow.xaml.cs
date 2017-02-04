using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Ink;

namespace WpfControlsAPI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            InitializeDefaultInkCanvas();
        }

        private void InitializeDefaultInkCanvas() {
            this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            this.inkRadio.IsChecked = true;
            this.comboColors.SelectedIndex = 0;
        }

        private void RadioButtonClicked(object sender, RoutedEventArgs e) {
            switch ((sender as RadioButton)?.Content.ToString()) {
                case "Ink Mode":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "Erase Mode":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
                case "Select Mode":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
            }
        }

        private void ColorChange(object sender, SelectionChangedEventArgs e) {
            string colorToUse = (this.comboColors.SelectedItem as ComboBoxItem)?.Content.ToString();

            this.myInkCanvas.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(colorToUse);
        }

        private void SaveData(object sender, RoutedEventArgs e) {
            using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Create)) {
                this.myInkCanvas.Strokes.Save(fs);
                fs.Close();
            }
        }

        private void LoadData(object sender, RoutedEventArgs e) {
            using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Open, FileAccess.Read)) {
                StrokeCollection strokes = new StrokeCollection(fs);
                this.myInkCanvas.Strokes = strokes;
            }
        }

        private void Clear(object sender, RoutedEventArgs e) {
            this.myInkCanvas.Strokes.Clear();
        }
    }
}
