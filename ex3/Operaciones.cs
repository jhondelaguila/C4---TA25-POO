// Operaciones.cs
using System;

namespace ex3
{
    class Operaciones
    {
        private int num1;
        private int num2;

        public Operaciones(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Suma()
        {
            return num1 + num2;
        }

        public int Resta()
        {
            return num1 - num2;
        }

        public int Multiplicacion()
        {
            return num1 * num2;
        }

        public double Division()
        {
            if (num2 != 0)
            {
                return (double)num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
        }
    }
}
