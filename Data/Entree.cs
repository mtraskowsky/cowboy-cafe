/*
* Author: Maria Traskowsky

* Class name: Entree

* Purpose: Implements abstract base class called Entree and defines various properties including Price, Calories, and SpecialInstructions
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    ///  a base class representing an entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// get the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// get the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// get the special instructions to go with the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get;  }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

        }

    }
}
