﻿
using Ejercicio1ProgMovil.Operaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1ProgMovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            App.Current.MainPage = new NavigationPage(this);
        }

        private async void suma_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(num1.Text) || (String.IsNullOrWhiteSpace(num2.Text)))
            {
                await this.DisplayAlert("Error", "Rellene los Campos", "Ok");
            }
            else
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resul = n1 + n2;
                await Navigation.PushAsync(new SumaResultado(resul.ToString()));

            }
        }

        private async void resta_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(num1.Text) || (String.IsNullOrWhiteSpace(num2.Text)))
            {
                await this.DisplayAlert("Error", "Rellene los Campos", "Ok");
            }
            else
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resul = n1 - n2;
                await Navigation.PushAsync(new RestaResultado(resul.ToString()));
            }
        }

        private async void producto_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(num1.Text) || (String.IsNullOrWhiteSpace(num2.Text)))
            {
                await this.DisplayAlert("Error", "Rellene los Campos", "Ok");
            }
            else
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resul = n1 * n2;
                await Navigation.PushAsync(new MultiplicacionResultado(resul.ToString()));
            }
        }

        private async void division_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(num1.Text) || (String.IsNullOrWhiteSpace(num2.Text)))
            {
                await this.DisplayAlert("Error", "Rellene los Campos", "Ok");
            }
            else
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resul = n1 / n2;
                await Navigation.PushAsync(new DivisionResultado(resul.ToString()));
            }
        }
    }
}
