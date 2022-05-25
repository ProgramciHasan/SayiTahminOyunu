using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SayiTahminOyunu.Views;

namespace SayiTahminOyunu
{
    public partial class MainPage : ContentPage
    {
        Random random = new Random();
        public int hedefsayi = 0;
        int kalanHakki = 10;


        public MainPage()
        {
            InitializeComponent();

            hedefsayi = random.Next(100);
            int tempSayi = random.Next(100);
            if (tempSayi > hedefsayi)
            {
                boxView.BackgroundColor = Color.OrangeRed;
                durum.Text = "Sayı Büyük";

            }
            else
            {
                boxView.BackgroundColor = Color.CornflowerBlue;
                durum.Text = "Sayı Küçük";

            }
            entrySayi.Text = tempSayi.ToString();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (kalanHakki == 0)
            {
                
                
                await Navigation.PushAsync(new LoserPage());
            }
            {

            }
            int sayi = int.Parse(entrySayi.Text);

            if (sayi==hedefsayi)
            {
                await Navigation.PushAsync(new WinnerPage());
            }

            if (sayi>hedefsayi)
            {
                boxView.BackgroundColor = Color.OrangeRed;
                durum.Text = "Sayı Büyük";

            }
            else
            {
                boxView.BackgroundColor = Color.CornflowerBlue;
                durum.Text = "Sayı Küçük";


            }
            kalanHakki -= 1;
            lblMask.Text = kalanHakki.ToString();





        }
    }
}
