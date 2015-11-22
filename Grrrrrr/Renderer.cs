using System;
using System.Collections.Generic;

namespace Grrrrrr
{
    public class Renderer
    {
        public List<Entity> Entities { get; set; }

        public string Interface { get; set; }

        public int CameraX { get; set; }

        public int CameraY { get; set; }

        public void RenderScene()
        {
            Console.Clear();

            int width = Console.WindowWidth / 2;
            int height = Console.WindowHeight / 2;

            foreach(Entity entity in Entities)
            {
                Console.SetCursorPosition(entity.PositionX + width - CameraX, entity.PositionY + height - CameraY);
                Console.ForegroundColor = entity.Color;
                Console.Write(entity.Mesh);
            }

            Console.Write(Interface);
        }
    }
}
