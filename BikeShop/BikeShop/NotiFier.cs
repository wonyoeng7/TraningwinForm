using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BikeShop
{
    public class NotiFier : INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        protected void OnProprtyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                propertChanged(this. new propertycha)
            }
        }
    }

}
