/*
* Author: Maria Traskowsky
* Class name: TexasTea
* Purpose: Implements the Texas tea drink and inherits from the Drink class
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the texas tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// the price of the texas tea, depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the calories of the tea, depending on tea and sweetener
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        if (sweet == false) return 5;
                        else return 10;

                    case Size.Medium:
                        if (sweet == false) return 11;
                        else return 22;

                    case Size.Large:
                        if (sweet == false) return 18;
                        else return 36;

                    default:
                        throw new NotImplementedException();
                }
            }
        }
       
        /// <summary>
        /// if the tea is sweet
        /// </summary>
        private bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        /// <summary>
        /// if the tea has lemon
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// special instructions for the preparation of the tea
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

        // to string needs to say either sweet or plain
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the texas tea</returns>
        public override string ToString()
        {
            if (sweet)
            { 
                return Size + " " + "Texas Sweet Tea";
            }
            else
            {
                return Size + " " + "Texas Plain Tea";
            }
        }
    }
}
