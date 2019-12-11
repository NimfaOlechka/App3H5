using MySMSApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MySMSApp.Services
{
    // class to create some dumb data for my app, also providing REST service
    public class ContactsData : IDataStore<ContactModel>
    {
        readonly List<ContactModel> contacts;

        public ContactsData()
        {
            contacts = new List<ContactModel>()
            {
                new ContactModel { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20202020", ContactName="Anna" },
                new ContactModel { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20342020", ContactName="Anton" },
                new ContactModel { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20452020", ContactName="Adam" },
                new ContactModel { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 67206720", ContactName="Brian" },
                new ContactModel { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20456720", ContactName="Peter" },
                new ContactModel { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20999920", ContactName="John" },
                new ContactModel { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 44442020", ContactName="Jakob" },
            };
        }

        public async Task<bool> AddItemAsync(ContactModel item)
        {
            contacts.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var contactToDelete = contacts.Where((ContactModel arg) => arg.Id == id).FirstOrDefault();
            contacts.Remove(contactToDelete);
            return await Task.FromResult(true);
        }

        public async Task<ContactModel> GetItemAsync(string id)
        {
            return await Task.FromResult(contacts.FirstOrDefault(c => c.Id == id));
        }

        public async Task<IEnumerable<ContactModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(contacts);
        }

        public async Task<bool> UpdateItemAsync(ContactModel item)
        {
            var oldContact = contacts.Where((ContactModel arg) => arg.Id == item.Id).FirstOrDefault();
            contacts.Remove(oldContact);
            contacts.Add(item);
            return await Task.FromResult(true);
        }
    }
}
