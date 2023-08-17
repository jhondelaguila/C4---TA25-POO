using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno("Jhon", 30);
            Console.WriteLine(alumno.ToString());
            alumno.mayorEdad();
        }
    }
}