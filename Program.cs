using JoergIsAGeek.Workshop.Dotnet.Demo.CSharp6;
using JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7;
using JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1;
using JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JoergIsAGeek.Workshop.Dotnet.Demo
{
  public class Program
  {
    static void Main(string[] args)
    {
      (string p1, string p2, string keyLang, string keyNum) = (null, null, "", "");
      switch (args?.Length)
      {
        case 1:
          p1 = args[0];
          break;
        case 2:
          p2 = args[1];
          goto case 1;
      }
      if (!string.IsNullOrEmpty(p1))
      {
        Console.WriteLine("Demo Language (C# X) [5=C#5, 6=C#6, 7=C#7.0, 1=C#7.1, 2=C#7.2, 3=C#7.3");
        keyLang = Console.ReadKey().KeyChar.ToString();
      } else
      {
        keyLang = p1;
      }
      Console.WriteLine();
      if (!string.IsNullOrEmpty(p2))
      {
        Console.WriteLine("Demo Number (1-F)");
        keyNum = Console.ReadKey().KeyChar.ToString().ToUpper();
      } else
      {
        keyNum = p2;
      }
      Console.WriteLine($"Call demo: {keyLang}.{keyNum}");
      switch ($"{keyLang}.{keyNum}")
      {
        case "5.1":
          Console.WriteLine("Async Await");
          break;
        case "5.2":
          Console.WriteLine("Async Load");
          break;
        case "5.3":
          Console.WriteLine("CallerInfo");
          break;
        case "6.1":
          Console.WriteLine("Auto Props");
          break;
        case "6.2":
          Console.WriteLine("Collection Initializer");
          break;
        case "6.3":
          Console.WriteLine("Dictionaries");
          break;
        case "6.4":
          Console.WriteLine("Exception Filter");
          break;
        case "6.5":
          Console.WriteLine("ExpressionBodies");
          var eb = new ExpressionBodies.Zombie("Some Name", 100);
          Console.WriteLine($"Health = {eb.Health}; Name = {eb.Name}");
          break;
        case "6.6":
          Console.WriteLine("Index Init");
          break;
        case "6.7":
          Console.WriteLine("Interpolation");
          //2 Interpolation
          Interpolation.InterpolateDemo();
          break;
        case "6.8":
          Console.WriteLine("NameOf");
          break;
        case "6.9":
          Console.WriteLine("Null Conditional");
          break;
        case "6.10":
          Console.WriteLine("Partial Interface");
          //Review 1 Null Conditional
          var nullConditional = new NullConditional();
          nullConditional.PurchaseProduct();
          break;
        case "6.11":
          Console.WriteLine("Using Static");
          break;
        case "7.0":
          Console.WriteLine("DigitAndBinary");
          //1. Binary Literal and digit separator
          DigitAndBinary.Process();
          break;
        case "7.1":
          Console.WriteLine("RefReturnAndOuts");
          //2. Ref returns - pointer to a structure
          var refReturns = new RefReturnsAndOuts();
          refReturns.TestRefs();
          break;
        case "7.2":
          Console.WriteLine("ExpressionBodied");
          //3. Expression bodied accessors, constructors, destructor/finalizer
          // C# 6 
          var zombie = new CSharp6.ExpressionBodies.Zombie("Fred", 30);
          Console.WriteLine(zombie.ToString());
          break;
        case "7.3":
          Console.WriteLine("LocalFunction");
          break;
        case "7.4":
          Console.WriteLine("Local Functions");
          int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
          LocalFunctions.QuickSort(numbers, 0, numbers.Length - 1);
          Console.WriteLine("Sorted items");
          numbers.ToList().ForEach(o => Console.WriteLine(o));
          //Ex 2
          LocalFunctions.Fibonacci(5);
          break;
        case "7.5":
          OutVars.Process();
          break;
        case "7.6":
          Console.WriteLine("PatternMatching");
          //6. Pattern Matching
          var pm = new PatternMatching();
          pm.MatchSomething(new Circle(3.5d));
          pm.MatchSomething(new Rectangle(2d, 4d));
          //Int
          pm.PrintStars(5);
          //String
          pm.PrintStars("5");
          //Shape
          pm.PrintStars(new Rectangle(3, 4));
          break;
        case "7.7":
          Console.WriteLine("ThrowExpression");
          try
          {
            Person p = new Person("");
            p.Name = null; // throws an exception
          }
          catch (Exception)
          {
            Console.WriteLine("Exception thrown");
          }
          break;
        case "7.8":
          Console.WriteLine("Tupler");
          var task = Tupler.ProcessPageRead();
          task.Wait();
          var result = task.Result;
          Console.WriteLine($"{result.url} sent {result.data.Length} bytes");
          break;
        case "7.9":
          Console.WriteLine("Deconstruct");
          break;
        case "7.A":
          Console.WriteLine("GeneralizedAsyncReturn");
          break;
        // C# 7.1
        case "1.1":
          break;
        case "1.2":
          break;
        case "1.3":
          var dil = new DiscardsInLambdas();
          dil.Run();
          break;
        case "1.4":
          break;
        case "1.5":
          break;
        case "1.6":
          var tt = new TargetTypedDefault();
          Console.WriteLine($"Ausgabe: {tt.DoSomething()}"); // 0
          break;
        case "1.7":
          var tp = new TupleProjectionInitializers();
          tp.Run();
          break;
        // C# 7.2
        case "2.1":
          Console.WriteLine("ExpressionVariablesInInit");
          break;
        case "2.2":
          Console.WriteLine("MixedNamedArguments");
          MixedNamedArguments.Execute();
          break;
        case "2.3":
          Console.WriteLine("ReferenceSemanticsIn");
          break;
        // C# 7.3
        case "3.3":
          Console.WriteLine("Tuples Equality");
          break;
      }

      Console.WriteLine();
      Console.ReadLine();


    }
  }
}
