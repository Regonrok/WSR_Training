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

namespace Wsr_forms
{
    /// <summary>
    /// Interaction logic for ZodiaksWindow.xaml
    /// </summary>
    public partial class ZodiaksWindow : Window
    {
        DBModelContainer db = new DBModelContainer();
        List<ImageListOnMainForm> list;
        List<Zodiak> zodiaks = new List<Zodiak>();

        public ZodiaksWindow()
        {
            InitializeComponent();
            zodiaks = db.Zodiaks.ToList();
            list = new List<ImageListOnMainForm>();
            zodiaks.ForEach(item => list.Add(new ImageListOnMainForm() { ImagePath = LoadImage(item.Img) }));
            imageList.DataContext = list;

            imageList.SelectionChanged += ImageList_SelectionChanged;
        }

        private void ImageList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (imageList.SelectedIndex == -1)
            {
                return;
            }
            ZodiakPushWindow zodiakPushWindow = new ZodiakPushWindow(zodiaks[imageList.SelectedIndex]);
            imageCurentZodiak.Source = LoadImage(zodiaks[imageList.SelectedIndex].Img);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //возврат на прошлую форму
        }
    }
}
