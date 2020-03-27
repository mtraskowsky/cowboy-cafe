/*
* Author: Maria Traskowsky
* Class name: Water
* Purpose: Implements the Water drink and inherits from the Drink class
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// the price of the water, depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the calories of the water, depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// if the water has lemon
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { 
                lemon = value;
                NotifyPropertyChanged("Lemon");
            }
        }

        /// <summary>
        /// whether the water has ice
        /// </summary>
        private bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyPropertyChanged("Ice");
            }
        }

        /// <summary>
        /// special instructions for water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
        
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the water</returns>
        public override string ToString()
        {
            return Size + " " + "Water";
        }
    }
}
