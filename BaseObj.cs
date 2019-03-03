using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Asteroid_0000
{
    abstract class BaseObj 
    {
        public abstract void Draw();
        public abstract void Update();

        protected Point Pos; // позиция
        protected Point Dir; // направление
        protected Size Size; // размер
        public BaseObj(Point pos, Point dir, Size size)
        {
            Pos = pos;              // позиция
            Dir = dir;              // направление
            Size = size;            // размер
        }           
    }
}
