using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DZ_Lesson2
{
    class Month : Person
    {
        public int Sum { get; set; }
        public Month(string name)
        : base(name)
        {
             Sum = st;
        }

        public override string Money() //метод модифицирован для обсчёта
        {
            string s = Name + " " + Sum;
            return s;
        }
    }
}
