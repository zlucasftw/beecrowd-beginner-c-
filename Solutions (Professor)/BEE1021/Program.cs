namespace BEE1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            int quociente, resto, nota, moeda, reais, centavos;

            n = double.Parse(Console.ReadLine());

            // Corrigir problema de arredondamento
            // 576,81 * 100 = 57680.99999999
            // Casting do C# arredonda para 57680 e era pra ser 87681

            //576.73 * 100 = 57673
            resto = (int)(n * 100.0 + 0.5); // Casting =  Forçando o resultado como inteiro

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota}.00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota}.00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota}.00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota}.00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota}.00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ {nota}.00");
            resto = resto % (nota * 100);

            // Moedas
            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine($"{resto} moeda(s) de R$ 0.01");
        }
    }
}