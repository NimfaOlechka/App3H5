using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MySMSApp.ViewModels
{
    class MainPageViewModel: INotifyPropertyChanged
    {
        public MainPageViewModel()
        {

        }

        //bool switchToggle = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool SwitchToggle
        {
            get => Preferences.Get("SwitchToggle", false);
            set
            {
                Preferences.Set(nameof(SwitchToggle), value);
                // every time note changes - model or view will be changed
                var args = new PropertyChangedEventArgs(nameof(SwitchToggle));

                PropertyChanged?.Invoke(this, args);
            }
        }
        public Command SendSmsCommand { get; }

        public async Task SendMessage(string message, string recipient)
        {
            try
            {
                var sms = new SmsMessage(message, recipient);
                await Sms.ComposeAsync(sms);
            }
            catch (FeatureNotSupportedException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Failed", "Sms sending is not supported on this device", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Niksen, virker ikke!", ex.Message, "OK");
            }
        }
    }
}
