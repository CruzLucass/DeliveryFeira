using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeliveryFeira.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        List<String> produtos = new List<string>
        {
            "Morango", "Maçã", "Alface", "Tomate", "Queijo", "Rúcula", "Cenoura"
        };
        public HomePage()
        {
            InitializeComponent();

            btnFazerLogin.Clicked += (s, e) => Navigation.PushAsync(new LoginPage());
        }

    }
}