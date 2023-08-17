using System;

namespace ex5
{
    class Libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;

        public Libro() { }

        public string GetAutor()
        {
            return this.autor;
        }

        public void SetAutor(string nuevoAutor)
        {
            this.autor = nuevoAutor;
        }

        public string GetTitulo()
        {
            return this.titulo;
        }

        public void SetTitulo(string nuevoTitulo)
        {
            this.titulo = nuevoTitulo;
        }

        public string GetUbicacion()
        {
            return this.ubicacion;
        }

        public void SetUbicacion(string nuevaUbicacion)
        {
            this.ubicacion = nuevaUbicacion;
        }
    }
}
