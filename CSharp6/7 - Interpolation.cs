using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp6
{
  public class Interpolation
  {
    public static void InterpolateDemo()
    {

      string address = "123 Main st";
      string name = "Mary Jones";
      int health = 100;

      string personInfo = string.Format("Name: {0} Address: {1}", name, address);

      var description = $"Name: {name.Length} Health: {health}";
    }


  }
}
