/*
* Author: Maria Traskowsky
* Class name: Drink
* Purpose: Implements abstract base class called Drink and defines various properties including Price, Calories, and SpecialInstructions
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// the size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

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
    }
}
