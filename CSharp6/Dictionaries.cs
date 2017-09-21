using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo
{
    public class Dictionaries
    {

        // Alt
        Dictionary<int, string> list = new Dictionary<int, string>()
        {
            { 1, "Stern" },
            { 2, "Mond" }
        };

        // C# 6

        Dictionary<int, string> list2 = new Dictionary<int, string>()
        {
            [1] = "Stern",
            [2] = "Mond"
        };


    }
}
