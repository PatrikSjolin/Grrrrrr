using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grrrrrr
{
    public class Renderer
    {
        public List<Entity> Entities { get; set; }

        public void RenderScene()
        {
            Console.Clear();
            foreach(Entity entity in Entities)
            {
                Console.SetCursorPosition(entity.PositionX, entity.PositionY);
                Console.ForegroundColor = entity.Color;
                Console.Write("@");
            }
        }
    }
}
