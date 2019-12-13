using System;
using System.Collections.Generic;
using System.Text;

namespace AndroidHelloApp.Models
{
    public enum MenuItemType
    {
        Browse,
        SendSMS,
        Contacts,
        Light,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
