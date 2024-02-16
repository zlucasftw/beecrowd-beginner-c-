namespace BEE1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, circulo,
               trapezio, quadrado, retangulo;

            string[] vlrs;
            
            vlrs = Console.ReadLine().Split(' ');

            a = double.Parse(vlrs[0]);

            b = double.Parse(vlrs[1]);

            c = double.Parse(vlrs[2]);

            //base(a) x altura(c) / 2
            triangulo = a * c / 2;

            //pi(3.14159) * raio(c)²
            circulo = 3.14159 * c;

            //((baseMaior(a) + baseMenor(b)) * altura (c)) / 2
            trapezio = ((a + b) * c) / 2;

            //lado(b) * lado(b)
            quadrado = b * b;

            //altura (a) * base(b)
            retangulo = a * b;
            
            Console.WriteLine("TRIANGULO" + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO" + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO" + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO" + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO" + retangulo.ToString("F3"));
            Math.Abs(triangulo - quadrado - circulo);
        }
    }
}