/*
* Author: Maria Traskowsky

* Class name: CornDodgers

* Purpose: Implements the Corn Dodgers side and inherits from the Side class
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the corn dodgers side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// the calories of the corn dodgers, depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the price of the corn dodgers side, depending on size
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
        /// <returns>The string describing the corn dodgers</returns>
        public override string ToString()
        {
            return Size + " " + "Corn Dodgers";
        }
    }
}
