using PlaceMyBet_Desktop.BusinessLayer;
using PlaceMyBet_Desktop.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceMyBet_Desktop.PresentationLayer
{
    /// <summary>
    /// Clase del formulario EDITAR EVENTO
    /// </summary>
    public partial class UpdateEvento : Form
    {

        private DateTime OriginalFecha;
        private string OriginalFechaString;
        private string OriginalLocal;
        private string OriginalGolesLocal;
        private string OriginalVisitante;
        private string OriginalGolesVisitante;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="e"></param>
        public UpdateEvento(Evento e)
        {
            InitializeComponent();

            OriginalFecha = e.Fecha;
            string formatFechaOriginal = OriginalFecha.ToString("yyyy-MM-ddTHH:mm");

            OriginalFechaString = formatFechaOriginal;
            OriginalLocal = e.Local;
            OriginalGolesLocal = e.GolesLocal.ToString();
            OriginalVisitante = e.Visitante;
            OriginalGolesVisitante = e.GolesVisitante.ToString();

            tbIdUpdate.Text = e.ID.ToString();
            tbLocalUpdate.Text = e.Local.ToString();
            tbVisitanteUpdate.Text = e.Visitante.ToString();
            dtimeHoraUpdate.CustomFormat = "HH:mm";
            dtimeHoraUpdate.Format = DateTimePickerFormat.Custom;
            dtimeHoraUpdate.ShowUpDown = true;
            dtimeDiaUpdate.Value = e.Fecha;
            dtimeHoraUpdate.Value = e.Fecha;
            tbGolesLocal.Text = e.GolesLocal.ToString();
            tbGolesVisitante.Text = e.GolesVisitante.ToString();

            tbIdUpdate.Enabled = false;
        }

        /// <summary>
        /// Formatea día y hora a una sola cadena
        /// </summary>
        /// <returns>String único con fecha y hora</returns>
        private string EstructuracionFecha()
        {
            DateTime DiaNuevo = dtimeDiaUpdate.Value;
            string fechaDiaNuevo = DiaNuevo.ToString("yyyy-MM-ddT");

            DateTime HoraNueva = dtimeHoraUpdate.Value;
            string fechaHoraNueva = HoraNueva.ToString("HH:mm");

            return fechaDiaNuevo + fechaHoraNueva;

        }

        /// <summary>
        /// Impide teclear caracteres que no sean numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbGolesLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Impide teclear caracteres que no sean numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbGolesVisitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Actualiza el evento en concreto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string fecha = EstructuracionFecha();

            if (OriginalFechaString == fecha && OriginalLocal == tbLocalUpdate.Text && OriginalVisitante == tbVisitanteUpdate.Text && OriginalGolesLocal == tbGolesLocal.Text && OriginalGolesVisitante == tbGolesVisitante.Text)
            {
                MessageBox.Show("No se han producido cambios", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult res = MessageBox.Show("¿Quieres guardar los cambios realizados?", "Confirmación edición evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Evento evento = new Evento(Int32.Parse(tbIdUpdate.Text), DateTime.Parse(fecha), tbLocalUpdate.Text, Int32.Parse(tbGolesLocal.Text), tbVisitanteUpdate.Text, Int32.Parse(tbGolesVisitante.Text));
                    EventoDAO.Update(evento);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Restablece los valores de los text box a los que había cuando se abre el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            dtimeDiaUpdate.Value = OriginalFecha;
            string horas = OriginalFecha.ToString("HH:mm");
            dtimeHoraUpdate.Value = DateTime.Parse(horas);
            tbLocalUpdate.Text = OriginalLocal;
            tbGolesLocal.Text = OriginalGolesLocal;
            tbVisitanteUpdate.Text = OriginalVisitante;
            tbGolesVisitante.Text = OriginalGolesVisitante;
        }

        /// <summary>
        /// Sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            string fecha = EstructuracionFecha();
            if (OriginalFechaString != fecha || OriginalLocal != tbLocalUpdate.Text || OriginalVisitante != tbVisitanteUpdate.Text || OriginalGolesLocal != tbGolesLocal.Text || OriginalGolesVisitante != tbGolesVisitante.Text)
            {
                DialogResult res = MessageBox.Show("¿Quieres guardar los cambios realizados?", "Confirmación edición evento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Evento evento = new Evento(Int32.Parse(tbIdUpdate.Text), DateTime.Parse(fecha), tbLocalUpdate.Text, Int32.Parse(tbGolesLocal.Text), tbVisitanteUpdate.Text, Int32.Parse(tbGolesVisitante.Text));
                    EventoDAO.Update(evento);
                }
            }
            this.Close();
        }
    }
}


