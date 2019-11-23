using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceMyBet_Desktop.BusinessLayer
{
    /// <summary>
    /// Clase Mercado con su constructor y propiedades
    /// </summary>
    public class Mercado
    {
        public int ID { get; set; }
        public float Tipo { get; set; }
        public float CuotaOver { get; set; }
        public float CuotaUnder { get; set; }
        public double DineroOver { get; set; }
        public double DineroUnder { get; set; }
        public int ID_Evento { get; set; }

        /// <summary>
        /// Constructor de Mercado
        /// </summary>
        /// <param name="iD">Identificador del mercado</param>
        /// <param name="tipo">Tipo de mercado(1.5,2.5,3.5)</param>
        /// <param name="cuotaOver">Cuota actual que se paga a Over</param>
        /// <param name="cuotaUnder">Cuota actual que se paga a Under</param>
        /// <param name="dineroOver">Dinero acumulado de las apuestas a Over</param>
        /// <param name="dineroUnder">Dinero acumulado de las apuestas a Under</param>
        /// <param name="iD_Evento">Identificador del evento al que pertenece el mercado</param>
        public Mercado(int iD, float tipo, float cuotaOver, float cuotaUnder, double dineroOver, double dineroUnder, int iD_Evento)
        {
            ID = iD;
            Tipo = tipo;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            DineroOver = dineroOver;
            DineroUnder = dineroUnder;
            ID_Evento = iD_Evento;
        }

        /// <summary>
        /// Constructor de Mercado
        /// </summary>
        /// <param name="iD">Identificador del mercado</param>
        /// <param name="tipo">Tipo de mercado(1.5,2.5,3.5)</param>
        /// <param name="cuotaOver">Cuota actual que se paga a Over</param>
        /// <param name="cuotaUnder">Cuota actual que se paga a Under</param>
        /// <param name="dineroOver">Dinero acumulado de las apuestas a Over</param>
        /// <param name="dineroUnder">Dinero acumulado de las apuestas a Under</param>
        /// <param name="iD_Evento">Identificador del evento al que pertenece el mercado</param>
        public Mercado(float tipo, float cuotaOver, float cuotaUnder, double dineroOver, double dineroUnder, int iD_Evento)
        {
            Tipo = tipo;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            DineroOver = dineroOver;
            DineroUnder = dineroUnder;
            ID_Evento = iD_Evento;
        }
    }
}
