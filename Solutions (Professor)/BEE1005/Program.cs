using System;

class bee1005 {
        static void Main(string[] args) {

            double A, B, Media;
            
            A = double.Parse(Console.ReadLine());

            B = double.Parse(Console.ReadLine());

            Media = ((A * 3.5) + (B * 7.5)) / 11 ;
            
            Console.WriteLine($"MEDIA = {Media.ToString("F5")}");

         }    
    
}



