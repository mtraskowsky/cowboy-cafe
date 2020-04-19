using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of the order item
        /// </summary>
        uint Calories { get; }


        /// <summary>
        /// The special instruciotns for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
