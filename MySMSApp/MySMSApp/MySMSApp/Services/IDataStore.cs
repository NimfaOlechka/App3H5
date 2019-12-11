using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySMSApp.Services
{
    // interface presenting main functions like get, update, delete, get one...
    interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
