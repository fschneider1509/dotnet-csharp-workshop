using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{
  internal class DiscardsInLambdas
  {
    public void Run()
    {
      // This is NOT a discard, it's _ as a var name
      var list = new List<int>() { 1, 2, 3, 4, 5 };
      int counter = 0;
      // 5
      list.ForEach(_ => { counter++; });
      Console.WriteLine(counter);
      // 15
      counter = 0;
      list.ForEach(_ => { counter+=_; });
      Console.WriteLine(counter);
      // These are discards, _ is a contextual keyword
      // valid name _ --> not in same context as ForEach, not usable
      _ = 600;
      // Console.WriteLine(_); // no compiling, _ is not readable
      if (bool.TryParse("TRUE", out bool _)) {
        Console.WriteLine("Parse ok"); // _ is not readable
      }
    }
  }
}
