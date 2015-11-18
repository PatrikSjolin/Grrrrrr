using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grrrrrr
{
    public class Player : Unit
    {
        public int HitPoints { get; set; }

        public List<Item> Inventory { get; set; }

        public Player()
        {
            Color = ConsoleColor.Green;
        }
    }
}
