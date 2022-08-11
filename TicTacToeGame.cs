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
            for(int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }

        //method for UC2
        public void Uc2()
        {
            char X = 'X';
            char O = 'O';

            Console.WriteLine("Enter either 'X' or 'O'");
            char input = Convert.ToChar(Console.ReadLine());

            if(input == X)
            {
                Console.WriteLine("{0} taken by user", input);
            }
            else if(input == 0)
            {
                Console.WriteLine("{0} taken by user", input);
            }
            else
            {
                Console.WriteLine("Enter Valid Input");
            }
            
        }
    }
}
