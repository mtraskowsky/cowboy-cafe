/*
* Author: Maria Traskowsky

* Class name: PanDeCampo

* Purpose: Implements the Pan de Campo side and inherits from the Side class
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the pan de campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// the calories of the pan de campo side, depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the price of the pan de campo, depending on size
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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }



        /// <summary>
        /// special instructions for the preparation of the pan de campo
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the pan de campo</returns>
        public override string ToString()
        {
            return Size + " " + "Pan de Campo";
        }
    }
}
