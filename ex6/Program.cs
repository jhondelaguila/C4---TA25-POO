using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche();

            miCoche.Marca = "Toyota";
            miCoche.Modelo = "Corolla";
            miCoche.Cilindrada = 2000;
            miCoche.Potencia = 150.5;

            Console.WriteLine("Detalles del coche:");
            Console.WriteLine($"Marca: {miCoche.Marca}");
            Console.WriteLine($"Modelo: {miCoche.Modelo}");
            Console.WriteLine($"Cilindrada: {miCoche.Cilindrada} cc");
            Console.WriteLine($"Potencia: {miCoche.Potencia} HP");
        }
    }
}
