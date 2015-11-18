using System.Linq;

namespace Grrrrrr
{
    public class Unit : Entity
    {
        public void Move(int X, int Y, Map map)
        {
            if(!(map.Walls.FirstOrDefault(x => x.PositionX == PositionX + X && x.PositionY == PositionY + Y) != null))
            {
                PositionX += X;
                PositionY += Y;
            }
        }
    }
}
