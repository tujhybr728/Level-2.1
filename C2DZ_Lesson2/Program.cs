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
            Proffesional name = new Proffesional();            // создаём имена
            Random rnd = new Random();
            string[] Spisok = new string[15]; // массив где будут ханиться сотрудники, можно было сделать стеком, тогда можно будет выводить через foreach
            for (int i=0;i<Spisok.Length;i++)
            {
                Hour h = new Hour(name.Record()); // из-за кривости кода, для работы рандомной генерации имён приходиться постоянно объявлять значения
                Month m = new Month(name.Record());
                int r = rnd.Next(1, 100);
                if (r < 50) Spisok[i] = h.Money(); // разброс по заработным платам
                else Spisok[i] = m.Money();
                Console.WriteLine(Spisok[i]);
            }
            Array.Sort(Spisok); // соритровка
            Console.WriteLine();
            for (int i = 0; i < Spisok.Length; i++)
            {
                Console.WriteLine(Spisok[i]); //вывод отсортированного
            }

            Console.ReadKey();
        }
    }
}
