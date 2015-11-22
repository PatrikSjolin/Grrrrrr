using System;

namespace Grrrrrr
{
    public class Door : Entity
    {
        public bool Locked { get; set; }

        public Door()
        {
            Mesh = "@";
            Color = ConsoleColor.Yellow;
            Intersectable = true;
        }
    }
}
