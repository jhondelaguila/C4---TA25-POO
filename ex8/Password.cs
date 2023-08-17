using System;

namespace ex8
{
    class Password
    {
        private int longitud;
        private string contraseña;

        public int Longitud
        {
            get { return longitud; }
        }

        public string Contraseña
        {
            get { return contraseña; }
        }

        public Password()
        {
            longitud = 8;
            GenerarContraseñaAleatoria();
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            GenerarContraseñaAleatoria();
        }

        private void GenerarContraseñaAleatoria()
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] contraseñaArray = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                contraseñaArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            contraseña = new string(contraseñaArray);
        }
    }
}
