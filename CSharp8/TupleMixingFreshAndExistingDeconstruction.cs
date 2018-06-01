using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._2
{
    class TupleMixingFreshAndExistingDeconstruction
    {
        public void Run()
        {
            int existingVar = 10;
#if CSharp8
            (int newVar, existingVar) = (5, 2);
#endif
        }
    }
}
