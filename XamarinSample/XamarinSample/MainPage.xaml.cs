using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();

                var result = await scanner.Scan();

                if (result != null)
                    await DisplayAlert("Código", "Código lido: " + result.Text, "OK");
                else
                    await DisplayAlert("Erro", "Impossível ler código de barras!", "OK");

            }
            catch (Exception err)
            {
                await DisplayAlert("Erro", err.Message, "OK");
            }
        }
    }
}
