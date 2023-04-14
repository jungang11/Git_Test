namespace SlidePuzzle
{
    internal class Program
    {
        /* 슬라이드 퍼즐 만들기 
         * 5x5 판을 생성하고 랜덤한 숫자를 배치한다.
         * 시작위치는 상관없으며 ArrowKey입력시 해당 방향으로 이동한다.
         * 단, 밖으로 벗어날 수 없다.
         * 아래 예시는 0이 움직이는 것으로 가정한다.
         */

        enum KeyCode { None, UpArrow, DownArrow, LeftArrow, RightArrow }

        static KeyCode GameInput()
        {
            KeyCode key;
            ConsoleKeyInfo info = Console.ReadKey();

            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    key = KeyCode.UpArrow;
                    break;
                case ConsoleKey.DownArrow:
                    key = KeyCode.DownArrow;
                    break;
                case ConsoleKey.LeftArrow:
                    key = KeyCode.LeftArrow;
                    break;
                case ConsoleKey.RightArrow:
                    key = KeyCode.RightArrow;
                    break;
                default:
                    key = KeyCode.None;
                    break;
            }
            return key;
        }

        // 게임 내용 출력 함수
        public static void Rendering(int[,] map)
        {
            Console.Clear();
            Console.WriteLine("========================");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", map[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("← : 왼쪽 → : 오른쪽 ↑ : 위쪽 ↓ : 아래쪽");
        }

        static void Main(string[] args)
        {
            Map map = new Map();
            int[,] _map = map.MakeMap();
            Rendering(_map);

            while (true)
            {
                Rendering(_map);
            }
        }
    }
}