using Game;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.SetCursorPosition(0,5);
            Console.WriteLine("Welcome to TicTacToe!");
            Console.WriteLine("ThaoThaoThao");
            Console.SetCursorPosition(1,1);
            while (true)
            {
                GamePlay game = new GamePlay();
                game.Play();
            }
        }
    }
}