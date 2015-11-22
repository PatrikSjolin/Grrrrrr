using System;

namespace Grrrrrr
{
    public class Entity
    {
        public string Mesh = "@";
        public ConsoleColor Color { get; set; }
        public bool Intersectable { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
