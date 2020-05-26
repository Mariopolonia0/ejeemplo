using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double centigrado;
            double faradar;
            string entrada;

            Console.Write("\n\n\t\tDigite El Grado Celsius Para Convertilo Grados Fahrenheit:");
            entrada = Console.ReadLine();
            centigrado = Convert.ToDouble(entrada);
            faradar = (1.8 * centigrado ) + 32;
            Console.Write("\nEste Es El Grados Fahrenheit Otenido:" + faradar);
        }
    }
}
