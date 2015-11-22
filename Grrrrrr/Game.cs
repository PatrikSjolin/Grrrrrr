using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Grrrrrr
{
    public class Game : IGameState
    {
        private readonly Renderer renderer;
        private readonly Map map;

        public Game()
        {
            renderer = new Renderer();
            renderer.Entities = new List<Entity>();
            map = new Map();

            Console.CursorVisible = false;
        }

        public void Start()
        {
            Unit player = new Player
            {
                PositionY = map.PlayerStartY,
                PositionX = map.PlayerStartX
            };

            while (true)
            {
                ConsoleKeyInfo keyInfo;

                renderer.CameraX = player.PositionX;
                renderer.CameraY = player.PositionY;

                renderer.Entities.Clear();
                renderer.Entities.Add(player);
                renderer.Entities.AddRange(map.Entities);
                renderer.Interface = map.Interface;
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
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
