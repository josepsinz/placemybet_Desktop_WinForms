using MySql.Data.MySqlClient;
using PlaceMyBet_Desktop.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceMyBet_Desktop.DataAccessLayer
{
    /// <summary>
    /// Acceso al sistema de persistencia con el modelo Data Access Object, para comprobar los logins de la aplicación
    /// </summary>
    public class LoginDAO
    {
        /// <summary>
        /// Muestra si un usuario es administrador
        /// </summary>
        /// <param name="email">Email o nombre de usuario, del usuario a chequear</param>
        /// <returns>True si es administrador, false si no lo es</returns>
        public static bool GetAdmin(string email)
        {
            bool resultado = false;
            MySqlCommand command = new MySqlCommand("SELECT usuario.Administrador FROM usuario WHERE Email=@email");
            command.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(0))
                    {
                        resultado = true;
                    }
                }
            }
            reader.Close();
            return resultado;
        }

        /// <summary>
        /// Comprueba que el nombre de usuario corresponde a la contraseña insertada
        /// </summary>
        /// <param name="email">Nombre de usuario o email, del usuario que se logea</param>
        /// <param name="password">Contraseña del usuario que intenta acceder</param>
        /// <returns>True si la información coincide, false si no</returns>
        public static string GetPassword(string email, string password)
        {
            string resultado = "";
            MySqlCommand command = new MySqlCommand("SELECT usuario.Password FROM usuario WHERE Email=@email AND Administrador=1");
            command.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.Read())
            {
                resultado = reader.GetString(0);
            }
            reader.Close();
            return resultado;
        }
    }
}
