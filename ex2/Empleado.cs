// Empleado.cs
using System;

namespace ex2
{
    class Empleado
    {
        private string nombre;
        private double sueldo;

        public Empleado(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        override
        public string ToString()
        {
            return $"Nombre: {nombre},sueldo: {sueldo:C}";
        }

        public void PagarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos.");
            }
        }
    }
}
