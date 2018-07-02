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
    /// Interaction logic for SportWindow.xaml
    /// </summary>
    public partial class SportWindow : Window
    {
        DBModelContainer db = new DBModelContainer();
        public SportWindow()
        {
            InitializeComponent();
            
            comboBoxFirstSport.ItemsSource = db.Sports.Select(item => item.Name).ToList();
            comboBoxSecondSport.ItemsSource = db.Sports.Select(item => item.Name).ToList();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            //сброс
        }

        private void Return(object sender, RoutedEventArgs e)
        {
            // переход на прошлую форму
        }
    }
}
