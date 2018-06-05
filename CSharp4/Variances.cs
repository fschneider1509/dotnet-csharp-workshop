using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp4
{

  public interface IMyCollection<out T> : IEnumerable<T>
  {
  }

  public class MyCollection<T> : IMyCollection<T>
  {
    public IEnumerator<T> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }
  }

  public class BaseClass { }

  public class MyClass: BaseClass { }

  public class Test
  {
    public Test()
    {
      IMyCollection<MyClass> bag = new MyCollection<MyClass>();
      IMyCollection<BaseClass> baseBag = bag; // funktioniert wegen out
    }
  }

}
