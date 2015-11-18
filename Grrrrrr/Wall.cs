using System;

namespace Grrrrrr
{
    public class Wall : Entity
    {
        public Wall()
        {
            Color = ConsoleColor.Red;
            Intersectable = false;
        }
    }
}
