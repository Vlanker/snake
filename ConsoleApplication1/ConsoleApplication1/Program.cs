using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sim = '*';
            p1.Drow();
            /* Drow(p1.x, p1.y, p1.sim);*/

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sim = '#';
            p2.Drow();
            /* Drow(p2.x, p2.y, p2.sim);*/

            /*int x1 = 1;
            int y1 = 3;
            char sim1 = '*';
            Drow(x1,y1,sim1);

            int x2 = 4;
            int y2 = 5;
            char sim2 = '#';
            Drow(x2, y2, sim2);*/

            Console.ReadLine();
        }

        /* static void Drow(int x, int y, char sim)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }*/
    }
}
