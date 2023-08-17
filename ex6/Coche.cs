using System;

namespace ex6
{
    class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        public Coche() { }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public double Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }
    }
}
