using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceMyBet_Desktop.BusinessLayer
{
    /// <summary>
    /// Constructor de Usuario con su constructor y sus propiedades
    /// </summary>
    public class Usuario
    {
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public double Fondos { get; set; }
        public bool Administrador { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Constructor de Usuario
        /// </summary>
        /// <param name="email">Email o nombre de usuario</param>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="apellidos">Apellidos del usuario</param>
        /// <param name="edad">Edad del usuario</param>
        /// <param name="fondos">Fondos disponibles en la cuenta de PlaceMyBet para poder acostar/cobrar</param>
        /// <param name="administrador">Indica si es administrador (true) o no (false)</param>
        /// <param name="password">Contraseña de acceso</param>
        public Usuario(string email, string nombre, string apellidos, int edad, double fondos, bool administrador, string password)
        {
            Email = email;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Fondos = fondos;
            Administrador = administrador;
            Password = password;
        }
    }
}
