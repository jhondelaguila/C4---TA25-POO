// Persona.cs
using System;

namespace ex4
{
    class Persona
    {
        private string nombre;

        public Persona() { }

        public void SetNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}");
        }
    }
}
