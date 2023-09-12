public class Cyclinder : Circle
{
    private double height;
    public Cyclinder(){}
    public Cyclinder(double height)
    {
        this.height=height;
    }
    public Cyclinder(double radius, string color, double height): base(radius,color)
    {
        this.height=height;
    }
    public double GetHeight => height;
    public void SetHeight(double height)
    {
        this.height=height;
    }
    public double GetArea()
    {
        return GetArea();
    }
    public double GetPerimeter()
    {
        return GetPerimeter();
    }
    public override string ToString()
    {
        return "A Circle with radius="
        + GetRadius()
        + ", which is a subclass of "
        + base.ToString();

    }
}