namespace TicTacToeBoardGame
{
    internal class Program
    {   
        //An entrypoint of consle app
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TacTacToe Board Game");

            TicTacToeGame ticTacToeObj = new TicTacToeGame(); //created object
            ticTacToeObj.Uc1(); //invoking Uc1method
            ticTacToeObj.Uc2(); //invoking Uc2method
        }
    }
}