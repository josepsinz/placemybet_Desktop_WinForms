using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceMyBet_Desktop.BusinessLayer
{
    /// <summary>
    /// Clase Evento con su constructor y propiedades
    /// </summary>
    public class Evento
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Local { get; set; }
        public int GolesLocal { get; set; }
        public string Visitante { get; set; }
        public int GolesVisitante { get; set; }

        /// <summary>
        /// Constructor de Evento
        /// </summary>
        /// <param name="iD">Identificador del partido</param>
        /// <param name="fecha">Día y hora del encuentro</param>
        /// <param name="local">Equipo local</param>
        /// <param name="golesLocal">Goles marcados por equipo local</param>
        /// <param name="visitante">Equipo visitante</param>
        /// <param name="golesVisitante">Goles marcados por equipo visitante</param>
        public Evento(int iD, DateTime fecha, string local, int golesLocal, string visitante, int golesVisitante)
        {
            ID = iD;
            Fecha = fecha;
            Local = local;
            GolesLocal = golesLocal;
            Visitante = visitante;
            GolesVisitante = golesVisitante;
        }

        /// <summary>
        /// Constructor de Evento
        /// </summary>
        /// <param name="iD">Identificador del partido</param>
        /// <param name="fecha">Día y hora del encuentro</param>
        /// <param name="local">Equipo local</param>
        /// <param name="golesLocal">Goles marcados por equipo local</param>
        /// <param name="visitante">Equipo visitante</param>
        /// <param name="golesVisitante">Goles marcados por equipo visitante</param>
        public Evento(DateTime fecha, string local, int golesLocal, string visitante, int golesVisitante)
        {
            Fecha = fecha;
            Local = local;
            GolesLocal = golesLocal;
            Visitante = visitante;
            GolesVisitante = golesVisitante;
        }


    }
}
