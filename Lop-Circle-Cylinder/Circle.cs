public class Circle
{
    private double radius= 2.0;
    private string color = "pink";
    public Circle(){}
    public Circle(double radius, string color)
    {
        this.radius=radius;
        this.color=color;
    }
    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double radius)
    {
        this.radius=radius;
    }
    public string GetColor()
    {
        return color;
    }
    public void SetColor(string color)
    {
        this.color=color;
    }
    public double GetArea()
    {
        return radius *radius*Math.PI;
    }
    public double GetPerimeter()
    {
        return 2* radius*Math.PI;
    }
    public override string ToString()
    {
        return "A Circle with radius="
        + GetRadius()
        + ", which is a " + GetColor() 
        + " of "
        + base.ToString()
        + " , Area: " + GetArea()
        + " , Perimeter: " + GetPerimeter();

    }

}