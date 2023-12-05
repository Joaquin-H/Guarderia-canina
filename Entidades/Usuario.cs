using System;

namespace BTS_3k2_PAV.Entidades
{
    public class Usuario
    {
        private long _id;

        public long Id { 
            get { return _id; }
            set { _id = value; }  
        }

        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Contrasenia { get; set; }
        public string Email { get; set; }

        public bool Estado { get; set; }

        public Perfil Perfil { get; set; }

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(NombreUsuario))
                throw new ApplicationException("El nombre de usuario es requerido.");
            if (NombreUsuario.Length > 50)
                throw new ApplicationException("El nombre de usuario no debe superar los 50 caracteres.");
        }


        public void ValidarPassword()
        {
            if (string.IsNullOrEmpty(this.Contrasenia))
                throw new ApplicationException("La contraseña es requerida");
            if (this.Contrasenia.Length > 10)
                throw new ApplicationException("Contraseña inválida. La contraseña no debe superar los 10 caracteres");
        }

        public void ValidarEmail()
        {
            if (!string.IsNullOrEmpty(this.Email) && this.Email.Length > 50)
                throw new ApplicationException("Email inválido. El email no debe superar los 50 caracteres");
        }

    }
}
