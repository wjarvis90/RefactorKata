using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorKata
{
    public class Product
    {
        public string name;
        public string Name { get { return name; } set { name = value; } }
    }
}

