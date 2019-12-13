using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AndroidHelloApp.Models;

namespace AndroidHelloApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewContactPage : ContentPage
    {
        public Contact Contact { get; set; }

        public NewContactPage()
        {
            InitializeComponent();

            Contact = new Contact
            {
                PhoneNumber = "+ xxxxxxxx",
                ContactName = "Name Surname"
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddContact", Contact);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}