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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            String texto = eResposta.Text;
            if (texto == null)
            {
                DisplayAlert("A Esfinge fala:", "Hummm, apetitoso.", "Ok");
            }
            else
            {
                if (texto.ToUpper() == "SETE")
                {
                    Navigation.PushAsync(new Page3());
                }
                else
                {
                    DisplayAlert("A Esfinge fala:", "Tem certeza que digitou da maneira correta?", "Ok");
                }
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}