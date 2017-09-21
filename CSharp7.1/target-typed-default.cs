using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{
    class target_typed_default
    {
        
        const int yeOldeRedundant = default(int);


        //only C# 7.1 (change language version in advanced build settings)
        const int newAndShiny = default;
        void Something()
        {
            int newAndShiny = default;
            
        }
    }
}
