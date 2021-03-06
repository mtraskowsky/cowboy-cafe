﻿/*
* Author: Maria Traskowsky

* Class name: AngryChicken

* Purpose: Implements the Angry Chicken Entree
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree
    {
        /// <summary>
        /// the price of the angry chicken dish
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// calories in the angry chicken dish
        /// </summary>
        public override uint Calories
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
            set
            {
                pickle = value;
                NotifyPropertyChanged("Pickle");
            }
        }

        private bool bread = true;
        /// <summary>
        /// if the entree should be served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                NotifyPropertyChanged("Bread");
                //NotifyPropertyChanged("SpecialInstructions"); I do this in the NotifyPropertyChanged method 
            }
        }
        /// <summary>
        /// special instructions for the preparation of the chicken
        /// </summary>
        public override List <string>  SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the angry chicken</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
