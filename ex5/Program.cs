using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();
            libro.SetAutor(autor);

            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();
            libro.SetTitulo(titulo);

            Console.Write("Ingrese la ubicación del libro: ");
            string ubicacion = Console.ReadLine();
            libro.SetUbicacion(ubicacion);

            Console.WriteLine();
            Console.WriteLine("Detalles del libro:");
            Console.WriteLine($"Autor: {libro.GetAutor()}");
            Console.WriteLine($"Título: {libro.GetTitulo()}");
            Console.WriteLine($"Ubicación: {libro.GetUbicacion()}");
        }
    }
}
