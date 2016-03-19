using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public Point(int _x, int _y, char _sim)
        {
            x = _x;
            y = _y;
            sim = _sim;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sim = p.sim;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }

        }

        internal void Clear()
        {
            sim = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sim;
        }
    }
}
