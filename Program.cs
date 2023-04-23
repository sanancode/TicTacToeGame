namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tTic Tac Toe Game\n");

            string newgame = "";
            do
            {
                Console.WriteLine("\nGo!...\n");
                GameBoard.CreateGame();
                GameBoard.ShowBoard();
                Run();

                Console.Write("\nAnother gane? (Yes/No):");
                newgame = Console.ReadLine();
            } while (newgame.ToLower() == "yes");

            Console.WriteLine("\n\tGame ended");
        }

        static void Run()
        {
            bool flag1 = true;
            bool flag2 = true;

            do
            {
                do
                {
                    //First gamer
                    Console.Write("\nFirst gamer: ");
                    int spaceindexfirst = int.Parse(Console.ReadLine());

                    if (GameBoard.game[spaceindexfirst - 1].Empty == true)
                    {
                        GameBoard.game[spaceindexfirst - 1].Space = "x";
                        GameBoard.game[spaceindexfirst - 1].Empty = false;
                        flag1 = false;
                        GameBoard.ShowBoard();

                        if (Management.CheckIndex(spaceindexfirst - 1))
                        {
                            Console.WriteLine("\nFirst gamer won...\n");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThere is already letter selected space...Try another one...\n");
                        flag1 = true;
                    }
                } while (flag1);


                if (check() == true)
                {
                    do
                    {
                        //Second gamer
                        Console.Write("\nSecond gamer: ");
                        int spaceindexsecond = int.Parse(Console.ReadLine());

                        if (GameBoard.game[spaceindexsecond - 1].Empty == true)
                        {
                            GameBoard.game[spaceindexsecond - 1].Space = "o";
                            GameBoard.game[spaceindexsecond - 1].Empty = false;
                            flag2 = false;
                            GameBoard.ShowBoard();

                            if (Management.CheckIndex(spaceindexsecond - 1))
                            {
                                Console.WriteLine("\nSecond gamer won...\n");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nThere is already letter selected space...Try another one...\n");
                            flag2 = true;
                        }
                    } while (flag2);
                }
            } while (check() == true);

            Console.WriteLine("\nNo one won...\n");
        }

        static bool check()
        {
            for (int i = 0; i < GameBoard.game.Count; i++)
            {
                if (GameBoard.game[i].Empty == true)
                {
                    return true;
                }
            }
            return false;
        }

    }
}