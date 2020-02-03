using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 433;                        // don't need a break because with return i exit the body of the method
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
                //if (Size == Size.Small) { }
                //else if (Size == Size.Medium) { }
                //else { }
            }
        }
        public override double Price => throw new NotImplementedException();
    }
}
