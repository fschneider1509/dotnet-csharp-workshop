using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{
    class tuple_mixing_fresh_and_existing_deconstruction
    {
        public void Run()
        {
            int existingVar = 10;
#if CSharp_71
            (int newVar, existingVar) = (5, 2);
#endif
        }
    }
}
