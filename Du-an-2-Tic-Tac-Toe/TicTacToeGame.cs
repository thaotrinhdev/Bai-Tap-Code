class TicTacToeGame
{
    public const int Board_W = 3;
    public const int Board_H = 3;
    private char[,] board;
    private char currentPlayer;
    private int moves;
    private HumanPlayer humanPlayer;
    private ComputerPlayer computerPlayer;

    public TicTacToeGame()
    {
        board = new char[Board_W, Board_H];
        currentPlayer = 'X';
        moves = 0;
        InitializeBoard();
        humanPlayer = new HumanPlayer('X');
        computerPlayer = new ComputerPlayer('O');
    }

    private void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    public char Play()
    {
        char winner = ' ';
        do
        {
            DrawBoard();
            if (currentPlayer == 'X')
                humanPlayer.MakeMove(board);
            else
                computerPlayer.MakeMove(board);

            moves++;

            winner = CheckForWinner();
            if (winner != ' ')
            {
                DrawBoard();
                if (winner == 'O')
                    Console.WriteLine("Computer wins!");
                else
                    Console.WriteLine("Player X wins!");
                break;
            }

            if (moves == 9)
            {
                DrawBoard();
                Console.WriteLine("It's a draw!");
                break;
            }

            SwitchPlayer();
        } while (true);

        return winner;
    }

    private void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2)
                    Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2)
                Console.WriteLine("  -+-+-");
        }
    }

    private void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    private char CheckForWinner()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                return board[i, 0];
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                return board[0, i];
        }

        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            return board[0, 0];
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            return board[0, 2];

        return ' ';
    }
}