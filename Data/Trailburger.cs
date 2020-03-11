/*
* Author: Maria Traskowsky

* Class name: Trailburger

* Purpose: Implements the Trail Burger Entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    ///  a class representing the trail burger entree
    /// </summary>
    public class TrailBurger : Entree
    {

        /// <summary>
        /// the price of the trail burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// the calories in the trail burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// if the burger has a bun
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set 
            { 
                bun = value;
                NotifyPropertyChanged("Bun");
            }
        }

        /// <summary>
        /// if the burger has ketchup
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get { return ketchup; }
            set 
            { 
                ketchup = value;
                NotifyPropertyChanged("Ketchup");
            }
        }

        /// <summary>
        /// if the burger has mustard
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get { return mustard; }
            set 
            { 
                mustard = value;
                NotifyPropertyChanged("Mustard");
            }
        }

        /// <summary>
        /// if the burger has a pickle
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set 
            { 
                pickle = value;
                NotifyPropertyChanged("Pickle");
            }
        }

        /// <summary>
        /// if the burger has cheese
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                NotifyPropertyChanged("Cheese");
            }
        }

        /// <summary>
        /// special instructins for the preparation of the burger
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");

                return instructions;

            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the trail burger</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
