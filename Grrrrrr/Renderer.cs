using System;
using System.Collections.Generic;

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
