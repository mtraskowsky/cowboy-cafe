﻿/*
* Author: Maria Traskowsky

* Class name: PecosPulledPork

* Purpose: Implements the Peco's Pulled Prok Entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public override uint Calories
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
            get
            {
                return bread;
            }
            set
            {
                bread = value;
                NotifyPropertyChanged("Bread");
            }
        }      
        /// <summary>
        /// special instructions for the preparation of the pulled pork
        /// </summary>
        public override List <string> SpecialInstructions
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
        /// <returns>The string describing the pecos pulled pork</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
