using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DeliveryFeira.View;

namespace DeliveryFeira
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Children.Add(new HomePage());
            this.Children.Add(new LoginPage());
            this.Children.Add(new VitrinePage());
        }
    }
}
