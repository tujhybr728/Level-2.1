using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DZ_Lesson2
{
    abstract class Person
    {
        // основной абстрактный массив для генерации прочих
        public const int s = 100; // константа почасовой оплаты
        public const int st = 20000; // константа месячной зарплаты
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        abstract public string Money(); // абстрактный метод для подсчёта
    }
}
