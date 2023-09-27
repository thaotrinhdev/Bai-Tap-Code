namespace Game
{
    class GamePlay
    {
        public Board board;
        public Player Human_Player;
        public Player Computer_Player;
        public int numberOfPlays;
        public char currentPlayerMark;
        public GamePlay()
        {
            board = new Board();
            Human_Player = new Human_Player('X');
            Computer_Player = new Computer_Player('O');
            numberOfPlays = 0;
            currentPlayerMark = 'X';
        }
        public void Play()
        {
            do
            {
                if (currentPlayerMark == 'X')
                {
                    Human_Player.Move(board);
                }
                else
                {
                    Computer_Player.Move(board);
                }
                currentPlayerMark = (currentPlayerMark == 'X') ? '0' : 'X';
                numberOfPlays++;

                char winner = board.CheckStatus();
                if (winner != ' ' || numberOfPlays == 4)
                {
                    if (winner != ' ')
                    {
                        Console.WriteLine($"Player {winner} wins!");
                    }
                    break;
                }

            }
            while (true);
        }
    }
}