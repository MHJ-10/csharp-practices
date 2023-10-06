namespace HelloWolrd
{

    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = GetNumbers();

            Console.WriteLine(string.Join(" ", numbers));

        }

        public static bool IsPalindrome(int number)

        {
            string strNumber = number.ToString();
            string reversedNumber = new(strNumber.Reverse().ToArray());

            bool isPalindrome = strNumber == reversedNumber;

            return isPalindrome;
        }

        public static bool IsPrime(int number)
        {

            if (number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }

                }
            }

            return true;
        }

        public static List<int> GetNumbers()
        {
            Console.WriteLine("enter first number.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number.");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            List<int> numbers = new();
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (IsPalindrome(i) || IsPrime(i))
                {
                    numbers.Add(i);
                }

            }
            if (secondNumber <= firstNumber)
            {
                Console.WriteLine("second number must be greater than first number.");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("not found.");
            }

            return numbers;
        }

    }
}

