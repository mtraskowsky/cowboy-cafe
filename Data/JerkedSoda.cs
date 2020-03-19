/*
* Author: Maria Traskowsky
* Class name: JerkedSoda
* Purpose: Implements the Jerked Soda drink and inherits from the Drink class
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the jerked soda
    /// </summary>
    public class JerkedSoda : Drink, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the price of the jerked soda, depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the calories of the jerked soda, depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the flavor of the soda
        /// </summary>
        private SodaFlavor flavor;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SodaFlavor"));
            }
        }

        /// <summary>
        /// special instructions for the preparation of the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the jerked soda</returns>
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    return Size + " " + "Cream Soda" + " " + "Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size + " " + "Orange Soda" + " " + "Jerked Soda";
                case SodaFlavor.BirchBeer:
                    return Size + " " + "Birch Beer" + " " + "Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size + " " + "Root Beer" + " " + "Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size + " " + "Sarsparilla" + " " + "Jerked Soda";
                default:
                    return Size + " " + "Jerked Soda";

            }
        }
    }
}
