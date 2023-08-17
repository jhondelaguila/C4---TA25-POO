using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Password contraseña1 = new Password();
            Console.WriteLine($"Contraseña 1 (longitud {contraseña1.Longitud}): {contraseña1.Contraseña}");

            Password contraseña2 = new Password(12);
            Console.WriteLine($"Contraseña 2 (longitud {contraseña2.Longitud}): {contraseña2.Contraseña}");
        }
    }
}
