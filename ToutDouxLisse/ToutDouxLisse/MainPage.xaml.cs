using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToutDouxLisse
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            tacheService.Trier();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            tacheService.SupprimerMoinsPrio();
        }

        private async void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            var stackLayout = (StackLayout)sender;
            var tache = (Tache)stackLayout.BindingContext;

            await Navigation.PushAsync(new TachePage(tache));
        }
    }
}
