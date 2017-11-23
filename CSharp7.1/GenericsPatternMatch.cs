using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{

  public class ObjectPattern
  {
    public static void Test()
    {
      object o = 1; // int
      if (o is int targetIntObject)
      {
        Console.WriteLine(targetIntObject);
      }
      o = "and now a string";
      if (o is string targetStringObject)
      {
        Console.WriteLine(targetStringObject);
      }

      switch (o)
      {
        case int intObject:
          Console.WriteLine($"INT: {intObject}");
          break;
        case string stringObject:
          Console.WriteLine($"STR: {stringObject}");
          break;
        default:
          Console.WriteLine("Type unknown");
          break;
      }

    }
  }

  class GenericsPatternMatch
  {
#if CSharp_71
    public class Packet
    {
    }

    public class KeepalivePacket : Packet
    {
      public int KeepMe { get; set; }
    }

    public void Send<T>(T packet)
        where T : Packet
    {
      if (packet is KeepalivePacket keepalive)
      {
        // Do stuff with keepalive
      }
      switch (packet)
      {
        case KeepalivePacket keepalivePacket:
          // Do stuff with keepalivePacket
          break;
      }
    }
#endif
  }

}
