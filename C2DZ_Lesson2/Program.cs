using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DZ_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Proffesional name = new Proffesional();            
            Random rnd = new Random();
            string[] Spisok = new string[15];
            for (int i=0;i<Spisok.Length;i++)
            {
                Hour h = new Hour(name.Record());
                Month m = new Month(name.Record());
                int r = rnd.Next(1, 100);
                if (r < 50) Spisok[i] = h.Money();
                else Spisok[i] = m.Money();
                Console.WriteLine(Spisok[i]);
            }
            Array.Sort(Spisok);
            Console.WriteLine();
            for (int i = 0; i < Spisok.Length; i++)
            {
                Console.WriteLine(Spisok[i]);
            }

            Console.ReadKey();
        }
    }
}
