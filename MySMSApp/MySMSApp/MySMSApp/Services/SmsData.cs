using MySMSApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MySMSApp.Services
{
    public class SmsData : IDataStore<SmsModel>
    {
        //list to store all my sms
        readonly List<SmsModel> smsList;
        //collection of contacts to be connected with sms
        //public IDataStore<ContactModel> DataStore => DependencyService.Get<IDataStore<ContactModel>>();
        //public ObservableCollection<ContactModel> Contacts { get; set; }
        //command to load generated contacts 
        //public Command LoadContactsCommand { get; set; }
        public SmsData()
        {
            //Contacts = new ObservableCollection<ContactModel>();
           // LoadContactsCommand = new Command(async () => await ExecuteLoadContactsCommand());
            smsList = new List<SmsModel>() 
            { 
                new SmsModel{smsId = Guid.NewGuid().ToString(), contact = new ContactModel{Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20202020", ContactName="Anna"}, message = "hello buddy!" },
                new SmsModel{smsId = Guid.NewGuid().ToString(), contact = new ContactModel{Id = Guid.NewGuid().ToString(), PhoneNumber = "+45 20485220", ContactName="Adam"}, message = "Whats up?!" }
            };
        }
        public async Task<bool> AddItemAsync(SmsModel item)
        {
            smsList.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = smsList.Where((SmsModel arg) => arg.smsId == id).FirstOrDefault();
            smsList.Remove(oldItem);
            return await Task.FromResult(true);
        }

        public async Task<SmsModel> GetItemAsync(string id)
        {
            return await Task.FromResult(smsList.FirstOrDefault(c => c.smsId == id));
        }

        public async Task<IEnumerable<SmsModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(smsList);
        }

        public async Task<bool> UpdateItemAsync(SmsModel item)
        {
            var oldItem = smsList.Where((SmsModel arg) => arg.smsId == item.smsId).FirstOrDefault();
            smsList.Remove(oldItem);
            smsList.Add(item);
            return await Task.FromResult(true);
        }

        //async Task ExecuteLoadContactsCommand()
        //{
            
        //    try
        //    {
        //        Contacts.Clear();
        //        var items = DataStore.GetItemsAsync(true);
        //        foreach (var item in items)
        //        {
        //            Contacts.Add(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }
            
        //}
    }
}
