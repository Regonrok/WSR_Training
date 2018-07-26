using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileViewForms
{
    #region Дополнительные классы
    public class PhotoOrImg
    {
        public Color Img { get; set; }
    }

    public class DataForTemperamentForm
    {
        public string TextQuestion { get; set; }
        public string ButtonText { get; set; }
        public Color ButtonColor { get; set; }
        public int Value { get; set; }
    }
    #endregion

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        List<DataForTemperamentForm> questions = new List<DataForTemperamentForm>()
        {
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 1", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 2", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 3", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 4", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 5", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 6", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 7", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 8", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 9", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 10", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 11", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 12", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 13", Value = 1},
            new DataForTemperamentForm() {ButtonColor = Color.White, ButtonText = "Никогда", TextQuestion = "вопрос 14", Value = 1}
        };

        List<string> sports = new List<string>()
        {
            "",
            "Бег",
            "Коньки",
            "Велоспорт",
            "Тенис",
            "Футбол",
            "Хокей"
        };

        public TabPage()
        {
            InitializeComponent();

            #region инициализация событий клика по Image в Zodiak

            zodiak1.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak2.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak3.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak4.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak5.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak6.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak7.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak8.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak9.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak10.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak11.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));
            zodiak12.GestureRecognizers.Add(new TapGestureRecognizer(OnClick));

            #endregion

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

            charakter.SelectedIndex = 0;
            temperament.SelectedIndex = 0;

            listViewTemperament.ItemsSource = questions;

            firstSportPicker.ItemsSource = sports;
            secondSportPicker.ItemsSource = sports;
        }

        private void OnClick(View arg1, object arg2)
        {
            Image img = arg1 as Image;
            mainImage.BackgroundColor = img.BackgroundColor;
        }

        #region События главной формы

        private void FirstNameBtnClick(object sender, EventArgs e)
        {
            if (firstNameField.IsEnabled == true)
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
                    temperamentImg.BackgroundColor = Color.Black;
                    break;
                case 1:
                    BackgroundColor = Color.Red;
                    temperamentImg.BackgroundColor = Color.Blue;
                    break;
                case 2:
                    BackgroundColor = Color.Green;
                    temperamentImg.BackgroundColor = Color.Yellow;
                    break;
                case 3:
                    BackgroundColor = Color.Yellow;
                    temperamentImg.BackgroundColor = Color.Green;
                    break;

            }
        }

        private void CharackterSelect(object sender, EventArgs e)
        {
            switch (charakter.SelectedIndex)
            {
                case 0:
                    charackterImg.BackgroundColor = Color.Salmon;
                    break;
                case 1:
                    charackterImg.BackgroundColor = Color.DarkGray;
                    break;
                case 2:
                    charackterImg.BackgroundColor = Color.ForestGreen;
                    break;
                case 3:
                    charackterImg.BackgroundColor = Color.Goldenrod;
                    break;
                case 4:
                    charackterImg.BackgroundColor = Color.HotPink;
                    break;
                case 5:
                    charackterImg.BackgroundColor = Color.Khaki;
                    break;
                case 6:
                    charackterImg.BackgroundColor = Color.Lavender;
                    break;
                case 7:
                    charackterImg.BackgroundColor = Color.Olive;
                    break;
            }
        }

        private void ListViewSelected(object sender, SelectedItemChangedEventArgs e)
        {
            photo.BackgroundColor = ((PhotoOrImg)listView.SelectedItem).Img;
        }

        #endregion

        // Клик по кнопке с вариантом ответа
        private void QuestionBtnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Grid parentG = button.ParentView as Grid;
            Label valueL = parentG.Children[0] as Label;

            switch (int.Parse(valueL.Text))
            {
                case 1:
                    valueL.Text = "2";
                    button.Text = "Иногда";
                    button.BackgroundColor = Color.Green;
                    break;
                case 2:
                    valueL.Text = "3";
                    button.Text = "Часто";
                    button.BackgroundColor = Color.Yellow;
                    break;
                case 3:
                    valueL.Text = "4";
                    button.Text = "Всегда";
                    button.BackgroundColor = Color.Red;
                    break;
                case 4:
                    valueL.Text = "1";
                    button.Text = "Никогда";
                    button.BackgroundColor = Color.White;
                    break;
            }
        }

        // сброс спорта
        private void ResetSportClick(object sender, EventArgs e)
        {
            firstSportPicker.SelectedIndex = 0;
            secondSportPicker.SelectedIndex = 0;
        }
    }


}