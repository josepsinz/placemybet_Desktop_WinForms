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
    /// Acceso al sistema de persistencia con el modelo Data Access Object, para las Apuestas
    /// </summary>
    public class ApuestaDAO
    {
        /// <summary>
        /// Recupera todas las apuestas de la base de datos
        /// </summary>
        /// <returns>Listado de apuestas</returns>
        public static List<Apuesta> GetAll()
        {
            List<Apuesta> apuestas = new List<Apuesta>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM placemybet.apuesta");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Apuesta a = new Apuesta(reader.GetInt32(0), reader.GetFloat(1), reader.GetBoolean(2), reader.GetFloat(3), reader.GetDouble(4), reader.GetInt32(5), reader.GetString(6));
                    apuestas.Add(a);
                }
            }
            reader.Close();
            return apuestas;
        }

        /// <summary>
        /// Recupera las apuestas a un mercado específico
        /// </summary>
        /// <param name="id">Identificador del mercado</param>
        /// <returns>Listado de apuestas</returns>
        public static List<Apuesta> GetByEvento(int id)
        {
            List<Apuesta> apuestas = new List<Apuesta>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM apuesta,mercado WHERE apuesta.Id_Mercado=mercado.Id and mercado.Id_Evento=@id");
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Apuesta a = new Apuesta(reader.GetInt32(0), reader.GetFloat(1), reader.GetBoolean(2), reader.GetFloat(3), reader.GetDouble(4), reader.GetInt32(5), reader.GetString(6));
                    apuestas.Add(a);
                }
            }
            reader.Close();
            return apuestas;
        }

        public static List<Apuesta> GetByMercado(int id)
        {
            List<Apuesta> apuestas = new List<Apuesta>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM apuesta WHERE Id_Mercado=@id");
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Apuesta a = new Apuesta(reader.GetInt32(0), reader.GetFloat(1), reader.GetBoolean(2), reader.GetFloat(3), reader.GetDouble(4), reader.GetInt32(5), reader.GetString(6));
                    apuestas.Add(a);
                }
            }
            reader.Close();
            return apuestas;
        }

        /// <summary>
        /// Recupera las apuestas de un usuario en concreto
        /// </summary>
        /// <param name="user">Email de usuario</param>
        /// <returns>Listado de apuestas</returns>
        public static List<Apuesta> GetByUser(string user)
        {
            List<Apuesta> apuestas = new List<Apuesta>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM placemybet.apuesta WHERE apuesta.Email=@email");
            command.Parameters.AddWithValue("@email", user);
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Apuesta a = new Apuesta(reader.GetInt32(0), reader.GetFloat(1), reader.GetBoolean(2), reader.GetFloat(3), reader.GetDouble(4), reader.GetInt32(5), reader.GetString(6));
                    apuestas.Add(a);
                }
            }
            reader.Close();
            return apuestas;
        }
    }
}

