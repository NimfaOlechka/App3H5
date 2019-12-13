using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AndroidHelloApp.Models;
using AndroidHelloApp.ViewModels;

namespace AndroidHelloApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ContactDetailPage : ContentPage
    {
        ContactDetailViewModel viewModel;

        public ContactDetailPage(ContactDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ContactDetailPage()
        {
            InitializeComponent();

            var contact = new Contact
            {
                PhoneNumber = "+xx xxxxxxxx",
                ContactName = "Name Surname"
            };

            viewModel = new ContactDetailViewModel(contact);
            BindingContext = viewModel;
        }
    }
}