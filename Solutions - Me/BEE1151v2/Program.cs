namespace BEE1151v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, number1, number2, sum;
            N = int.Parse(Console.ReadLine());

            number1 = 0;

            number2 = 1;

            sum = 0;

            for (int i = 0; i < N; i++)
            {
                if (i == N - 1)
                {
                    Console.WriteLine(number1);
                }
                else
                {
                    Console.Write($"{number1} ");
                    sum = number2;

                    number2 = number1;

                    number1 = sum + number2;
                }
            }
        }
    }
}
