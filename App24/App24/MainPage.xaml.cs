using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App24
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            double a = double.Parse(TbNumberA.Text);
            double b = double.Parse(TbNumberB.Text);
            double? S = null;

            if (a > b)
            {
                S = a * a - b;
            }
            else if (a == b)
            {
                S = -a;
            }
            else if (b != 0)
            {
                S = (a * b - 1) / b;
            }
            else
            {
                await DisplayAlert("Система", "Нельзя делить на ноль", "OK");
            }
            await DisplayAlert("Ответ", $"Ваш ответ {S}", "OK");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
