using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MySMSApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /*private async void SendSMS_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PhoneEntry.Text))
            {
                await SendMessage(MessageEntry.Text, PhoneEntry.Text);
            }
        }*/

       /* public async Task SendMessage(string message, string recipient)
        {
            try
            {
                var sms = new SmsMessage(message, recipient);
                await Sms.ComposeAsync(sms);
            }
            catch (FeatureNotSupportedException ex)
            {
                await DisplayAlert("Failed", "Sms sending is not supported on this device", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Niksen, virker ikke!", ex.Message, "OK");
            }
        }*/

      
        //private void BackgroundMode_Toggled(object sender, ToggledEventArgs e)
        //{
        //    if (BackgroundMode.IsToggled)
        //    {
        //        myCollectionView.BackgroundColor = Color.DarkBlue;

        //    } else
        //    {
        //        myCollectionView.BackgroundColor = Color.Beige;
        //    }
          
        //}
    }
}
