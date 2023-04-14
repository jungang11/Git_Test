using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public class Map
    {
        // 맵 생성
        public int[,] MakeMap()
        {
            int[,] bingo = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bingo[i, j] = i * 5 + j + 1;
                }
            }
            ShuffleMap(bingo);

            return bingo;
        }

        // 맵 랜덤으로 숫자 섞기
        public void ShuffleMap(int[,] bingo)
        {
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randNum1 = rand.Next() % 5;
                int randNum2 = rand.Next() % 5;
                int randNum3 = rand.Next() % 5;
                int randNum4 = rand.Next() % 5;

                int temp = bingo[randNum1, randNum2];
                bingo[randNum1, randNum2] = bingo[randNum3, randNum4];
                bingo[randNum3, randNum4] = temp;
            }
        }
    }
}
