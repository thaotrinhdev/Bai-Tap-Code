class ComputerPlayer
{
    public char Mark { get; private set; }
    private Random random;

    public ComputerPlayer(char mark)
    {
        Mark = mark;
        random = new Random();
    }

    public void MakeMove(char[,] board)
    {
        int row, col;
        do
        {
            row = random.Next(0, 3);
            col = random.Next(0, 3);
        } while (board[row, col] != ' ');

        board[row, col] = Mark;
        Console.WriteLine($"Computer chose row {row}, column {col}");
    }
}