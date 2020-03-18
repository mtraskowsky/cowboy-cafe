using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        /// <summary>
        /// a variable to track changes in the order number
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// List of items in the order
        /// </summary>
        public List<IOrderItem> items = new List<IOrderItem>(); 

        /// <summary>
        /// IEnumberable list of items 
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// private backing variable for subtotal method
        /// </summary>
        private double subtotal;
        /// <summary>
        /// gets and sets the subtotal of the items in the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                
                foreach(IOrderItem item in items)
                {
                    total += item.Price;
                }

                return total;
            }
            private set { subtotal = value; }
        }

        /// <summary>
        /// tracks the order number
        /// </summary>
        public uint OrderNumber {
                get
                {
                    return lastOrderNumber;
                }
            }

        /// <summary>
        /// PropertyChanged helps us track changing values when we use data binding
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds an order to the list of items, updates subtotal, and communicates with PropertyChanged
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Removes an order from the list of items, updates subtotal, and communicates with PropertyChanged
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Updates the order number when a new instance of Order() is created
        /// </summary>
        public Order()
        {
            lastOrderNumber += 1;
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        public void notifyPropChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }


    }
}
