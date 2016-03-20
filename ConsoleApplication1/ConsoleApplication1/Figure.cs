using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                //пересекаешься с точкой?
                if (figure.IsHit(p))
                {
                    return true;
                }
                    
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            //а пересекаешься ли ты с какой-лиюо точкой???!
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
        

    }
}
