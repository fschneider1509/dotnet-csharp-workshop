using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp6
{
  public class NullConditional
  {
    public Action PurchaseCallBack { get; set; }

    public void PurchaseProduct()
    {

      bool? result = null; // true, false, null

      int? value = 55;
      int y = value ?? 20; // value == null ? 20 : value 

      //Without null conditional
      //Store purchase is done, notify caller
      if (PurchaseCallBack != null)
      {
        //Notify the StoreManager we're done with purchase
        //so it can update its UI
        PurchaseCallBack();
      }

      //With null conditional - call if its not null
      PurchaseCallBack?.Invoke();


      string customerInfo = "Jane Doe";

      //Length or null - storing to var
      int? length = customerInfo?.Length;


      //Direct use
      if (customerInfo?.Length > 0)
      {
        Console.WriteLine($"Length:{customerInfo.Length}");
      }
      
      List<string> collection = null;
      var item = collection?[0];
    }
  }
}
