using System;

namespace ex10
{
    class Serie
    {
        private string titulo;
        private int numeroTemporadas;
        private bool entregado;
        private string genero;
        private string creador;

        public const int NumeroTemporadasDefault = 3;
        public const bool EntregadoDefault = false;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int NumeroTemporadas
        {
            get { return numeroTemporadas; }
            set { numeroTemporadas = value; }
        }

        public bool Entregado
        {
            get { return entregado; }
            set { entregado = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Creador
        {
            get { return creador; }
            set { creador = value; }
        }

        public Serie()
        {
            titulo = "";
            numeroTemporadas = NumeroTemporadasDefault;
            entregado = EntregadoDefault;
            genero = "";
            creador = "";
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            numeroTemporadas = NumeroTemporadasDefault;
            entregado = EntregadoDefault;
            genero = "";
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadas;
            this.genero = genero;
            this.creador = creador;
            entregado = EntregadoDefault;
        }
    }
}
