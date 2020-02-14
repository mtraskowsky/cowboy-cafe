/*
* Author: Maria Traskowsky
* Class name: CowboyCoffee
* Purpose: Implements the Cowboy Coffee drink and inherits from the Drink class
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing cowboy coffee
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// whether the coffee has ice
        /// </summary>
        private bool ice = false;
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// the price of the coffee, depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the calories in the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// whether the coffee is decaf or not
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// if the coffee will have room for cream or not
        /// </summary>
        private bool roomforcream = false;
        public bool RoomForCream
        {
            get { return roomforcream; }
            set { roomforcream = value; }
        }

        /// <summary>
        /// special instructions for the preparation of the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (roomforcream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

    }
}
