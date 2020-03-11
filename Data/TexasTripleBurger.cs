/*
* Author: Maria Traskowsky

* Class name: TexasTripleBurger

* Purpose: Implements the Texas Triple Burger Entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the texas triple burger
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// the price of the texas triple burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }
        
        /// <summary>
        /// the calories in the texas triple burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// if the texas triple burger has a bun
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
        /// if the texas triple burger has ketchup
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
        /// if the texas triple burger has mustard
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
        /// if the texas triple burger has a pickle
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
        /// if the texas triple burger has cheese
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
        /// if the texas triple burger has tomato
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
        /// if the texas triple burger has lettuce
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
        /// if the texas triple burger has mayo
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

        private bool bacon = true;
        /// <summary>
        /// if the texas triple burger has bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set 
            { 
                bacon = value;
                NotifyPropertyChanged("Bacon");
            }
        }

        private bool egg = true;
        /// <summary>
        /// if the texas triple burger has an egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set 
            { 
                egg = value;
                NotifyPropertyChanged("Egg");
            }
        }

        /// <summary>
        /// special instructins for the preparation of the texas triple burger
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
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;

            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the texas triple burger</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
