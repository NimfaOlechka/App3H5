using AndroidHelloApp.Models;
using AndroidHelloApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AndroidHelloApp.ViewModels
{
    public class ContactsViewModel: BaseViewModel
    {
        public ObservableCollection<Contact> Contacts { get; set; }
        public Command LoadContactsCommand { get; set; }
        public ContactsViewModel()
        {
            Title = "My Contacts";
            Contacts = new ObservableCollection<Contact>();
            LoadContactsCommand = new Command(async() =>{
                await ExecuteLoadContacts();
            });

            MessagingCenter.Subscribe<NewContactPage, Contact>(this, "AddContact", async (obj, contact) =>
            {
                var newContact = contact as Contact;
                Contacts.Add(newContact);
                await DataStoreContact.AddItemAsync(newContact);
            });
            
        }

        

        async Task ExecuteLoadContacts()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Contacts.Clear();
                var items = await DataStoreContact.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Contacts.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
