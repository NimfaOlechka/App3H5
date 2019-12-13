using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using AndroidHelloApp.Views;

namespace AndroidHelloApp.ViewModels
{
    class StylePageController : INotifyPropertyChanged
    {
        public StylePageController()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public bool BackgroundToggle
        {
            get => Preferences.Get("BackgroundToggle", false);
            set
            {
                Preferences.Set(nameof(BackgroundToggle), value);
                // every time note changes - model or view will be changed
                var args = new PropertyChangedEventArgs(nameof(BackgroundToggle));

                PropertyChanged?.Invoke(this, args);
            }
        }

        
    }
}
