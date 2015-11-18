using System;
using System.Collections.Generic;

namespace Grrrrrr
{
    public class Player : Unit
    {
        public List<Item> Inventory { get; set; }

        public Player()
        {
            Color = ConsoleColor.Green;
        }
    }
}
