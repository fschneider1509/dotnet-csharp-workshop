using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7
{
  public class Tupler
  {
    #region Out
    public void Tally(IEnumerable<int> values, out int sum, out int count)
    {
      sum = 1;
      count = 5;

    }

    public void DoTally(IEnumerable<int> myValues)
    {
      int s, c;
      Tally(myValues, out s, out c);
      Console.WriteLine($"Sum: {s}, count: {c}");
    }

    #endregion

    #region

    public void SomeTuples()
    {
      //named type inference
      var speedAndHealth = (health: 100, speed: 10);
      Console.WriteLine(speedAndHealth.health);
      //This isn't meant to be hungarian notation :)
      (int id1, int id2, int id3) t = (2, 3, 4);
      Console.WriteLine($"{t.id1} {t.id2} {t.id3}");


      //can't convert dbl to float, and also a:1 - 'a' will be ignored
      //(int a1, float b1, int c20) conversions = (a: 1, 2d, 3);

      var item = (num: 1f,
                  count: 2f,
                  name: "hello",
                  person: new Person("Donna Demo"));
      item.Item1 = item.Item2 * item.Item1;
      Console.WriteLine(item.name);
      Console.WriteLine(item.Item4.Name);


      var (a, b, c, c1, c2) = (1, 2, 3, 4, 5);

      // We have variables now
      var addThemUp = a + b + c;
      Console.WriteLine(addThemUp);

      // Tuple compatibility with System.Tuple
      (var userName, var pass) = Tuple.Create("Joerg", "p@ssw0rd");

      // Type inference - note right hand side intellisense
      (float i, int j, int k) = (1, 2, 3);

      // named tuple
      (int p, int q, int r) theTup = (2, 3, 4);

      theTup = (5, 6, 7);
      theTup.p = 8;

      var theo = ("Theo", "Albrecht", "Tupler");
      (string firstName, string middleName, string lastName) person = theo;

      // Or generic names
      (string, string, string) stringTuple = default((string tup1, string tup2, string tup3));
      stringTuple.Item1 = "Mary";

    }
    #endregion

    // Include System.ValueTuple.dll

    private const string BaseUrl = "https://www.joergkrause.de";

    public async static Task<(string url, string data)> ProcessPageRead()
    {
      var result = await MakeRequests();
      return result;
    }

    static async Task<(string url, string data)> MakeRequests()
    {
      //Note usage of default. You can't use 'new' with a tuple type
      var responses = default((string url, string data));

      using (var client = new HttpClient())
      {
        var uri = new Uri(BaseUrl);

        var response = await client.GetAsync(uri);
        responses.data = await response.Content.ReadAsStringAsync();
        responses.url = uri.AbsoluteUri;
        return responses;
      }
    }


  }
}
