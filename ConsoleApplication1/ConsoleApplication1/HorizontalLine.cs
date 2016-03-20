﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HorizontalLine:Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sim)
        {
            pList = new List<Point>();
            for (int x=xLeft; x<=xRight; x++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Draw();
            
            Console.ForegroundColor = ConsoleColor.White;
         }

    }
}
