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
    /// Acceso al sistema de persistencia con el modelo Data Access Object, para los Usuarios
    /// </summary>
    public class UsuarioDAO
    {
        /// <summary>
        /// Recupera todos los usuarios de la bbdd
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        public static List<Usuario> GetAllUsers()
        {
            List<Usuario> usuarios = new List<Usuario>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM placemybet.usuario where usuario.Administrador = 0");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario u = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4), reader.GetBoolean(5), reader.GetString(6));
                    usuarios.Add(u);
                }
            }
            reader.Close();
            return usuarios;
        }

        public static Usuario GetByEmail(string email)
        {
            Usuario usuario = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM placemybet.usuario where usuario.Email = @email");
            command.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows && reader.Read())
            {
                
                usuario = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4), reader.GetBoolean(5), reader.GetString(6));
                //usuarios.Add(u);
            }
            reader.Close();
            return usuario;
        }

        public static List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM placemybet.usuario");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario u = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4), reader.GetBoolean(5), reader.GetString(6));
                    usuarios.Add(u);
                }
            }
            reader.Close();
            return usuarios;
        }
        public static List<Usuario> GetAllAdmin()
        {
            List<Usuario> usuarios = new List<Usuario>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM placemybet.usuario where usuario.Administrador = 1");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario u = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4), reader.GetBoolean(5), reader.GetString(6));
                    usuarios.Add(u);
                }
            }
            reader.Close();
            return usuarios;
        }

        public static bool Insert(Usuario u)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO usuario (Email, Nombre, Apellidos, Edad, Fondos, Administrador, Password) VALUES (@email, @nombre, @apellidos, @edad, @fondos, @administrador, @password)");
            command.Parameters.AddWithValue("@email", u.Email);
            command.Parameters.AddWithValue("@nombre", u.Nombre);
            command.Parameters.AddWithValue("@apellidos", u.Apellidos);
            command.Parameters.AddWithValue("@edad", u.Edad);
            command.Parameters.AddWithValue("@fondos", u.Fondos);
            command.Parameters.AddWithValue("@administrador", u.Administrador);
            command.Parameters.AddWithValue("@password", u.Password);
            //command.Parameters.AddWithValue("@id", m.ID);
            int rows = Database.ExecuteNonQuery(command);

            return rows >= 1;
        }

        public static bool Update(Usuario u)
        {
            MySqlCommand command = new MySqlCommand("UPDATE usuario SET Nombre=@nombre, Apellidos=@apellidos, Edad=@edad, Fondos=@fondos, Administrador=@administrador WHERE usuario.Email=@email");
            command.Parameters.AddWithValue("@email", u.Email);
            command.Parameters.AddWithValue("@nombre", u.Nombre);
            command.Parameters.AddWithValue("@apellidos", u.Apellidos);
            command.Parameters.AddWithValue("@edad", u.Edad);
            command.Parameters.AddWithValue("@fondos", u.Fondos);
            command.Parameters.AddWithValue("@administrador", u.Administrador);
            command.Parameters.AddWithValue("@password", u.Password);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }

        public static bool Delete(Usuario u)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM usuario WHERE usuario.Email = @email");
            command.Parameters.AddWithValue("@email", u.Email);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }
    }
}

