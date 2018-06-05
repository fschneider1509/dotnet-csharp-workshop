using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{
  public class TupleProjectionInitializers
  {
    internal class FTuple
    {
      public int f1;
      public int f2;
    }

    public void Run()
    {
      var x1 = new FTuple();

      var tuple = ((x1.f1, x1.f2) = (1, 2));

#if CSharp71
      //inferred naming without (f1:x1.f1, f2:x1.f2)
      tuple.f1 = tuple.f2;
#endif
    }
  }
}
