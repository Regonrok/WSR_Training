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

namespace Wsr_forms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBModelContainer db = new DBModelContainer();
        List<ImageListOnMainForm> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<ImageListOnMainForm>();
            db.Photos.ToList().ForEach(item => list.Add(new ImageListOnMainForm() { ImagePath = LoadImage(item.Img) }));
            imageList.DataContext = list;

            firstName.Text = Session.CurentUser.FirstName;
            lastName.Text = Session.CurentUser.LastName;
            middleName.Text = Session.CurentUser.MiddleName;

            comboBoxTemperament.ItemsSource = db.Temperaments.Select(item => item.Name).ToList();
            comboBoxCharacter.ItemsSource = db.Characters.Select(item => item.Name).ToList();
            comboBoxTypeSportFirst.ItemsSource = db.Sports.Select(item => item.Name).ToList();
            comboBoxTypeSportSecond.ItemsSource = db.Sports.Select(item => item.Name).ToList();
            comboBoxZnak.ItemsSource = db.Zodiaks.Select(item => item.Name).ToList();

            profilePhoto.Source = LoadImage(Session.CurentUser.Photo.Img);

            comboBoxCharacter.SelectionChanged += ComboBoxCharacter_SelectionChanged;
            comboBoxTemperament.SelectionChanged += ComboBoxTemperament_SelectionChanged;
            comboBoxTypeSportFirst.SelectionChanged += ComboBoxTypeSportFirst_SelectionChanged;
            comboBoxTypeSportSecond.SelectionChanged += ComboBoxTypeSportSecond_SelectionChanged;
            comboBoxZnak.SelectionChanged += ComboBoxZnak_SelectionChanged;

            editFirstName.Click += EditFirstName_Click;
            editLastName.Click += EditLastName_Click;
            editMiddleName.Click += EditMiddleName_Click;
        }

        private void EditMiddleName_Click(object sender, RoutedEventArgs e)
        {
            middleName.IsEnabled = true;
        }

        private void EditLastName_Click(object sender, RoutedEventArgs e)
        {
            lastName.IsEnabled = true;
        }

        private void EditFirstName_Click(object sender, RoutedEventArgs e)
        {
            firstName.IsEnabled = true;
        }

        /// <summary>
        /// при смене знака зодиака
        /// </summary>
        private void ComboBoxZnak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxZnak.SelectedIndex == -1) return;
            znakPhoto.Source = LoadImage(db.Zodiaks.ToList()[comboBoxZnak.SelectedIndex].Img);
        }

        /// <summary>
        /// при смене второго вида спорта
        /// </summary>
        private void ComboBoxTypeSportSecond_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxTypeSportSecond.SelectedIndex == -1) return;
            typeSport2Photo.Source = LoadImage(db.Sports.ToList()[comboBoxTypeSportSecond.SelectedIndex].Img);
        }

        /// <summary>
        /// при смене первого вида спорта
        /// </summary>
        private void ComboBoxTypeSportFirst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxTypeSportFirst.SelectedIndex == -1) return;
            typeSport1Photo.Source = LoadImage(db.Sports.ToList()[comboBoxTypeSportFirst.SelectedIndex].Img);
        }

        /// <summary>
        /// при смене темперамента
        /// </summary>
        private void ComboBoxTemperament_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxTemperament.SelectedIndex == -1) return;
            switch (comboBoxTemperament.SelectedIndex)
            {
                case 0:
                    this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFDB6B6"));
                    break;
                case 1:
                    this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFAFDB6"));
                    break;
                case 2:
                    this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFB6FDB6"));
                    break;
                case 3:
                    this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFB6C6FD"));
                    break;
                default:
                    this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffffffff"));
                    break;
            }
            temperamentPhoto.Source = LoadImage(db.Sports.ToList()[comboBoxTemperament.SelectedIndex].Img);
        }

        /// <summary>
        /// при смене характера
        /// </summary>
        private void ComboBoxCharacter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxCharacter.SelectedIndex == -1) return;
            charakterPhoto.Source = LoadImage(db.Sports.ToList()[comboBoxCharacter.SelectedIndex].Img);
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
            // возврат на прошлую форму
        }
    }

    public class ImageListOnMainForm
    {
        public BitmapImage ImagePath { get; set; }
    }
}
