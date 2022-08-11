using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeBoardGame
{
    public class TicTacToeGame
    {   
        //method for UC1
        public void Uc1()
        {
            char[] board = new char[10];
            
            //loop to initalize space
            for(int i = 1; i<= 10; i++)
            {
                board[i] = ' ';
            }
        }
    }
}
