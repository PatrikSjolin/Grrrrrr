using System.Linq;

namespace Grrrrrr
{
    public class Unit : Entity
    {
        public virtual void Move(int X, int Y, Map map)
        {
            if(!map.Entities.Any(x => x.PositionX == PositionX + X && x.PositionY == PositionY + Y && x.Intersectable == false))
            {
                PositionX += X;
                PositionY += Y;
            }
        }
    }
}
