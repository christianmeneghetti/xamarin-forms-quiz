using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String texto = eResposta.Text;
            if(texto == null)
            {
                DisplayAlert("A Esfinge fala:", "Seus miolos são apetitosos?", "Ok");
            }
            else
            {
                if (texto.ToUpper() == "HUNTER")
                {
                    Navigation.PushAsync(new Page2());
                }
                else
                {
                    DisplayAlert("A Esfinge fala:", "Seus miolos são apetitosos?", "Ok");
                }
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}