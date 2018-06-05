using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{
  public class TargetTypedDefault
  {

    const int oldWayForDefault = default(int); // 0

    // Geht nicht:
    //public void m1<T>(T pa) where T : struct
    //{
    //  if (pa == default)
    //  {

    //  }
    //}

#if CSharp71
    const int defaultType = default;
    public int DoSomething()
    {
      int otherDefaultType = default;
      return otherDefaultType;
    }

#endif
  }
}
