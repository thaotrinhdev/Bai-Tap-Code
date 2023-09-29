class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to TicTacToe!");

        // Khởi tạo quản lý điểm số
        ScoreManager scoreManager = new ScoreManager();
        scoreManager.LoadScoresFromFile("scores.csv");

        do
        {
            // Khởi tạo game
            TicTacToeGame game = new TicTacToeGame();

            // Chơi game
            char winner = game.Play();

            // Cập nhật điểm số
            if (winner == 'X')
                scoreManager.UpdateScores(0, 1);
            else if (winner == 'O')
                scoreManager.UpdateScores(1, 0);

            // Hiển thị điểm số
            scoreManager.DisplayScores();

            // Lưu điểm số vào tệp CSV
            scoreManager.SaveScoresToFile("scores.csv");

            // Hỏi người chơi có muốn chơi lại không
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "yes")
                break;

        } while (true);
    }
}

