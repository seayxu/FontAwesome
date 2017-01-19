using System;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FontAwesomeNet.Wpf.Sample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] names = FontAwesome.TypeDict.Select(v => v.Key).ToArray();
            this.CmbFontAwesomeType.ItemsSource = names;
            string[] colorNames = Enum.GetNames(typeof(KnownColor));
            this.CmbForeColor.ItemsSource = colorNames;
            this.CmbBackColor.ItemsSource = colorNames;
            this.CmbBorderColor.ItemsSource = colorNames;
            this.CmbFontAwesomeType.SelectedIndex = 0; this.LabelSize.Content = ((int)this.Slider1.Value).ToString();
        }

        private void cmbFontAwesomeType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.CmbFontAwesomeType.SelectedIndex < 0)
            {
                return;
            }
            FontAwesome.IconSize = (int)this.Slider1.Value;
            if (this.CmbBackColor.SelectedIndex > -1)
            {
                FontAwesome.BackColer = System.Drawing.Color.FromName(this.CmbBackColor.SelectedItem.ToString());
            }
            if (this.CmbBorderColor.SelectedIndex > -1)
            {
                FontAwesome.BorderColer = System.Drawing.Color.FromName(this.CmbBorderColor.SelectedItem.ToString());
            }
            if (this.CmbForeColor.SelectedIndex > -1)
            {
                FontAwesome.ForeColer = System.Drawing.Color.FromName(this.CmbForeColor.SelectedItem.ToString());
            }
            FontAwesome.BorderVisible = this.CbShowBorder.IsChecked == true;

            int val = FontAwesome.TypeDict[this.CmbFontAwesomeType.SelectedItem.ToString()];
            Bitmap bmp = FontAwesome.GetImage(val);//f188

            ImageSource imgs = ToImageSource(bmp);
            this.Image.Background = new ImageBrush()
            {
                ImageSource = imgs,
                Stretch = Stretch.None
            };
        }

        public ImageSource ToImageSource(Bitmap bitmap)
        {
            IntPtr hBitmap = bitmap.GetHbitmap();
            ImageSource bitmapSource =
            Imaging.CreateBitmapSourceFromHBitmap(
            hBitmap, IntPtr.Zero, Int32Rect.Empty,
            BitmapSizeOptions.FromEmptyOptions());
            return bitmapSource;
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.LabelSize!=null)
            {
                this.LabelSize.Content = ((int)this.Slider1.Value).ToString();
            }
        }
    }
}
