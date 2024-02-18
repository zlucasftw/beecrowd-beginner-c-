namespace BEE1144v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, second, third;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                second = i * i;
                third = i * i * i;
                Console.WriteLine($"{i} {second} {third}");
                Console.WriteLine($"{i} {second + 1} {third + 1}");
            }
        }
    }
}
