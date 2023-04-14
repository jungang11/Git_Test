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

        // 3. 주어진 숫자가 소수인지 판별하는 solution을 완성하라
        // bool -> void 형으로 변환했음
        public static void IsPrime()
        {
            Console.Write("숫자 입력 : ");
            int num = int.Parse(Console.ReadLine());

            // sqrt : 제곱근
            int sqrt_num = (int)Math.Sqrt(num);
            for(int i = 2; i < sqrt_num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("소수가 아님");
                    break;
                }
            }
            Console.WriteLine("소수임");
        }

        // 4. 사용자가 입력한 양의 정수의 각 자릿수의 합을 구하는 함수
        static void SumOfDigits()
        {
            Console.Write("양의 정수 입력 : ");
            int num = int.Parse(Console.ReadLine());

            int result = 0;
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length; i++)
            {
                // SubString(a, b) => a번째부터 b만큼 자름
                result += int.Parse(numStr.Substring(i, 1));
            }
            Console.WriteLine(result);
        }

        // 5. k개의 정렬된 배열에서 공통항목을 찾는 함수. 중복 허용 x
        static void FindCommonItems()
        {
            int[] arr1 = { 1, 5, 5, 10 };
            int[] arr2 = { 3, 4, 5, 5, 10 };
            int[] arr3 = { 5, 5, 10, 20 };

            int[] result = new int[arr1.Length];
            int[] answer = new int[arr1.Length];

            // arr1 과 arr2 중복값을 배열 result 에 저장
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        result[i] = arr1[i];
                        break;
                    }
                }
            }

            // result 배열과 arr3 비교, 중복값을 배열 answer 에 저장
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == 0)
                {
                    result[i] = result[i + 1];
                }
                for (int j = 0; j < arr3.Length; j++)
                {
                    if (result[i] == arr3[j])
                    {
                        answer[i] = result[i];
                        break;
                    }
                }
            }
            // answer 배열의 중복되는 값 제거
            answer = answer.Distinct().ToArray();

            // answer 배열의 모든 값 출력
            foreach(int i in answer)
            {
                Console.Write("{0} ", i);
            }
        }

        static void Main(string[] args)
        {
            // WordStart();
            // WordCount();
            // IsPrime();
            // SumOfDigits();
            FindCommonItems();
        }
    }
}