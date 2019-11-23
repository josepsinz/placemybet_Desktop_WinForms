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
    /// Acceso al sistema de persistencia con el modelo Data Access Object, para los Eventos
    /// </summary>
    public class EventoDAO
    {
        /// <summary>
        /// Recupera todos los eventos de la bbdd
        /// </summary>
        /// <returns>Listado de eventos</returns>
        public static List<Evento> GetAll()
        {
            List<Evento> eventos = new List<Evento>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM placemybet.evento");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            int goleslocal = -1;
            int golesvisitante = -1;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(3) && !reader.IsDBNull(5))
                    {
                        goleslocal = reader.GetInt32(3);
                        golesvisitante = reader.GetInt32(5);
                    }
                    Evento e = new Evento(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), golesvisitante, reader.GetString(4), golesvisitante);
                    eventos.Add(e);
                }
            }
            reader.Close();
            return eventos;
        }

        /// <summary>
        /// Recupera un evento en concreto
        /// </summary>
        /// <param name="id">Identificador del evento</param>
        /// <returns>Evento recuperado</returns>
        public static Evento GetEventoById(int id)
        {
            Evento e = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM evento WHERE Id=@id");
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = Database.ExecuteQuery(command);
            int goleslocal = -1;
            int golesvisitante = -1;
            if (reader.HasRows && reader.Read())
            {
                if (!reader.IsDBNull(3) && !reader.IsDBNull(5))
                {
                    goleslocal = reader.GetInt32(3);
                    golesvisitante = reader.GetInt32(5);
                }
                e = new Evento(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), goleslocal, reader.GetString(4), golesvisitante);
            }
            reader.Close();
            return e;
        }

        /// <summary>
        /// Actualiza un evento en concreto
        /// </summary>
        /// <param name="e">Evento a actualizar</param>
        /// <returns>True si la consulta modifica información, y false si no</returns>
        public static bool Update(Evento e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE evento SET Fecha=@fecha, Local=@local, Goles_Local=@goleslocal, Visitante=@visitante, Goles_Visitante=@golesvisitante WHERE Id=@id");
            command.Parameters.AddWithValue("@fecha", e.Fecha);
            command.Parameters.AddWithValue("@local", e.Local);
            command.Parameters.AddWithValue("@goleslocal", e.GolesLocal);
            command.Parameters.AddWithValue("@visitante", e.Visitante);
            command.Parameters.AddWithValue("@golesvisitante", e.GolesVisitante);
            command.Parameters.AddWithValue("@id", e.ID);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }

        /// <summary>
        /// Añade un nuevo evento a la bbdd
        /// </summary>
        /// <param name="e">Evento a añadir</param>
        /// <returns>True si la consulta añade fila, y false si no</returns>
        public static int Insert(Evento e)
        {
            
            MySqlCommand command = new MySqlCommand("INSERT INTO evento (Id, Fecha, Local, Goles_Local, Visitante, Goles_Visitante) VALUES (@id, @fecha, @local, @goleslocal, @visitante, @golesvisitante)");
            //command.Parameters.AddWithValue("@id", e.ID);
            command.Parameters.AddWithValue("@id", e.ID);
            command.Parameters.AddWithValue("@fecha", e.Fecha);
            command.Parameters.AddWithValue("@local", e.Local);
            command.Parameters.AddWithValue("@goleslocal", e.GolesLocal);
            command.Parameters.AddWithValue("@visitante", e.Visitante);
            command.Parameters.AddWithValue("@golesvisitante", e.GolesVisitante);
            int id = Database.ExecuteNonQuery(command);
            return id;
        }

        /// <summary>
        /// Elimina un evento en concreto de la bbdd
        /// </summary>
        /// <param name="e">Evento a eliminar</param>
        /// <returns>True si ha modificado filas, false si no</returns>
        public static bool Delete(Evento e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM mercado WHERE mercado.Id_Evento=@id ; DELETE FROM evento WHERE Id=@id");
            command.Parameters.AddWithValue("@id", e.ID);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }

        public static int SelectMaxId()
        {
            int maxId = 0;
            MySqlCommand command = new MySqlCommand("SELECT MAX(Id) FROM evento");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows && reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    reader.Close();
                    return 0;
                }
                else
                {
                    maxId = reader.GetInt32(0);
                }
                
            }
            reader.Close();
            return maxId;
        }
    }
}

