using System;

namespace ex1
{
	public class Alumno
	{
		private string nombre;
		private int edad;

		public Alumno(string nombre, int edad)
		{
			this.nombre = nombre;
			this.edad = edad;
		}

		override
		public string ToString()
		{
			return $"nombre: {nombre}, edad: {edad}";
		}

		public void mayorEdad()
		{
			if (this.edad >= 18) Console.WriteLine("Es mayor de edad");
			else Console.WriteLine("No es mayor de edad");
        }
	}
}

