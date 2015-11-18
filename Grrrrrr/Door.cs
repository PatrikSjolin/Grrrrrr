using System;

namespace Grrrrrr
{
    public class Door : Entity
    {
        public bool Locked { get; set; }
        public Door()
        {
            Color = ConsoleColor.Yellow;
            Intersectable = true;
        }
    }
}
