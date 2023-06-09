﻿namespace UpDownGame
{
    /* Up & Down 게임 만들기
    컴퓨터는 0~999 중에 랜덤한 숫자를 뽑는다. 유저는 10번의 기회가 있다.
    플레이어가 수를 입력 하면 컴퓨터는 그 수가 큰지, 작은지, 정답인지 알려준다.
    10번의 기회 소진시 게임을 종료할껀지 재시작 할껀지 선택 할수 있다.
    */

    internal class Program
    {
        // 플레이어가 수를 입력하면 컴퓨터는 정답을 확인(+ UP,DOWN)
        public static bool Correct(int player, int computer)
        {
            if (player == computer)
            {
                Console.WriteLine("정답입니다.");
                return true;
            }
            else if (player > computer)
            {
                Console.WriteLine("Down");
                return false;
            }
            else
            {
                Console.WriteLine("UP");
                return false;
            }
        }

        // 게임내용 함수
        public static void Game()
        {
            // 랜덤한 숫자 0 ~ 999
            Random rand = new Random();
            int computer = rand.Next(0, 1000);

            // 유저는 10번의 기회
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(computer);
                Console.Write("남은 기회 : {0}, 정답 입력 : ", (10 - i));
                int player = int.Parse(Console.ReadLine());

                if (Correct(player, computer))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        // 메인 함수
        public static void Main(string[] args)
        {
            Game();
            Console.WriteLine("1 입력시 재시작, 아무 키 입력시 종료");
            int reGame = int.Parse(Console.ReadLine());
            // 기회 소진시 종료인지 재시작인지 선택

            if (reGame == 1)
            {
                Game();
            }
            else
            {
                Console.WriteLine("게임 종료");
            }
        }
    }
}