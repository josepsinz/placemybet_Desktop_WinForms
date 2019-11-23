using CrystalDecisions.CrystalReports.Engine;
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
    /// Clase del formulario principal PLACE MY BET
    /// </summary>
    public partial class MainForm : Form
    {
        private List<Evento> eventos;
        private List<Mercado> mercados;
        private List<Apuesta> apuestas;

        private int id;
        private int id_mercado;
        private int num_apuestasByMercado;

        private string userlogged;
        /// <summary>
        /// Constructor del formulario.
        /// Rellena el grid de Eventos
        /// </summary>
        public MainForm(string usuariologed)
        {
            userlogged = usuariologed;
            DataAccessLayer.Database.Connect();
            eventos = EventoDAO.GetAll();

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            foreach (Evento e in eventos)
            {
                string partido = e.Local + " - " + e.Visitante;
                dgvEventos.Rows.Add(partido, e.Fecha, e.ID);
            }
        }

        /// <summary>
        /// Actualiza el grid de Eventos
        /// </summary>
        private void FillData()
        {
            eventos = EventoDAO.GetAll();
            dgvEventos.Rows.Clear();
            foreach (Evento e in eventos)
            {
                string partido = e.Local + " - " + e.Visitante;
                dgvEventos.Rows.Add(partido, e.Fecha, e.ID);
            }
        }

        /// <summary>
        /// Actualiza el grid de Mercados
        /// </summary>
        private void FillDataMercados()
        {
            mercados = MercadoDAO.GetMercadosByEventoId(id);
            dgvMercados.Rows.Clear();
            foreach (Mercado m in mercados)
            {
                apuestas = ApuestaDAO.GetByMercado(m.ID);
                dgvMercados.Rows.Add(m.ID, m.Tipo, m.CuotaOver, m.CuotaUnder, m.DineroOver, m.DineroUnder, apuestas.Count, m.ID_Evento);
            }
        }

        /// <summary>
        /// Evalúa la nueva selección en el grid de Eventos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEventos_SelectionChanged(object sender, EventArgs e)
        {
            dgvMercados.Rows.Clear();
            id = (int)dgvEventos.CurrentRow.Cells[2].Value;
            Evento seleccionado = EventoDAO.GetEventoById(id);

            if (seleccionado == null)
            {
                tbSeleccionado.Text = "";
                tbSeleccionado2.Text = "";
            }
            else
            {
                tbSeleccionado.Text = "PARTIDO: " + seleccionado.Local + " - " + seleccionado.Visitante + "\r\n" + "ID EVENTO: " + seleccionado.ID.ToString();
                tbSeleccionado2.Text = "PARTIDO: " + seleccionado.Local + " - " + seleccionado.Visitante + " ----- ID EVENTO: " + seleccionado.ID.ToString();

                List<Mercado> mercados = MercadoDAO.GetMercadosByEventoId(id);
                if (mercados.Count != 0)
                {
                    dgvMercados.Visible = true;
                    foreach (Mercado m in mercados)
                    {
                        apuestas = ApuestaDAO.GetByMercado(m.ID);
                        dgvMercados.Rows.Add(m.ID, m.Tipo, m.CuotaOver, m.CuotaUnder, m.DineroOver, m.DineroUnder, apuestas.Count, m.ID_Evento);
                    }
                }
                else
                {
                    tbMercadoSeleccionado.Text = "";
                }
            }
        }

        /// <summary>
        /// Evalúa la nueva selección en el grid de Mercados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMercados_SelectionChanged(object sender, EventArgs e)
        {
            id_mercado = Int32.Parse(dgvMercados.CurrentRow.Cells[0].Value.ToString());
            num_apuestasByMercado = Int32.Parse(dgvMercados.CurrentRow.Cells[6].Value.ToString());
            tbMercadoSeleccionado.Text = "ID MERCADO: " + id_mercado.ToString();
        }

        /// <summary>
        /// Elimina el evento seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            apuestas = ApuestaDAO.GetByEvento(id);
            if (apuestas.Count > 0)
            {
                MessageBox.Show("No puede eliminar un evento cuyos mercados contengan apuestas", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el evento seleccionado?\nSe borrarán los mercados asociados en caso de existir", "Confirmación borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Evento evento = EventoDAO.GetEventoById(id);
                    EventoDAO.Delete(evento);
                    FillData();
                }
            }
        }

        /// <summary>
        /// Abre el formulario para añadir un nuevo evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoEvento_Click(object sender, EventArgs e)
        {
            AddEvento newForm = new AddEvento();
            newForm.ShowDialog(this);
            FillData();
            FillDataMercados();
        }

        /// <summary>
        /// Abre el formulario para editar un evento concreto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditarEvento_Click(object sender, EventArgs e)
        {
            Evento evento = EventoDAO.GetEventoById(id);
            UpdateEvento newForm = new UpdateEvento(evento);
            newForm.ShowDialog(this);
            FillData();
        }

        /// <summary>
        /// Abre el formulario para añadir un nuevo mercado a un evento en concreto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoMercado_Click(object sender, EventArgs e)
        {
            bool edita = false;
            if (MercadoDAO.GetMercadosByEventoId(id).Count >= 3)
            {
                MessageBox.Show("No se pueden crear más mercados para el evento seleccionado", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AddMercado newForm = new AddMercado(id, edita);
                newForm.ShowDialog(this);
                FillDataMercados();
            }
        }

        /// <summary>
        /// Elimina el mercado seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarMercado_Click(object sender, EventArgs e)
        {
            if (tbMercadoSeleccionado.Text == "")
            {
                MessageBox.Show("No hay ningún mercado seleccionado", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Mercado m = MercadoDAO.GetMercadoById(id_mercado);
                //MessageBox.Show(m.ID.ToString());
                if (ApuestaDAO.GetByMercado(m.ID).Count != 0)
                {
                    MessageBox.Show("No puede eliminar un mercado que contenga apuestas", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el mercado seleccionado?", "Confirmación borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        MercadoDAO.Delete(m);
                        FillDataMercados();
                    }
                }
            }
        }

        /// <summary>
        /// Abre el formulario del gestor de Usuarios y Apuestas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsuariosApuestas_Click(object sender, EventArgs e)
        {
            UsuariosApuestasViewer newForm = new UsuariosApuestasViewer(userlogged);
            newForm.ShowDialog(this);
        }

        /// <summary>
        /// Nos desloguea de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestordeInformes_Click(object sender, EventArgs e)
        {
            GestorInformes newForm = new GestorInformes();
            newForm.ShowDialog(this);
        }

        private void btnEditarMercado_Click(object sender, EventArgs e)
        {
            bool edita = true;
            AddMercado newForm = new AddMercado(id_mercado, edita);
            newForm.ShowDialog(this);
            FillDataMercados();
        }

        
    }
}
