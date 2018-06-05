using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{
  public class AsyncMain
  {
#if CSharp71

    public static Task Main() => null;

    //static Task<int> Main() => null;

    //static Task Main(string[] test) => null;

    //static Task<int> Main(string[] test) => null;
#endif
  }
}
