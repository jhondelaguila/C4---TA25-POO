using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie serie1 = new Serie();
            Console.WriteLine("Serie 1:");
            Console.WriteLine($"Título: {serie1.Titulo}");
            Console.WriteLine($"Número de Temporadas: {serie1.NumeroTemporadas}");
            Console.WriteLine($"Entregado: {serie1.Entregado}");
            Console.WriteLine($"Género: {serie1.Genero}");
            Console.WriteLine($"Creador: {serie1.Creador}");
            Console.WriteLine();

            Serie serie2 = new Serie("Game of Thrones", "George R. R. Martin");
            Console.WriteLine("Serie 2:");
            Console.WriteLine($"Título: {serie2.Titulo}");
            Console.WriteLine($"Número de Temporadas: {serie2.NumeroTemporadas}");
            Console.WriteLine($"Entregado: {serie2.Entregado}");
            Console.WriteLine($"Género: {serie2.Genero}");
            Console.WriteLine($"Creador: {serie2.Creador}");
            Console.WriteLine();

            Serie serie3 = new Serie("Stranger Things", 5, "Ciencia Ficción", "The Duffer Brothers");
            Console.WriteLine("Serie 3:");
            Console.WriteLine($"Título: {serie3.Titulo}");
            Console.WriteLine($"Número de Temporadas: {serie3.NumeroTemporadas}");
            Console.WriteLine($"Entregado: {serie3.Entregado}");
            Console.WriteLine($"Género: {serie3.Genero}");
            Console.WriteLine($"Creador: {serie3.Creador}");
        }
    }
}
