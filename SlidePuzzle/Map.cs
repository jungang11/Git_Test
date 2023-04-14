using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidePuzzle
{
    public class Map
    {
        public int[,] MakeMap()
        {
            int[,] map = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    map[i, j] = i * 5 + j + 1;
                }
            }
            ShuffleMap(map);

            return map;
        }

        public void ShuffleMap(int[,] map)
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randNum1 = rand.Next() % 5;
                int randNum2 = rand.Next() % 5;
                int randNum3 = rand.Next() % 5;
                int randNum4 = rand.Next() % 5;

                int temp = map[randNum1, randNum2];
                map[randNum1, randNum2] = map[randNum3, randNum4];
                map[randNum3, randNum4] = temp;
            }
        }
    }
}
