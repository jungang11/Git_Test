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


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}