using System;

namespace Grrrrrr
{
    public class Menu : IGameState
    {
        public void Start()
        {
            string startMessage = "Press any key to enter game...";

            Console.SetCursorPosition((Console.WindowWidth - startMessage.Length) / 2, Console.WindowHeight / 2);
            Console.Write(startMessage);
            Console.ReadKey();

            new Game().Start();
        }
    }
}
