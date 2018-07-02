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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wsr_forms
{
    /// <summary>
    /// Interaction logic for ZodiakPushWindow.xaml
    /// </summary>
    public partial class ZodiakPushWindow : Window
    {
        public ZodiakPushWindow(Zodiak zodiak)
        {
            InitializeComponent();
            imageZodiak.Source = LoadImage(zodiak.Img);
            textZnak.Text = zodiak.Name;
        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation;
            Storyboard storyboard = new Storyboard();

            doubleAnimation = new DoubleAnimation(1.0, 0.0, new Duration(TimeSpan.FromSeconds(1)));
            doubleAnimation.Completed += DoubleAnimation_Completed;
            Storyboard.SetTargetName(doubleAnimation, this.Name);
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(Window.OpacityProperty));
            storyboard.Children.Add(doubleAnimation);

            storyboard.Begin(this);
        }

        public BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            BitmapImage img = new BitmapImage();
            using (System.IO.MemoryStream mem = new System.IO.MemoryStream(imageData))
            {
                mem.Position = 0;
                img.BeginInit();
                img.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.UriSource = null;
                img.StreamSource = mem;
                img.EndInit();
            }
            img.Freeze();
            return img;
        }
    }
}
