namespace Game
{
    class Computer_Player : Player
    {
        public Computer_Player(char mark)
        {
            Mark = mark;
        }
        public override void Move(Board board)
        {
            Random random = new Random();
            int col,row;
            do
            {
                row= random.Next(0,Game.Board.Board_W);
                col= random.Next(0,Game.Board.Board_H);
            }
            while (!board.PlaceMark(row,col,Mark));
        }
    }
}