namespace BingoGame
{
    /*
    5x5 판을 생성하고 랜덤한 숫자를 배치한다.
    원하는 숫자 입력시 해당 숫자는 특수기호로 바꾼다.
    생성한 숫자외의 다른 수를 입력할 수 없다.(예외처리)
    종료 조건은 빙고 3줄 이상시 종료한다.
     */

    internal class Program
    {
        // 게임 내용 업데이트 함수
        public static void GameUpdate(int[,] bingo, Player player)
        {
            int input = player.Input();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (bingo[i, j] == input)
                    {
                        bingo[i, j] = 50;
                    }
                }
            }

            int LeftCross = 0;
            int RightCross = 0;

            for (int i = 0; i < 5; i++)
            {
                int Row = 0;
                int Col = 0;

                for (int j = 0; j < 5; j++)
                {
                    if (bingo[i, j] == 50)
                    {
                        Row++;
                    }
                    else if (bingo[j, i] == 50)
                    {
                        Col++;
                    }
                    else if (i == j && bingo[i, j] == 50)
                    {
                        LeftCross++;
                    }
                    else if (i + j == 4 && bingo[i, j] == 50)
                    {
                        RightCross++;
                    }
                }
                if (Row == 5) player.BingoCount++;
                else if (Col == 5) player.BingoCount++;
            }
            if (LeftCross == 5) player.BingoCount++;
            else if (RightCross == 5) player.BingoCount++;
        }

        // 게임 내용 출력 함수
        public static void Rendering(int[,] bingo, Player player)
        {
            Console.Clear();
            Console.WriteLine("=======빙고=======");
            Console.WriteLine("{0}개 빙고", player.BingoCount);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (bingo[i, j] == 50)
                        Console.Write("#\t");
                    else
                        Console.Write("{0}\t", bingo[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("입력해라 : ");
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Map map = new Map();
            int[,] bingo = map.MakeMap();
            Rendering(bingo, player);

            while (true)
            {
                GameUpdate(bingo, player);
                if (player.BingoCount >= 3) break;
                else Rendering(bingo, player);
            }
        }

    }
}