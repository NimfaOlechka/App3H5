using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndroidHelloApp.Models;

namespace AndroidHelloApp.Services
{
    public class ContactDataStore : IDataStore<Contact>
    {
        readonly List<Contact> contacts;

        public ContactDataStore()
        {
            contacts = new List<Contact>()
            {
                new Contact { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20202020", ContactName="Anna" },
                new Contact { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20342020", ContactName="Anton" },
                new Contact { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20452020", ContactName="Adam" },
                new Contact { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 67206720", ContactName="Brian" },
                new Contact { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20456720", ContactName="Peter" },
                new Contact { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20999920", ContactName="John" },
                new Contact { Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 44442020", ContactName="Jakob" },
            };
        }
        public async Task<bool> AddItemAsync(Contact item)
        {
            contacts.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var contactToDelete = contacts.Where((Contact arg) => arg.Id == id).FirstOrDefault();
            contacts.Remove(contactToDelete);
            return await Task.FromResult(true);
        }

        public async Task<Contact> GetItemAsync(string id)
        {
            return await Task.FromResult(contacts.FirstOrDefault(c => c.Id == id));
        }

        public async Task<IEnumerable<Contact>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(contacts);
;        }

        public async Task<bool> UpdateItemAsync(Contact item)
        {
            var contactToDelete = contacts.Where((Contact arg) => arg.Id == item.Id).FirstOrDefault();
            contacts.Remove(contactToDelete);
            contacts.Add(item);
            return await Task.FromResult(true);
        }
    }
}
