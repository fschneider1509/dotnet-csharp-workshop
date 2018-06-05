using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._2
{
  public class ExpressionVariablesInInitializers
  {
    public class A
    {
      public A(int i)
      {
      }
      // field init
      public static int Magic = int.TryParse("123", out var i) ? i : 0;
    }

    public class B : A
    {
      // See base call with expression and var
      public B(string s)
          : base(int.TryParse(s, out var i) ? i : 0)
      {
        Console.WriteLine(i);
      }
    }
  }
}
