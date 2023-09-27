namespace Game
{
    class Human_Player : Player
    {
        public Human_Player(char mark)
        {
            Mark = mark;
        }
        public override void Move(Board board)
        {
            var (Left, Top) = Console.GetCursorPosition();
            GamePlay game= new GamePlay();

            do
            {
                ConsoleKey[] allowedKeys = { ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.DownArrow, ConsoleKey.UpArrow, ConsoleKey.Enter };
                var keyInfo = Console.ReadKey(true);
                if (allowedKeys.Contains(keyInfo.Key))
                {
                    {
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.LeftArrow:
                                if (Left == 0)
                                {
                                    Move(board);
                                    break;
                                }
                                else
                                {
                                    Console.SetCursorPosition(Left - 1, Top);
                                }
                                Move(board);
                                break;
                            case ConsoleKey.RightArrow:
                                if (Left == 2)
                                {
                                    Move(board);
                                    break;
                                }
                                else
                                {
                                    Console.SetCursorPosition(Left + 1, Top);
                                }
                                Move(board);
                                break;
                            case ConsoleKey.UpArrow:
                                if (Top == 0)
                                {
                                    Move(board);
                                    break;
                                }
                                else
                                {
                                    Console.SetCursorPosition(Left, Top - 1);
                                }
                                Move(board);
                                break;
                            case ConsoleKey.DownArrow:
                                if (Top == 2)
                                {
                                    Move(board);
                                    break;
                                }
                                else
                                {
                                    Console.SetCursorPosition(Left, Top + 1);
                                }
                                Move(board);
                                break;
                            default:
                                game.Play();
                                break;

                        }

                    }

                }
            }
            while (!board.PlaceMark(Left, Top, Mark));
        }
    }
}


