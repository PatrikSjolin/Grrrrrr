using System;

namespace Grrrrrr.Events
{
    public class Goal : Entity
    {
        public Goal()
        {
            Mesh = "@";
            Color = ConsoleColor.White;
            Intersectable = true;
        }
    }
}
