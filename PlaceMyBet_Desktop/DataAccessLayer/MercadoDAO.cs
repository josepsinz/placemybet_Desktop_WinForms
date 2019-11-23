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
    /// Acceso al sistema de persistencia con el modelo Data Access Object, para los Mercados
    /// </summary>
    public class MercadoDAO
    {
        /// <summary>
        /// Recupera todos los mercados de la bbdd
        /// </summary>
        /// <returns>Lista de mercados</returns>
        public static List<Mercado> GetAll()
        {
            List<Mercado> mercados = new List<Mercado>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM placemybet.mercado");
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Mercado m = new Mercado(reader.GetInt32(0), reader.GetFloat(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetInt32(6));
                    mercados.Add(m);
                }
            }
            reader.Close();
            return mercados;
        }

        /// <summary>
        /// Recupera un mercado específico
        /// </summary>
        /// <param name="id">Identificador del mercado a recuperar</param>
        /// <returns>Mercado recuperado</returns>
        public static Mercado GetMercadoById(int id)
        {
            Mercado m = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM mercado WHERE mercado.Id=@id");
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows && reader.Read())
            {
                m = new Mercado(reader.GetInt32(0), reader.GetFloat(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetInt32(6));

            }
            reader.Close();
            return m;
        }

        /// <summary>
        /// Recupera todos los mercados de un evento concreto
        /// </summary>
        /// <param name="id">Identificador del evento</param>
        /// <returns>Lista de mercados</returns>
        public static List<Mercado> GetMercadosByEventoId(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT mercado.* FROM mercado, evento WHERE mercado.Id_Evento=evento.Id AND evento.Id=@id");
            command.Parameters.AddWithValue("@id", id);
            List<Mercado> mercados = new List<Mercado>();
            MySqlDataReader reader = Database.ExecuteQuery(command);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Mercado m = new Mercado(reader.GetInt32(0), reader.GetFloat(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetDouble(4), reader.GetDouble(5), reader.GetInt32(6));
                    mercados.Add(m);
                }
            }
            reader.Close();
            return mercados;
        }

        /// <summary>
        /// Actualiza la información de un mercado en concreto
        /// </summary>
        /// <param name="m">Mercado a actualizar</param>
        /// <returns>True si el método modifica filas, false si no</returns>
        public static bool Update(Mercado m)
        {
            MySqlCommand command = new MySqlCommand("UPDATE mercado SET Mercado=@mercado, Cuota_Over=@cuotaOver, Cuota_Under=@cuotaUnder, Dinero_Over=@dineroOver, Dinero_Under=@dineroUnder, Id_Evento=@idEvento where Id=@id");
            command.Parameters.AddWithValue("@mercado", m.Tipo);
            command.Parameters.AddWithValue("@cuotaOver", m.CuotaOver);
            command.Parameters.AddWithValue("@cuotaUnder", m.CuotaUnder);
            command.Parameters.AddWithValue("@dineroOver", m.DineroOver);
            command.Parameters.AddWithValue("@dineroUnder", m.DineroUnder);
            command.Parameters.AddWithValue("@idEvento", m.ID_Evento);
            command.Parameters.AddWithValue("@id", m.ID);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }

        /// <summary>
        /// Añade un nuevo mercado a la bbdd
        /// </summary>
        /// <param name="m">Mercado a añadir</param>
        /// <returns>True si se modifican filas, false si no</returns>
        public static bool Insert(int id)
        {
            int rows = 0;
            float[] tiposDeMercado = new float[] { 1.5F, 2.5F, 3.5F };
            int maxId = MercadoDAO.SelectMaxId();
            int[] identificadores = new int[] { maxId + 1, maxId + 2, maxId + 3 };
            for (int i = 0; i < tiposDeMercado.Length; i++)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO mercado (Id, Mercado, Cuota_Over, Cuota_Under, Dinero_Over, Dinero_Under, Id_Evento) VALUES (@id,@mercado, @cuotaOver, @cuotaUnder, @dineroOver, @dineroUnder, @id_Evento)");
                command.Parameters.AddWithValue("@id", identificadores[i]);
                command.Parameters.AddWithValue("@mercado", tiposDeMercado[i]);
                command.Parameters.AddWithValue("@cuotaOver", 1.9);
                command.Parameters.AddWithValue("@cuotaUnder", 1.9);
                command.Parameters.AddWithValue("@dineroOver", 100);
                command.Parameters.AddWithValue("@dineroUnder", 100);
                command.Parameters.AddWithValue("@id_Evento", id);
                //command.Parameters.AddWithValue("@id", m.ID);
                rows = Database.ExecuteNonQuery(command);
            }

            return rows >= 1;
        }

        public static bool InsertMercado(Mercado m)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO mercado (Id, Mercado, Cuota_Over, Cuota_Under, Dinero_Over, Dinero_Under, Id_Evento) VALUES (@id, @mercado, @cuotaOver, @cuotaUnder, @dineroOver, @dineroUnder, @id_Evento)");
            command.Parameters.AddWithValue("@id", m.ID);
            command.Parameters.AddWithValue("@mercado", m.Tipo);
            command.Parameters.AddWithValue("@cuotaOver", 1.9);
            command.Parameters.AddWithValue("@cuotaUnder", 1.9);
            command.Parameters.AddWithValue("@dineroOver", 100);
            command.Parameters.AddWithValue("@dineroUnder", 100);
            command.Parameters.AddWithValue("@id_Evento", m.ID_Evento);
            //command.Parameters.AddWithValue("@id", m.ID);
            int rows = Database.ExecuteNonQuery(command);

            return rows >= 1;
        }


        /// <summary>
        /// Elimina un mercado en concreto de la bbdd
        /// </summary>
        /// <param name="m">Mercado a eliminar</param>
        /// <returns>True si se modifican filas, false si no</returns>
        public static bool Delete(Mercado m)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM mercado WHERE Id=@id");
            command.Parameters.AddWithValue("@id", m.ID);
            int rows = Database.ExecuteNonQuery(command);
            return rows >= 1;
        }

        public static int SelectMaxId()
        {
            int maxId = 0;
            MySqlCommand command = new MySqlCommand("SELECT MAX(Id) FROM mercado");
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

