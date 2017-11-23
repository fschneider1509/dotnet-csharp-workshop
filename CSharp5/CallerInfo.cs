using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo
{
  internal class CallerInfo
  {
    internal static void Entry() {
      Foo("");
      Console.ReadLine();
    }

    private static void Foo(string test,
                            [CallerMemberName] string memberName = null,
                            [CallerFilePath]   string filePath = null,
                            [CallerLineNumber] int lineNumber = 0) {
      Console.WriteLine(memberName);
      Console.WriteLine(filePath);
      Console.WriteLine(lineNumber);

    }

    public int MyProperty {
      get {
        return 0;
      }
      set {
        Notify(value, nameof(MyProperty));
      }
    }

    private void Notify(object value, [CallerMemberName] string memberName = null) {
      throw new NotImplementedException();
    }
  }
}