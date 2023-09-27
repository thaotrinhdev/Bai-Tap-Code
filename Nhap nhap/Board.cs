namespace Game
{
    class Board
    {
        public const int Board_W = 3;
        public const int Board_H = 3;
        private char[,] cell;
        public Board()
        {
            cell = new char[Board_W, Board_H];
            InitializeBoard();
        }
        public void InitializeBoard()
        {
            for (int i = 0; i < Board_W; i++)
            {
                for (int j = 0; j < Board_H; j++)
                {
                    cell[i, j] = ' ';
                }
            }
        }

        public bool Isfull()
        {
            foreach (var cells in cell)
            {
                if (cells == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        public bool PlaceMark(int row, int col, char mark)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2 || cell[row, col] != ' ')
            {
                return false;
            }
            else
            {
                cell[row, col] = mark;
            }
            return true;
        }
        public char CheckStatus()
        {
            for (int i = 0; i < 3; i++)
            {
                if (cell[i, 0] == cell[i, 1] && cell[i, 1] == cell[i, 2] && cell[i, 0] != ' ')
                    return cell[i, 0];
                if (cell[0, i] == cell[1, i] && cell[1, i] == cell[2, i] && cell[0, i] != ' ')
                    return cell[0, i];
            }

            if (cell[0, 0] == cell[1, 1] && cell[1, 1] == cell[2, 2] && cell[0, 0] != ' ')
                return cell[0, 0];
            if (cell[0, 2] == cell[1, 1] && cell[1, 1] == cell[2, 0] && cell[0, 2] != ' ')
                return cell[0, 2];

            return ' ';
        }


    }
}