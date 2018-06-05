using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{

  public class Animal
  {
    // visible within the whole assembly
    protected internal class SuperSecretInternalBehavior
    {
      public SuperSecretInternalBehavior()
      {
      }
    }
  }

  public class Giraffe : Animal
  {
    public Giraffe()
    {
      // needs protected
      var behavior = new SuperSecretInternalBehavior();
    }
  }

  public class SomeWhereElse
  {
    public SomeWhereElse()
    {
      // needs internal
      var s = new Animal.SuperSecretInternalBehavior();
    }
  }

}