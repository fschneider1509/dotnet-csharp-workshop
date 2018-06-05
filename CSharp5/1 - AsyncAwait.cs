using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo
{
  class Async
  {

    public static void AsyncStart()
    {

      var test = "Ich bin ein String";
      // synchronous
      int result = ComplexCalculation();
      // Some time later: 
      Console.WriteLine("SYNC");
      Console.WriteLine(result);   // 116

      // asynchronous, traditional
      Task<int> task = ComplexCalculationAsync();
      var awaiter = task.GetAwaiter();
      awaiter.OnCompleted(() =>        // Continuation 
      {
        int result2 = awaiter.GetResult();
        Console.WriteLine("AWAITER ASYNC");
        Console.WriteLine(result2);       // 116 
      });

      Console.WriteLine("BEFORE ASYNC AWAIT");
      ComplexAsynchCalculation();
      Console.WriteLine("AFTER ASYNC AWAIT");

      Console.WriteLine("*** CONSOLE END");
      Console.ReadLine();
    }


    private static async void ComplexAsynchCalculation()
    {
      // asynchronous, async + await
      Console.WriteLine("ASYNC ENTER");
      int result = await ComplexCalculationAsync();
      Console.WriteLine("ASYNC EXIT");
      Console.WriteLine(result);
    }


    private static int ComplexCalculation()
    {
      double x = 2;
      for (int i = 1; i < 1000000; i++)
        x += Math.Sqrt(x) / i;
      return (int)x;
    }

    private static Task<int> ComplexCalculationAsync()
    {
      return Task.Run(() => ComplexCalculation());
    }

  }
}