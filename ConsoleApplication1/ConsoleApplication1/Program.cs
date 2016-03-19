using System;
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
            Console.SetBufferSize(120, 30);
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
            FoodCreator foodCreator = new FoodCreator(120, 30, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            //Console.ReadLine();
        }

      
    }
}
