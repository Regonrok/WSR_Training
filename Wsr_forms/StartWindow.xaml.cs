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
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        DBModelContainer db = new DBModelContainer();
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pass.Password == "" || login.Text == "")
            {
                MessageBox.Show("Ошибка, пустые поля");
                return;
            }
            if(db.Users.Where(f => f.Login == login.Text && f.Password == pass.Password).Count() == 0)
            {
                MessageBox.Show("Ошибка логина/пароля");
                return;
            }
            Session.CurentUser = db.Users.Where(f => f.Login == login.Text && f.Password == pass.Password).First();
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
