using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp6
{
  public class NameOf
  {
    public void Process(string custId)
    {
      //No strings required.
      //throw new ArgumentException("customerId");
      throw new ArgumentException(nameof(custId));

      //More specifically 
      throw new ArgumentException($" {nameof(Process)} Order cannot be processed without a customer id: ", nameof(custId));
    }
  }
}
