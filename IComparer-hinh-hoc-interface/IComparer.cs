using System;

namespace Shape
{
  public class CircleComparator : IComparer<Circle>
  {
    public int Compare(Circle c1, Circle c2)
    {
      if (c1.GetRadius() > c2.GetRadius()) return 1;
      else if (c1.GetRadius() < c2.GetRadius()) return -1;
      else return 0;
    }
  }
}