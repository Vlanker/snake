using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sim;

        Random random = new Random();
        

        public FoodCreator(int mapWidth, int mapHeight, char sim)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.sim = sim;
        }

        public Point CreateFood()
        {
            int x = random.Next(5, mapWidth - 5);
            int y = random.Next(5, mapHeight - 5);
            return new Point(x, y, sim);
            
        }

    }
}
