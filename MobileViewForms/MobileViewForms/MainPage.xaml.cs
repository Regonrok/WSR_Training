using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileViewForms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            charakter.ItemsSource = new List<string>() {
                "характер 1",
                "Характер 2",
                "Характер 3",
                "Характер 4",
                "Характер 5",
                "Характер 6",
                "Характер 7",
                "Характер 8"
            };

            temperament.ItemsSource = new List<string>()
            {
                "Темепрамент 1",
                "Темперамент 2",
                "Темперамент 3",
                "Темперамент 4"
            };

            listView.ItemsSource = new List<PhotoOrImg>()
            {
                new PhotoOrImg() {Img = Color.YellowGreen},
                new PhotoOrImg() {Img = Color.Gray},
                new PhotoOrImg() {Img = Color.Firebrick},
                new PhotoOrImg() {Img = Color.Orange},
                new PhotoOrImg() {Img = Color.DodgerBlue}
            };
		}

        private void FirstNameBtnClick(object sender, EventArgs e)
        {
            if(firstNameField.IsEnabled == true)
            {
                firstNameField.IsEnabled = false;
            }
            else
            {
                firstNameField.IsEnabled = true;
            }
        }

        private void LastNameBtnClick(object sender, EventArgs e)
        {
            if (lastNameField.IsEnabled == true)
            {
                lastNameField.IsEnabled = false;
            }
            else
            {
                lastNameField.IsEnabled = true;
            }
        }

        private void MiddleNameBtnClick(object sender, EventArgs e)
        {
            if (middleNameField.IsEnabled == true)
            {
                middleNameField.IsEnabled = false;
            }
            else
            {
                middleNameField.IsEnabled = true;
            }
        }

        private void TemperamentSelect(object sender, EventArgs e)
        {
            switch (temperament.SelectedIndex)
            {
                case 0:
                    BackgroundColor = Color.White;
                    break;
                case 1:
                    BackgroundColor = Color.Red;
                    break;
                case 2:
                    BackgroundColor = Color.Green;
                    break;
                case 3:
                    BackgroundColor = Color.Yellow;
                    break;

            }
        }

        private void CharackterSelect(object sender, EventArgs e)
        {
            //ничего
        }

        private void ListViewSelected(object sender, SelectedItemChangedEventArgs e)
        {
            photo.BackgroundColor = ((PhotoOrImg)listView.SelectedItem).Img;
        }
    }
}
