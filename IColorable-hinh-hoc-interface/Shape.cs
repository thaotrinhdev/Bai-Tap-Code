namespace Shape
{
    public class Shape : IColorable
    {
        private string color = "green";
        private bool filled = true;
        public Shape() { }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public bool IsFilled()
        {
            return filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public virtual string ToString()
        {
            return "A Shape with color of "
                + GetColor()
                + " and "
                + (IsFilled() ? "filled" : "not filled");
        }
        public void HowToColor()
        {
            if (filled)
                Console.WriteLine($"Color of shape is: {GetColor()}");
            else
            {
                Console.WriteLine("Color of shape is: nothing");
            }

        }
    }
}
