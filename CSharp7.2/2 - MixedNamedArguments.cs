using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._2
{
  public class MixedNamedArguments
  {

    public static void Execute()
    {
      PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
      // C# 7.2
      PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug");
      PrintOrderDetails("Gift Shop", orderNum: 31, "Red Mug");
    }

    static void PrintOrderDetails(string sellerName, int orderNum, string productName)
    {
      if (string.IsNullOrWhiteSpace(sellerName))
      {
        throw new ArgumentException(message: "Seller name cannot be null or empty.", paramName: nameof(sellerName));
      }

      Console.WriteLine($"Seller: {sellerName}, Order #: {orderNum}, Product: {productName}");
    }
  }
}
