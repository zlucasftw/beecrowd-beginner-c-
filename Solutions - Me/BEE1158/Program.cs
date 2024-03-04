namespace BEE1158
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y, sum;

            String[] values;

            N = int.Parse(Console.ReadLine());

            sum = 0;

            for (int i = 1; i <= N; i++)
            {
                values = Console.ReadLine().Split(' ');

                X = int.Parse(values[0]);

                Y = int.Parse(values[1]);

                for (int j = 1; j <= Y; j++)
                {
                   if (X % 2 == 0)
                   {
                        X += 2;
                   } else
                    {
                        sum += X;
                        X += 2;
                    }
                    
                    
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
