using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DZ_Lesson2
{
    class Hour : Person
    {
        public double Sum { get; set; }
        public Hour(string name)
        : base(name)
        {
             Sum = 20.8 * 8 * s;
        }

        public override string Money()
        {
            string s = Name + " " + Sum;
            return s;
        }
    }
}

