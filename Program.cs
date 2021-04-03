using System;

namespace MILHAS
{
    class Program
    {
        static void Main(string[] args)
        {
             string medida;
             double Milhas;

            Console.WriteLine ( " Digite a medida em milhas: " );
            medida = Console.ReadLine();
            Convert.ToDouble ( medida );
            Milhas = 1.609;
            Console.WriteLine($" A medida em km é: { Convert.ToDouble(medida) * Milhas }");
        }
    }
}
