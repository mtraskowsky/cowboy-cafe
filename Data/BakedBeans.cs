/*
* Author: Maria Traskowsky

* Class name: BakedBeans

* Purpose: Implements the Baked Beans side and inherits from the Side class
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the baked beans side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// the calories of the baked beans side, depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the price of the baked beans side, depending on size
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
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the baked beans</returns>
        public override string ToString()
        {
            return Size + " " + "Baked Beans";
        }
    }
}
