using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("12345678A");
            Console.WriteLine("Persona 1:");
            Console.WriteLine($"Nombre: {persona1.Nombre}");
            Console.WriteLine($"Edad: {persona1.Edad}");
            Console.WriteLine($"DNI: {persona1.Dni}");
            Console.WriteLine($"Sexo: {persona1.Sexo}");
            Console.WriteLine($"Peso: {persona1.Peso}");
            Console.WriteLine($"Altura: {persona1.Altura}");
            Console.WriteLine();

            Persona persona2 = new Persona("12345678A","Juan", 30);
            Console.WriteLine("Persona 2:");
            Console.WriteLine($"Nombre: {persona2.Nombre}");
            Console.WriteLine($"Edad: {persona2.Edad}");
            Console.WriteLine($"DNI: {persona2.Dni}");
            Console.WriteLine($"Sexo: {persona2.Sexo}");
            Console.WriteLine($"Peso: {persona2.Peso}");
            Console.WriteLine($"Altura: {persona2.Altura}");
            Console.WriteLine();

            Persona persona3 = new Persona("12345678A","María", 25, 55.5, 1.65);
            Console.WriteLine("Persona 3:");
            Console.WriteLine($"Nombre: {persona3.Nombre}");
            Console.WriteLine($"Edad: {persona3.Edad}");
            Console.WriteLine($"DNI: {persona3.Dni}");
            Console.WriteLine($"Sexo: {persona3.Sexo}");
            Console.WriteLine($"Peso: {persona3.Peso}");
            Console.WriteLine($"Altura: {persona3.Altura}");
        }
    }
}
