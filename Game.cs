using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Asteroid_0000
{
    class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        // Свойства
        // Ширина и высота игрового поля
        public static int Width { get; set; }
        public static int Height { get; set; }
        private static Random rnd = new Random(); // нужна для рандомного появления объектов и нестатичности первого объекта
        private static Image background = Image.FromFile(@"Stars.jpg");
        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }
        static Game()
        {

        }
        public static void Init(Form form)
        {
            Timer timer = new Timer { Interval = 100 };
                        
            Graphics g;         // Графическое устройство для вывода графики
            
            _context = BufferedGraphicsManager.Current;     // Предоставляет доступ к главному буферу графического контекста для текущего приложения
            g = form.CreateGraphics();      // Создаем объект (поверхность рисования) и связываем его с формой                                         
            Width = form.ClientSize.Width;   // Запоминаем размеры формы
            Height = form.ClientSize.Height; 
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));// Связываем буфер в памяти с графическим объектом, чтобы рисовать в буфере
            Load();            // загрузка объектов
            timer.Start(); //таймер задержки
            timer.Tick += Timer_Tick;
        }
        public static void Draw() //отоброжение объектов
        {
            Buffer.Graphics.DrawImage(background,new Point(-(Width/2),-(Height/2)));
            foreach (BigObj obj in _bigobjs) // сначала большие объекты
                obj.Draw();                    
            foreach (Enemy obj in _objs) // затем маленькие
                obj.Draw();
            Buffer.Render();
        }

        public static Enemy[] _objs;    // массив маленьких объектов (взаимодействие)
        public static BigObj[] _bigobjs;// генерация массива объектов (круги)
        public static void Load() // метод загрузки
        {
            int rndsize;
            _objs = new Enemy[values.maxobjenemy];
            for (int i = 0; i < _objs.Length; i++)
            {
                rndsize = rnd.Next(values.minsize, values.maxxize); // нужна для разнообразия размера объектов
                _objs[i] = new Enemy(new Point(rnd.Next(200, 500), rnd.Next(200, 500)), new Point(6+rnd.Next(values.maxspeed),
                    rnd.Next(values.maxspeed)), new Size(rndsize, rndsize));
            }
            _bigobjs = new BigObj[values.maxbigobj];
            for (int i = 0; i < _bigobjs.Length; i++)
            {
                rndsize = rnd.Next(values.sizebigobj/2,values.sizebigobj); // нужна для разнообразия размера объектов
                _bigobjs[i] = new BigObj(new Point(rnd.Next(0, 500), rnd.Next(0, 500)), new Point(5+rnd.Next(values.maxspeed),
                    rnd.Next(values.maxspeed)), new Size(rndsize, rndsize));
            }
        }

        public static void Update() // метод обновления
        {
            foreach (BigObj obj in _bigobjs)
                obj.Update();
            foreach (Enemy obj in _objs)
                obj.Update();
            
        }
    }
}