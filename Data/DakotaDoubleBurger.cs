/*
* Author: Maria Traskowsky

* Class name: AngryChicken

* Purpose: Implements the Dakota Double Burger Entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the dakota double burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// the price of the dakota double burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// the calories in the dakota double burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// if the double burger has a bun
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
        /// if the double burger has ketchup
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
        /// if the double burger has mustard
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
        /// if the double burger has a pickle
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
        /// if the double burger has cheese
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
        /// if the double burger has tomato
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get { return tomato; }
            set 
            { 
                tomato = value;
                NotifyPropertyChanged("Tomato");
            }
        }

        /// <summary>
        /// if the double burger has lettuce
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            { 
                lettuce = value;
                NotifyPropertyChanged("Lettuce");
            }
        }

        /// <summary>
        /// if the double burger has mayo
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get { return mayo; }
            set 
            { 
                mayo = value;
                NotifyPropertyChanged("Mayo");
            }
        }

        /// <summary>
        /// special instructins for the preparation of the double burger
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
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;

            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the dakota double burger</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
