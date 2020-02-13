using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        public override bool Ice { get; set; } = false;

        public override double Price { get; }

        public override uint Calories { get; }

        public bool Decaf { get; set; }

        public bool RoomForCream { get; set; }

        public override List<string> SpecialInstructions { get; }

    }
}
