using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

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
    }
}
