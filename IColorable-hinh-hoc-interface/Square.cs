
namespace Shape
{
    public class Square : Rectangle

    {
        
        private double side = 3.1;
        public Square(){}

        public Square(double side) : base(side, side)
        {
            base.SetColor("Pink");
        }

        public Square(double side, String color, bool filled) : base(side, side, color, filled)
        {
           base.SetColor(color);

        }
        public double GetSide()
        {
            return GetWidth();
        }

        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }

        public override void SetWidth(double width)
        {
            SetSide(width);
        }

        public override void SetLength(double length)
        {
            SetSide(length);
        }

        public override String ToString()
        {
            return "A Square with side="
            + GetSide()
            + ", which is a subclass of "
            + base.ToString();

        }
        public void Resize(double percent)
        {
            percent = Math.Clamp(percent,1,100);
            side *= percent/100;

        }
        public void HowToColor()
        {
            if (IsFilled())
                Console.WriteLine($"Color of shape is: {GetColor()}");
            else
            {
                Console.WriteLine("Color of shape is: nothing");

            }

        }

    }
}