using System.Reflection.Metadata;

class Fan
{
    public const int SLOW=1;
    public const int MEDIUM=2;
    public const int FAST=3;

    private int speed = SLOW;
    private bool isOn= false;
    private double radius =5;
    private string color = "Blue";

    //Getter
    public int Speed=> speed;
    public bool IsOn=> isOn;
    public double Radius=> radius;

    public Fan()
    {

    }
    public override string ToString()
    {
        if(isOn)
        {
            return $"speed: {speed}, color:{color}, radius:{radius}, fan is on";

        }
        else
        {
            return $"color:{color}, radius:{radius}, fan is ";
        }
        
    }
    public string ToString(int speed, string color, double radius, string status, string name)
    {
        return $"{name}\nspeed: {speed}, color: {color}, radius: {radius}, ststus: {status}";
        
    }
    //Setter
    public void Setspeed(int speed)
    {
        this.speed=speed;
    }
      public void Seton(bool isOn)
    {
        this.isOn=isOn;
    }
      public void Setradius(double radius)
    {
        this.radius=radius;
    }

}
