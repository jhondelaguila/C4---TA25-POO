using System;

namespace ex9
{
    class Electrodomestico
    {
        protected double precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected double peso;

        public const string ColorBlanco = "blanco";
        public const string ColorNegro = "negro";
        public const string ColorRojo = "rojo";
        public const string ColorAzul = "azul";
        public const string ColorGris = "gris";

        public const char ConsumoEnergeticoDefault = 'F';

        public Electrodomestico()
        {
            precioBase = 100;
            color = ColorBlanco;
            consumoEnergetico = ConsumoEnergeticoDefault;
            peso = 5;
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            color = ColorBlanco;
            consumoEnergetico = ConsumoEnergeticoDefault;
            this.peso = peso;
        }

        public Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            EstablecerColor(color);
            EstablecerConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        private void EstablecerColor(string color)
        {
            string colorLower = color.ToLower();
            if (colorLower == ColorBlanco || colorLower == ColorNegro ||
                colorLower == ColorRojo || colorLower == ColorAzul || colorLower == ColorGris)
            {
                this.color = colorLower;
            }
            else
            {
                this.color = ColorBlanco; // Valor por defecto si el color no es válido
            }
        }

        private void EstablecerConsumoEnergetico(char consumoEnergetico)
        {
            if (consumoEnergetico >= 'A' && consumoEnergetico <= 'F')
            {
                this.consumoEnergetico = consumoEnergetico;
            }
            else
            {
                this.consumoEnergetico = ConsumoEnergeticoDefault; // Valor por defecto si el consumo energético no es válido
            }
        }

        public double PrecioBase
        {
            get { return precioBase; }
            set { precioBase = value; }
        }

        public string Color
        {
            get { return color; }
            set { EstablecerColor(value); }
        }

        public char ConsumoEnergetico
        {
            get { return consumoEnergetico; }
            set { EstablecerConsumoEnergetico(value); }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
    }
}
