using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
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


        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        if (sweet == false)
                        {
                            return 5;
                        }
                        else
                        {
                            return 10;
                        }
                    case Size.Medium:
                        if (sweet == false)
                        {
                            return 11;
                        }
                        else
                        {
                            return 22;
                        }
                    case Size.Large:
                        if (sweet == false)
                        {
                            return 18;
                        }
                        else
                        {
                            return 36;
                        }
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        public override List<string> SpecialInstructions { get; }
    }
}
