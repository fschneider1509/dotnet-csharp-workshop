using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo
{
    public class AutoProps
    {

        // Alt
        private readonly Guid _id = Guid.NewGuid();
        public Guid Guid1
        {
            get
            {
                return _id;
            }
        }

        public AutoProps()
        {
            Guid2 = Guid.NewGuid();
            CtorSettable = true; // Nur im Ctor!
        }

        // C# 4
        public Guid Guid2 { get; protected set; }

        // C# 6
        public Guid Guid3 { get; } = Guid.NewGuid();

        public string Name { get; set;  } = "Theo Tester";

        public bool CtorSettable { get; }

    }
}
