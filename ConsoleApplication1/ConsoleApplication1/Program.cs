﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(vl);
            figures.Add(hl);
                    

            foreach (var f in figures)
            {
                f.Draw();
            }

            /* Console.SetBufferSize(120, 30);
            //Отрисовка рамочки
            HorizontalLine UpLine = new HorizontalLine(0, 119, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 119, 28, '+');
            VerticalLine LeftLine = new VerticalLine(0, 0, 28, '+');
            VerticalLine RightLine = new VerticalLine(119, 0, 28, '+');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            //Еда
            FoodCreator foodCreator = new FoodCreator(120, 30, '*');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                //пожирание
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                //задержка
                Thread.Sleep(150);
                //смена направления движения
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }*/
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
              
    }
}
