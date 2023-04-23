using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class GameBoard
    {
        public static List<Game> game = new List<Game>();

        public static void CreateGame()
        {
            game.Clear();

            game.Add(new Game("", true));
            game.Add(new Game("", true));
            game.Add(new Game("", true));
            game.Add(new Game("", true));
            game.Add(new Game("", true));
            game.Add(new Game("", true));
            game.Add(new Game("", true));
            game.Add(new Game("", true));
            game.Add(new Game("", true));
        }

        public static void ShowBoard()
        {
            for (int i = 0; i < game.Count; i++)
            {
                if (game[i].Empty == true)
                {
                    Console.Write("___");
                }
                else
                {
                    Console.Write($"_{game[i].Space}_");
                }

                //space-ler arasinda | isaresi ucun
                if (i == 0 || i == 1 || i == 3
                    || i == 4 || i == 6 || i == 7)
                {
                    Console.Write("|");
                }

                //asagi setire dusmek ucun
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }
        }



    }
}
