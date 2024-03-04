namespace BEE1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, lowest, highest, sum;

            sum = 0;

            X = int.Parse(Console.ReadLine());

            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                highest = X;
                lowest = Y;
            } else
            {
                highest = Y;
                lowest = X;
            }

            for (int i = lowest; i <= highest; i++)
            {
                if (i % 13 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
