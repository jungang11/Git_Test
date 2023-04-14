namespace Git_Test
{
    internal class Program
    {
        // 1. 문장을 입력받은 후, 단어를 입력받아 문장 중 단어가 시작하는 위치 출력(없을 경우 -1 출력)
        public static void WordStart()
        {
            Console.Write("문장 입력 : ");
            string str = Console.ReadLine();
            Console.Write("단어 입력 : ");
            string word = Console.ReadLine();

            // string.indexof() : 주어진 문자열 str 앞에서부터 word가 처음 발견되는 위치의 인덱스 반환
            int result = str.IndexOf(word); 
            Console.WriteLine(result);
        }

        // 2. 문자열을 입력받으면 단어의 갯수를 출력하기
        public static void WordCount()
        {
            int result = 0;
            Console.Write("문자열 입력 : ");
            string str = Console.ReadLine();

            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == ' ')
                {
                    result++;
                }
            }
            // 마지막 공백을 세주기 위해 result + 1
            Console.WriteLine(result + 1);
        }

        static void Main(string[] args)
        {
            // WordStart();
            WordCount();
        }
    }
}