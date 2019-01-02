using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Wasel.Model;
using Wasel.Services;

namespace Wasel.ViewModel
{
    class StoreItemType
    {
        public int ID { get; set; }
        public string TitleType { get; set; }
    }
    public class StoreItemViewModel : INotifyPropertyChanged
    {
        
        public StoreItemViewModel()
        {
            StoreItemService sr = new StoreItemService();
            _items = sr.GetAllStoreItems();

            GetItemType = new ObservableCollection<StoreItemType>
            {
                new StoreItemType
                {
                    TitleType="سباكة"
                },
                new StoreItemType
                {
                    TitleType="نجارة"
                },
                new StoreItemType
                {
                    TitleType="كهرباء"
                },
                new StoreItemType
                {
                    TitleType="بناء"
                },
                new StoreItemType
                {
                    TitleType="أخرى"
                },
            };
            

        

    }
        
        private List<StoreItem>_items;

        internal ObservableCollection<StoreItemType> GetItemType { get; set; }

        public List<StoreItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName=null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
