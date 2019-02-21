using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DZ_Lesson2
{
    abstract class Person
    {
        public const int s = 100;
        public const int st = 20000;
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        abstract public string Money();
    }
}
