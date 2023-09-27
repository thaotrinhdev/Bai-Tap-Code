namespace Game
{
    abstract class Player
    {
        public char Mark {get; set;}
        public abstract void Move(Board board);
    }
}