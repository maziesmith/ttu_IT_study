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
using System.Windows.Annotations;
using System.Windows.Annotations.Storage;
using System.Windows.Markup;

namespace WpfControlsAPI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            InitializeDefaultInkCanvas();
            PopulateDocument();
            EnableAnnotations();
            AddEvents();
            SetBindings();
        }

        private void InitializeDefaultInkCanvas() {
            this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            this.inkRadio.IsChecked = true;
            this.comboColors.SelectedIndex = 0;
        }

        private void PopulateDocument() {
            this.listOfFunFacts.FontSize = 14;
            this.listOfFunFacts.MarkerStyle = TextMarkerStyle.Circle;

            this.listOfFunFacts.ListItems.Add(
                new ListItem(new Paragraph(new Run("Fixed documents are for WYSIWYG print ready docs!")))
            );

            this.listOfFunFacts.ListItems.Add(
                new ListItem(new Paragraph(new Run("The API supports tables and embedded figures!")))
            );

            Run prefix = new Run("This paragraph was generated.");

            // Midle of paragraph.
            Bold b = new Bold();
            Run infix = new Run("dynamically");
            infix.Foreground = Brushes.Red;
            infix.FontSize = 30;
            b.Inlines.Add(infix);

            // Last part of paragraph.
            Run suffix = new Run(" at runtime!");

            this.paraBodyText.Inlines.Add(prefix);
            this.paraBodyText.Inlines.Add(infix);
            this.paraBodyText.Inlines.Add(suffix);
        }

        private void EnableAnnotations() {
            // Create object that works with our FlowDocumentReader.
            AnnotationService anoService = new AnnotationService(myDocumentReader);

            // Create a MemoryStream that will hold the annotations.
            MemoryStream anoStream = new MemoryStream();

            // Now, create an XML-based store based on the MemoryStream.
            AnnotationStore store = new XmlStreamStore(anoStream);

            // Enable the services.
            anoService.Enable(store);
        }

        private void AddEvents() {
            btnSaveDoc.Click += (o, s) => {
                using (FileStream fStream = File.Open("documentData.xaml", FileMode.Create)) {
                    XamlWriter.Save(this.myDocumentReader.Document, fStream);
                }
            };

            btnLoadDoc.Click += (o, s) => {
                using (FileStream fStream = File.Open("documentData.xaml", FileMode.Open)) {
                    try {
                        FlowDocument doc = XamlReader.Load(fStream) as FlowDocument;
                        this.myDocumentReader.Document = doc;
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Error Loading Doc!");
                    }
                }
            };
        }

        private void SetBindings() {
            // CReate Binding object.
            Binding b = new Binding();

            // Register the converter, source, and path.
            b.Converter = new DoubleConverter();
            b.Source = this.mySB;
            b.Path = new PropertyPath("Value");

            // Call the SetBinding method on the Label.
            this.labelSBThumb.SetBinding(Label.ContentProperty, b);
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
