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
using System.Globalization;

namespace PlaceMyBet_Desktop.PresentationLayer
{
    /// <summary>
    /// Clase del formulario AÑADIR EVENTO
    /// </summary>
    public partial class AddEvento : Form
    {
        /// <summary>
        /// Constructor del formulario.
        /// Se configuran de los selectores de fecha y hora
        /// </summary>
        public AddEvento()
        {
            InitializeComponent();
            tbId.Text = (EventoDAO.SelectMaxId() + 1).ToString();
            dtimeDia.MinDate = DateTime.Now;
            dtimeHora.CustomFormat = "HH:mm";
            dtimeHora.Format = DateTimePickerFormat.Custom;
            dtimeHora.ShowUpDown = true;
            tbId.Enabled = false;
        }

        /// <summary>
        /// Impide teclear carácteres que no sean numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Agrupa los selectores de día y hora en una sola cadena
        /// </summary>
        /// <returns>String único con día y fecha</returns>
        private string EstructuracionFecha()
        {
            DateTime DiaNuevo = dtimeDia.Value;
            string fechaDiaNuevo = DiaNuevo.ToString("yyyy-MM-ddT");

            DateTime HoraNueva = dtimeHora.Value;
            string fechaHoraNueva = HoraNueva.ToString("HH:mm");

            return fechaDiaNuevo + fechaHoraNueva;
        }

        /// <summary>
        /// Guarda el nuevo evento 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(tbLocal.Text == "" || tbVisitante.Text == "")
            {
                MessageBox.Show("Para guardar debe rellenar los campos 'Local' y 'Visitante', gracias", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Evento evento = null;
                string fecha = null;
                DialogResult res = MessageBox.Show("¿Estás seguro que quieres añadir el evento?", "Confirmación nuevo evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    fecha = EstructuracionFecha();
                    evento = new Evento(Int32.Parse(tbId.Text),DateTime.Parse(fecha), tbLocal.Text, -1, tbVisitante.Text, -1);
                    int lastId = EventoDAO.Insert(evento);
                    MercadoDAO.Insert(lastId);
                    this.Close();
                }
            }
            
        }

        /// <summary>
        /// Limpia los campos del formulario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtimeDia.Value = DateTime.Now;
            dtimeHora.Value = DateTime.Now;
            tbLocal.Clear();
            tbVisitante.Clear();
        }

        /// <summary>
        /// Sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (tbLocal.Text != "" && tbVisitante.Text != "")
            {
                Evento evento = null;
                string fecha = null;
                DialogResult res = MessageBox.Show("¿Quieres guardar los cambios realizados?", "Confirmación nuevo evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    fecha = EstructuracionFecha();
                    evento = new Evento(Int32.Parse(tbId.Text), DateTime.Parse(fecha), tbLocal.Text, -1, tbVisitante.Text, -1);
                    int lastId = EventoDAO.Insert(evento);
                    MercadoDAO.Insert(lastId);
                    this.Close();
                }
            }
            this.Close();
        }
    }
}
