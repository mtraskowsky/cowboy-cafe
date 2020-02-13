using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        public virtual Size Size { get; set; } = Size.Small;

        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public virtual bool Ice { get; set; } = true;

        public abstract List<string> SpecialInstructions { get; }
    }
}
