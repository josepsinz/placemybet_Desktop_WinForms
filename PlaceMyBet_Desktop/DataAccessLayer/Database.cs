using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceMyBet_Desktop.DataAccessLayer
{
    /// <summary>
    /// Clase que utilizamos para la conexión al sistema de persistencia
    /// </summary>
    public class Database
    {
        private static MySqlConnection connection;

        /// <summary>
        /// Método para abrir la conexión a la bbdd
        /// </summary>
        public static void Connect() //especificar en argumentos [string userId, string password]
        {
            string connectionString = "server=localhost;user=root;database=placemybet;Convert Zero Datetime=True";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        /// <summary>
        /// Método para cerrar la conexión a la bbdd
        /// </summary>
        public static void Disconnect()
        {
            connection.Close();
        }

        /// <summary>
        /// Método para ejecutar consultas que devuelven filas
        /// </summary>
        /// <param name="command">Comando en sintaxis SQL</param>
        /// <returns>Ejecución del comando</returns>
        public static MySqlDataReader ExecuteQuery(MySqlCommand command)
        {
            command.Connection = connection;
            command.Prepare();
            return command.ExecuteReader();
        }

        /// <summary>
        /// Método para ejecutar consultas que no devuelven filas
        /// </summary>
        /// <param name="command">Comando en sintaxis SQL</param>
        /// <returns>Ejecución del comando</returns>
        public static int ExecuteNonQuery(MySqlCommand command)
        {
            command.Connection = connection;
            command.Prepare();
            command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            return (int)id;
        }
    }
}
