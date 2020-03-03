using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        private static uint lastOrderNumber = 0;

        public List<IOrderItem> items = new List<IOrderItem>(); 

//        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();
        public IEnumerable<IOrderItem> Items => items.ToArray();

        private double subtotal;
        // need to notify the property changed event (PropertyChanged?.Invoke) when subtotal changes
        public double Subtotal
        {
            
            get
            {
                return subtotal;
            }
            set
            {
                subtotal = value;
            }
        }

    // order number never changes
    public uint OrderNumber {
            get
            {
                return lastOrderNumber;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {
            subtotal += item.Price;
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item)
        {
            subtotal -= item.Price;
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public Order()
        {
            lastOrderNumber += 1;
        }
    }
}
