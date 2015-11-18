using System;
using System.Collections.Generic;

namespace Grrrrrr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Renderer renderer = new Renderer();
            Map map = new Map();
            Unit player = new Player
            {
                PositionY = 10,
                PositionX = 10
            };
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                renderer.Entities = new List<Entity>();
                renderer.Entities.Add(player);
                renderer.Entities.AddRange(map.Entities);
                renderer.RenderScene();

                while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            player.Move(0, -1, map);
                            break;
                        case ConsoleKey.DownArrow:
                            player.Move(0, 1, map);
                            break;
                        case ConsoleKey.LeftArrow:
                            player.Move(-1, 0, map);
                            break;
                        case ConsoleKey.RightArrow:
                            player.Move(1, 0, map);
                            break;
                    }
                    break;
                }
            }
        }
    }
}