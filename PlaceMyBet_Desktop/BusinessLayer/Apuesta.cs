using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceMyBet_Desktop.BusinessLayer
{
    /// <summary>
    /// Clase Apuesta con su constructor y sus propiedades
    /// </summary>
    public class Apuesta
    {
        public int ID { get; set; }
        public float TipoMercado { get; set; }
        public bool Tipo { get; set; }
        public float Cuota { get; set; }
        public double Apostado { get; set; }
        public int ID_Mercado { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Contructor de Apuesta
        /// </summary>
        /// <param name="iD">Identificador de la apuesta</param>
        /// <param name="tipoMercado">Tipo de mercado(1.5,2.5,3.5)</param>
        /// <param name="tipo">Booleano(true=Apuesta a Over//false=Apuesta a Under</param>
        /// <param name="cuota">Cuota en el momento de la apuesta</param>
        /// <param name="apostado">Cantidad apostada</param>
        /// <param name="iD_Mercado">Identificador del mercado al que pertenece la apuesta</param>
        /// <param name="email">Email, o nombre de usuario, del usuario que realiza la apuesta</param>
        public Apuesta(int iD, float tipoMercado, bool tipo, float cuota, double apostado, int iD_Mercado, string email)
        {
            ID = iD;
            TipoMercado = tipoMercado;
            Tipo = tipo;
            Cuota = cuota;
            Apostado = apostado;
            ID_Mercado = iD_Mercado;
            Email = email;
        }
    }
}
