using System;

namespace GameOfWar1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Khalil","Deacom");
            while (!game.IsGameOver())
            {
                game.PlayTurn();
            }

            Console.Read();
        }
    }
}