﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo.CSharp7._1
{
    internal class AutopropNonFields
    {
        [Serializable]
        public class Foo
        {
            [field: NonSerialized]
            public string MySecret { get; set; }
        }


        //would generate
        [Serializable]
        public class Foo2
        {
            //HERE
            [NonSerialized]
            private string MySecret_backingField;

            public string MySecret
            {
                get { return MySecret_backingField; }
                set { MySecret_backingField = value; }
            }
        }
    }
}
