using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_1._List_A_과제
{
    internal class Item
    {
        private string name;
        public string Name { get { return name; } }

        public Item(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
