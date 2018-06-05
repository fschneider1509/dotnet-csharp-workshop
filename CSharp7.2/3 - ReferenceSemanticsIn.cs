using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._2
{
  public class ReferenceSemanticsIn
  {
    private static double CalculateDistance(in Point3D point1, in Point3D point2)
    {
      double xDiff = point1.X - point2.X;
      double yDiff = point1.Y - point2.Y;
      double zDiff = point1.Z - point2.Z;

      return Math.Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
    }

    private static double CalculateDistance2(in Point3D point1, in Point3D point2 = default)
    {
      double xDiff = point1.X - point2.X;
      double yDiff = point1.Y - point2.Y;
      double zDiff = point1.Z - point2.Z;

      return Math.Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
    }

    public double GetVector()
    {
      var point1 = new Point3D();
      var point2 = new Point3D();

      return CalculateDistance(point1, point2);
    }

    public double GetVector2()
    {
      var point1 = new Point3D();
      return CalculateDistance2(point1);
    }

  }

  public class Point3D
  {
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
  }
}
