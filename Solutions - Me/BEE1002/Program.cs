using System; 

class BEE1002 {

    static void Main(string[] args) {
        
        float R = float.Parse(Console.ReadLine());

        R = toString(4);
        
        float n = 3.14159f;
        
        float A = n * (R * R);
        
        Console.WriteLine($"A={A}");
    }
}