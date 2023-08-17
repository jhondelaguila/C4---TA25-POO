using System;

namespace ex7
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string DNI;
        private char sexo;
        private double peso;
        private double altura;

        public const char SexoHombre = 'H';

        public Persona(string dni)
        {
            nombre = "";
            edad = 0;
            DNI = dni;
            sexo = SexoHombre;
            peso = 0;
            altura = 0;
        }

        public Persona(string dni, string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            DNI = dni;
            sexo = SexoHombre;
            peso = 0;
            altura = 0;
        }

        public Persona(string dni, string nombre, int edad, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            DNI = dni;
            sexo = SexoHombre;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Dni
        {
            get { return DNI; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
    }
}
