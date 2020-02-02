using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        private bool pickle = true;
        /// <summary>
        /// if the entree should be served with a pickle
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
        /// special instructions for the preparation of the pulled pork
        /// </summary>
        public List <string> SpecialInstructions
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
