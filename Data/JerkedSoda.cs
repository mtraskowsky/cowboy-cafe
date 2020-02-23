/*
* Author: Maria Traskowsky
* Class name: JerkedSoda
* Purpose: Implements the Jerked Soda drink and inherits from the Drink class
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the jerked soda
    /// </summary>
    public class JerkedSoda : Drink
    {
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
            set { flavor = value; }
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
            return Size + " " + Flavor + " " + "Jerked Soda";
        }
    }
}
