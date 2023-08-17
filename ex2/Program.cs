using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Jhon", 3000);
            Console.WriteLine(empleado.ToString());
            empleado.PagarImpuestos();
        }
    }
}