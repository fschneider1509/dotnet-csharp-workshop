using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7
{
  public class Point
  {
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    public void Deconstruct(out int x, out int y)
    {
      x = X;
      y = Y;
    }

    public void Deconstruct(out int x, out int y, out int q)
    {
      x = X;
      y = Y;
      q = 5;
    }
  }

  public static class DeconstructSamples
  {
    public static void Do()
    {
      //7b. Deconstruction
      var point = new Point(5, 4);
      var (p1, p2) = point;

      //overloaded deconstruction
      var (x1, y1, q1) = point;

      //Note can't have a single value deconstruction or tuple
      //(int aqqqq) = (5);

      //Deconstruction, I only want one item
      (int a10, _, _, _, _) = (1, 2, 3, 4, 5);
      var (x, _) = point;
    }
  }
}
