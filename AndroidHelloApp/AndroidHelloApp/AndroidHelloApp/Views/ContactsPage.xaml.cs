using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AndroidHelloApp.ViewModels;
using AndroidHelloApp.Models;
using AndroidHelloApp.Views;
using System.ComponentModel;

namespace AndroidHelloApp.Views
{
    [DesignTimeVisible(false)]
    public partial class ContactsPage : ContentPage
    {
        ContactsViewModel contactsViewModel;
        public ContactsPage()
        {
            InitializeComponent();
            BindingContext = contactsViewModel = new ContactsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (contactsViewModel.Contacts.Count == 0)
                contactsViewModel.LoadContactsCommand.Execute(null);
        }

        async void OnContactSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Contact;
            if (item == null)
                return;

            await Navigation.PushAsync(new ContactDetailPage(new ContactDetailViewModel(item)));

            // Manually deselect item.
            ContactsListView.SelectedItem = null;
        }

        async void AddContact_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewContactPage()));
        }
    }
}
