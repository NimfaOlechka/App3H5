using System;
using System.Collections.Generic;
using System.Text;
using AndroidHelloApp.Models;

namespace AndroidHelloApp.ViewModels
{
    public class ContactDetailViewModel : BaseViewModel
    {
        public Contact Contact { get; set; }
        public ContactDetailViewModel(Contact contact = null)
        {
            Title = contact?.ContactName;
            Contact = contact;
        }
    }
}
