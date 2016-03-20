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

            Walls walls = new Walls(120, 30);
            walls.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //Еда
            FoodCreator foodCreator = new FoodCreator(120, 30, '*');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                //столкновение со стеной или хвостом
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;

                }
                
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
                }
            }
         }  
        
          
    }
 }