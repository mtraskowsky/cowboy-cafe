/*
* Author: Maria Traskowsky
* Class name: Drink
* Purpose: Implements abstract base class called Drink and defines various properties including Price, Calories, and SpecialInstructions
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// whether the drink has ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// special instructions for drinks
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// a method to handle the property changed notifications
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

        }
    }
}
