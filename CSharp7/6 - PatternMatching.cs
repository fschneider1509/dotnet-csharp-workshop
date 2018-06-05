using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7
{
  public interface IShape
  {
    double GetArea();
  }

  public struct Square
  {
    public double Side { get; }

    public Square(double side)
    {
      Side = side;
    }
  }

  public class Circle : IShape
  {
    public Circle(double radius)
    {
      Radius = radius;
    }

    public double Radius { get; set; }

    public double GetArea()
    {
      return Math.PI * (Radius * Radius);
    }
  }
  class Rectangle : IShape
  {

    public Rectangle(double length, double height)
    {
      Length = length;
      Height = height;
    }

    public double Length { get; set; }
    public double Height { get; set; }
    public double GetArea()
    {
      return Length * Height;
    }
  }
  public class PatternMatching
  {
    public void MatchSomething(IShape shape)
    {
      // Vor C# 7
      if (shape is Rectangle)
      {
        var rectangle = shape as Rectangle;
        var rectArea = rectangle.GetArea();
      }
      else if (shape is Circle)
      {
        var circle = shape as Circle;
        var circleArea = circle.Radius * circle.Radius * Math.PI;
      }

      // C# 7 Pattern Matching
      if (shape is Rectangle rect)
      {
        // Nur rectangle
        Console.WriteLine($"Rectangle {rect.GetArea()}");
      }
      // Match und Rückgabe und Variable erzeugen
      if (shape.GetArea() is var theArea && theArea > 5)
      {
        WriteLine($"Area is >5 {theArea}");
      }
      Console.WriteLine(theArea);
      switch (shape)
      {
        // Geht nicht, stammt nicht von IShape
        //case Square s:
        //  break;
        case Circle c:
          WriteLine($"Circle with radius {c.Radius}");
          break;
          // Mit Bedingung
        case Rectangle s when (s.Length == s.Height):
          WriteLine($"Square {s.Length} x {s.Height}");
          break;
        case Rectangle r:
          WriteLine($"Rectangle {r.Length} x {r.Height}");
          break;
        case null:
          // Nix
          throw new ArgumentNullException(nameof(shape));
        default: 
          // Default
          WriteLine("<unknown shape>");
          break;

      }

    }


    /// <summary>
    /// Prints a number
    /// </summary>
    /// <param name="o"></param>
    public void PrintStars(object o)
    {
      if (o is null) return;     // constant pattern "null"
      if (o == null) return;     // not the same - why?

      //If int, write that many *s
      if (o is int)
      {
        WriteLine(new string('*', (int)o));
      }

      //also can avoid cast above and use a new var
      if (o is int j)
      {
        WriteLine(new string('*', j));

      }
      else
      {
        WriteLine("Not an int");
        return; // type pattern "int i" 
      }

      //All in one
      if (o is int i || (o is string s && int.TryParse(s, out i)))
      {
        WriteLine(new string('*', i));
      }


      //If string, parse. Note use of outvars as 'count' (could use int count as well)
      if (o is string)
      {
        if (int.TryParse((string)o, out var counter))
        {
          WriteLine(new string('*', counter));
        }
      }


      //But we want to be smarter about multiple types
      if (o is int count || (o is string input && int.TryParse(input, out count)))
      {
        //note we'll always use the int value here based on expression above.
        WriteLine(new string('*', count));
      }


      //Uncomment and see issue
      //if (!(o is int k1))
      //{
      //    //Note this syntax will yield i never as an int, so we can't access it
      //    //if you uncomment you'll see compile error on k1 being unassigned, though 
      //    //if ! is removed up top it works since the expression could evaluate to true
      //    WriteLine(k1);
      //}


    }
  }
}
