using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DZ_Lesson2
{
        class Proffesional
    {
        public string[] ListName = new string[] { "Борис", "Владимир", "Александр", "Иван", "Григорий", "Евгений" };
        public string[] ListSurname = new string[] { "Иванов", "Гришников", "Кожевников", "Горшечкинов", "Тисов", "Шелуинов" };
        public string[] ListMidle = new string[] { "Борисович", "Владимирович", "Александрович", "Иванович", "Григорьевич", "Евгеньевич" };
        private string Name;
        private Random rnd1 = new Random();
        private string Surname;
        private string Middle_name;

        public string Record()
        {
            Name = ListName[rnd1.Next(5)];
            Surname = ListSurname[rnd1.Next(5)];
            Middle_name = ListMidle[rnd1.Next(5)];
            string at = Surname + " " + Name + " " + Middle_name;
            return at;
        }
    }
}
