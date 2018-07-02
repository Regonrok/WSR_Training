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
    /// Interaction logic for TemperamentForm.xaml
    /// </summary>
    public partial class TemperamentForm : Window
    {
        public TemperamentForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "state1":
                    state2.Background = Brushes.Green;
                    state3.Background = Brushes.Yellow;
                    state4.Background = Brushes.Red;
                    button.Background = Brushes.Green;
                    break;
                case "state2":
                    state1.Background = Brushes.White;
                    state3.Background = Brushes.Yellow;
                    state4.Background = Brushes.Red;
                    button.Background = Brushes.Yellow;
                    break;
                case "state3":
                    state1.Background = Brushes.White;
                    state2.Background = Brushes.Green;
                    state4.Background = Brushes.Red;
                    button.Background = Brushes.Red;
                    break;
                case "state4":
                    state1.Background = Brushes.White;
                    state2.Background = Brushes.Green;
                    state3.Background = Brushes.Yellow;
                    button.Background = Brushes.White;
                    break;
                case "state5":
                    //переход на форму
                    break;
            }
        }
    }
}
