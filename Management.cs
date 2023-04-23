using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Management
    {
        public static bool CheckIndex(int index)
        {
            bool result = false; //true return ederse oyuncu qazandi demekdir

            if (index == 0) result = CheckZero();
            if (index == 1) result = CheckOne();
            if (index == 2) result = CheckTwo();
            if (index == 3) result = CheckThree();
            if (index == 4) result = CheckFour();
            if (index == 5) result = CheckFive();
            if (index == 6) result = CheckSix();
            if (index == 7) result = CheckSeven();
            if (index == 8) result = CheckEight();

            return result;
        }

        static bool CheckZero()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[0].Space;

            if (letter == GameBoard.game[1].Space && letter == GameBoard.game[2].Space) result = true;
            if (letter == GameBoard.game[3].Space && letter == GameBoard.game[6].Space) result = true;
            if (letter == GameBoard.game[4].Space && letter == GameBoard.game[8].Space) result = true;

            return result;
        }
        static bool CheckOne()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[1].Space;

            if (letter == GameBoard.game[0].Space && letter == GameBoard.game[2].Space) result = true;
            if (letter == GameBoard.game[4].Space && letter == GameBoard.game[7].Space) result = true;

            return result;
        }
        static bool CheckTwo()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[2].Space;

            if (letter == GameBoard.game[0].Space && letter == GameBoard.game[1].Space) result = true;
            if (letter == GameBoard.game[4].Space && letter == GameBoard.game[6].Space) result = true;
            if (letter == GameBoard.game[5].Space && letter == GameBoard.game[8].Space) result = true;

            return result;
        }
        static bool CheckThree()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[3].Space;

            if (letter == GameBoard.game[0].Space && letter == GameBoard.game[6].Space) result = true;
            if (letter == GameBoard.game[4].Space && letter == GameBoard.game[5].Space) result = true;

            return result;
        }
        static bool CheckFour()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[4].Space;

            if (letter == GameBoard.game[0].Space && letter == GameBoard.game[8].Space) result = true;
            if (letter == GameBoard.game[1].Space && letter == GameBoard.game[7].Space) result = true;
            if (letter == GameBoard.game[2].Space && letter == GameBoard.game[6].Space) result = true;
            if (letter == GameBoard.game[3].Space && letter == GameBoard.game[5].Space) result = true;

            return result;
        }
        static bool CheckFive()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[5].Space;

            if (letter == GameBoard.game[3].Space && letter == GameBoard.game[4].Space) result = true;
            if (letter == GameBoard.game[2].Space && letter == GameBoard.game[8].Space) result = true;

            return result;
        }
        static bool CheckSix()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[6].Space;

            if (letter == GameBoard.game[0].Space && letter == GameBoard.game[3].Space) result = true;
            if (letter == GameBoard.game[2].Space && letter == GameBoard.game[4].Space) result = true;
            if (letter == GameBoard.game[7].Space && letter == GameBoard.game[8].Space) result = true;

            return result;
        }
        static bool CheckSeven()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[7].Space;

            if (letter == GameBoard.game[1].Space && letter == GameBoard.game[4].Space) result = true;
            if (letter == GameBoard.game[6].Space && letter == GameBoard.game[8].Space) result = true;

            return result;
        }
        static bool CheckEight()
        {
            bool result = false; //true return ederse oyuncu oyunu uddu demekdir
            string letter = GameBoard.game[8].Space;

            if (letter == GameBoard.game[6].Space && letter == GameBoard.game[7].Space) result = true;
            if (letter == GameBoard.game[0].Space && letter == GameBoard.game[4].Space) result = true;
            if (letter == GameBoard.game[2].Space && letter == GameBoard.game[5].Space) result = true;

            return result;
        }
    }
}
