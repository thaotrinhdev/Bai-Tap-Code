public class Point2D
{
    private float x = 0;
    private float y = 0;
    public Point2D(float x, float y)
    {
        this.x=x;
        this.y=y;
    }
    public Point2D(){}
    public float GetX()
    {
        return x;
    }
    public void SetX(float x)
    {
        this.x=x;
    }
    public float GetY()
    {
        return y;
    }
    public void SetY(float y)
    {
        this.y=y;
    }
    public float[] GetXY()
    {
        return new float[2]{x,y};
    }
    public void SetXY(float x,float y)
    {
        this.x=x;
        this.y=y;
    }
    public override string ToString()
    {
        return $"{x},{y}";
    }
    public class Point3D:Point2D
{
    private float z=0;
    public Point3D(){}
    public Point3D(float x, float y, float z): base(x,y)
    {
        this.z=z;
    }
    public float GetZ()
    {
        return z;
    }
    public void SetZ(float z)
    {
        this.z=z;
    }
    public float[] GetXYZ()
    {
        return new float[3]{x,y,z};
    }
    public void SetXYZ(float x,float y,float z)
    {
        x=x;
        y=y;
        z=z;
    }
     public override string ToString()
    {
        return $"{x},{y},{z}";
    }
}
}