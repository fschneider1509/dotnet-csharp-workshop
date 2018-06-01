using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._2
{
  class TuplesEquality
  {
    public void Run()
    {
      var tuple1 = (15, 20);
      var tuple2 = (15, 20);
      var tuple3 = (15, 10);

      if (tuple1.Equals(tuple2))
      {
        //This is true
      }
      var theTup = (1, 2, 3, 4, 5);

      dynamic test = "";
      test.x = 0;

#if CSharp8

      //Coming..//shallow equality checking
      if (tuple1 == tuple2)
      {
          
      }
#endif
    }
  }
}
