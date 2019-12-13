using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidHelloApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SmsPage : ContentPage
    {
        public SmsPage()        
        {            
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                var message = new SmsMessage(EntryMessage.Text, EntryNumber.Text);
                await Sms.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException ex)
            {
                // SMS not supported on this device
            }
            catch (Exception ex)
            {
                // Other errors
            }
            
        }
    }
    

}