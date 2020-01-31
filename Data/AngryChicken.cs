using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// the price of the angry chicken dish
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// calories in the angry chicken dish
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool pickle = true; // backing variable
        /// <summary>
        /// If the entree should be served with a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// if the entree should be served with bread
        /// </summary>
        public bool Bread
        { get; set; } = true;

        /// <summary>
        /// special instructions for the preparation of the chicken
        /// </summary>
        public List <string>  SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
