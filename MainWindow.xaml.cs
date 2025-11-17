using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorSetting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            alphaSlider.Value = 255;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            colorLabel.Background = new SolidColorBrush
            {
                Color = Color.FromArgb(
                    (byte)alphaSlider.Value,
                    (byte)redSlider.Value,
                    (byte)greenSlider.Value,
                    (byte)blueSlider.Value)
            };
        }
    }
}