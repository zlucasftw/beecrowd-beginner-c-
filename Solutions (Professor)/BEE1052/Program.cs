namespace BEE1052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if - else

            int mes;

            mes = int.Parse(Console.ReadLine());

            #region

/*            if (mes == 1)
            {
                Console.WriteLine("January");
            } else if (mes == 2)
            {
                Console.WriteLine("February");
            }
            else if (mes == 3)
            {
                Console.WriteLine("March");
            }
            else if (mes == 4)
            {
                Console.WriteLine("April");
            }
            else if (mes == 5)
            {
                Console.WriteLine("May");
            }
            else if (mes == 6)
            {
                Console.WriteLine("June");
            }
            else if (mes == 7)
            {
                Console.WriteLine("July");
            }
            else if (mes == 8)
            {
                Console.WriteLine("August");
            }
            else if (mes == 9)
            {
                Console.WriteLine("September");
            }
            else if (mes == 10)
            {
                Console.WriteLine("October");
            }
            else if (mes == 11)
            {
                Console.WriteLine("November");
            }
            else if (mes == 12)
            {
                Console.WriteLine("December");
            }*/
            #endregion

            switch (mes)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Mês invâlido");
                    break;
            }
        }
    }
}