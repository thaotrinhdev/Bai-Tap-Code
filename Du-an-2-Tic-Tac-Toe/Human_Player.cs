class HumanPlayer
{
    public char Mark { get; private set; }
    private int row;
    private int col;

    public HumanPlayer(char mark)
    {
        Mark = mark;
    }

    public void MakeMove(char[,] board)
    {
        do
        {
            DrawBoard(board);
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (col > 0)
                        col--;
                    break;
                case ConsoleKey.RightArrow:
                    if (col < 2)
                        col++;
                    break;
                case ConsoleKey.UpArrow:
                    if (row > 0)
                        row--;
                    break;
                case ConsoleKey.DownArrow:
                    if (row < 2)
                        row++;
                    break;
                case ConsoleKey.Enter:
                    if (board[row, col] == ' ')
                    {
                        board[row, col] = Mark;
                        return;
                    }
                    break;
            }

            // Di chuyển con trỏ nhập liệu đến vị trí mới
            Console.SetCursorPosition(2 * col, 2 * row);

        } while (true);
    }

    private void DrawBoard(char[,] board)
    {
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == row && j == col)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(board[i, j]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(board[i, j]);
                }

                if (j < 2)
                    Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2)
                Console.WriteLine("-----");
        }
    }
}
