using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones(2, 3);
            Console.WriteLine(operaciones.Suma());
            Console.WriteLine(operaciones.Resta());
            Console.WriteLine(operaciones.Multiplicacion());
            Console.WriteLine(operaciones.Division());
        }
    }
}