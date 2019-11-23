using PlaceMyBet_Desktop.BusinessLayer;
using PlaceMyBet_Desktop.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceMyBet_Desktop.PresentationLayer
{
    /// <summary>
    /// Clase del formulario AÑADIR MERCADO
    /// </summary>
    public partial class AddMercado : Form
    {
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        /// <param name="id">Identificador del evento al que vamos a añadir el mercado</param>
        /// 
        public bool Edita { get; set; }
        public int IdMercado { get; set; }
        public AddMercado(int id, bool edita)

        {
            InitializeComponent();
            Edita = edita;
            

            if (!edita)
            {
                tbId.Text = (MercadoDAO.SelectMaxId() + 1).ToString();
                tbId.Enabled = false;
                //tbCuotaOver.Enabled = false;
                //tbCuotaUnder.Enabled = false;
                //tbDineroOver.Enabled = false;
                //tbDineroUnder.Enabled = false;
                tbIdEvento.Text = id.ToString();
                tbIdEvento.Enabled = false;

                List<Mercado> mercados = MercadoDAO.GetMercadosByEventoId(id);

                foreach (Mercado m in mercados)
                {
                    if (m.Tipo == 1.5)
                    {
                        rb15.Enabled = false;
                    }
                    else if (m.Tipo == 2.5)
                    {
                        rb25.Enabled = false;
                    }
                    else if (m.Tipo == 3.5)
                    {
                        rb35.Enabled = false;
                    }
                }
            } else
            {
                IdMercado = id;
                Mercado m = MercadoDAO.GetMercadoById(id);
                tbCuotaOver.Text = m.CuotaOver.ToString();
                tbCuotaUnder.Text = m.CuotaUnder.ToString();
                tbDineroOver.Text = m.DineroOver.ToString();
                tbDineroUnder.Text = m.DineroUnder.ToString();
                //tbCuotaOver.Enabled = true;
                //tbCuotaUnder.Enabled = true;
                //tbDineroOver.Enabled = true;
                //tbDineroUnder.Enabled = true;
                tbId.Text = m.ID.ToString();
                tbId.Enabled = false;
                tbIdEvento.Text = m.ID_Evento.ToString();
                tbIdEvento.Enabled = false;

                


                rb15.Enabled = false;
                rb25.Enabled = false;
                rb35.Enabled = false;
                if (m.Tipo == 1.5)
                {
                    rb15.Checked = true;  
                }
                else if (m.Tipo == 2.5)
                {
                    rb25.Checked = true;
                }
                else if (m.Tipo == 3.5)
                {
                    rb35.Checked = true;
                }
            }
        }

        /// <summary>
        /// Impide teclear caracteres que no sean numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Guarda un nuevo mercado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarMercado_Click(object sender, EventArgs e)
        {
            if (tbCuotaOver.Text.Contains('.'))
            {
                string conComa = tbCuotaOver.Text.Replace('.', ',');
                tbCuotaOver.Text = conComa;
            }
            if (tbCuotaUnder.Text.Contains('.'))
            {
                string conComa = tbCuotaUnder.Text.Replace('.', ',');
                tbCuotaUnder.Text = conComa;
            }
            if (tbDineroOver.Text.Contains('.'))
            {
                string conComa = tbDineroOver.Text.Replace('.', ',');
                tbDineroOver.Text = conComa;
            }
            if (tbDineroUnder.Text.Contains('.'))
            {
                string conComa = tbDineroUnder.Text.Replace('.', ',');
                tbDineroUnder.Text = conComa;
            }
            if (!Edita)
            {
                if (rb15.Checked == false && rb25.Checked == false && rb35.Checked == false)
                {
                    MessageBox.Show("Campo 'Tipo Mercado' obligatorio", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(tbCuotaOver.Text == "" || tbCuotaUnder.Text == "" || tbDineroOver.Text == "" || tbDineroUnder.Text == "")
                {
                    MessageBox.Show("Los campos de 'Cuotas' y 'Dineros' tienes que estar rellenos", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else
                {
                    DialogResult res = MessageBox.Show("¿Estás seguro que quieres añadir el mercado?", "Confirmación nuevo evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        double tipoMercado = 0;
                        if (rb15.Checked == true)
                        {
                            tipoMercado = 1.5;
                        }
                        else if (rb25.Checked == true)
                        {
                            tipoMercado = 2.5;
                        }
                        else if (rb35.Checked == true)
                        {
                            tipoMercado = 3.5;
                        }
                        float a = (float)tipoMercado;
                        Mercado m = new Mercado(Int32.Parse(tbId.Text), a, 1.9F, 1.9F, 100, 100, Int32.Parse(tbIdEvento.Text));
                        MercadoDAO.InsertMercado(m);
                        this.Close();
                    }
                }
            }
            else
            {
                Mercado m = MercadoDAO.GetMercadoById(IdMercado);
                if(m.CuotaOver.ToString() == tbCuotaOver.Text && m.CuotaUnder.ToString() == tbCuotaUnder.Text && m.DineroOver.ToString() == tbDineroOver.Text && m.DineroUnder.ToString() == tbDineroUnder.Text)
                {
                    MessageBox.Show("No se han producido cambios", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (tbCuotaOver.Text == "" || tbCuotaUnder.Text == "" || tbDineroOver.Text == "" || tbDineroUnder.Text == "")
                {
                    MessageBox.Show("Los campos de 'Cuotas' y 'Dineros' tienes que estar rellenos", "Place My Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    DialogResult res = MessageBox.Show("¿Quieres guardar los cambios realizados?", "Confirmación edición evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {

                       
                        m.Tipo = m.Tipo;
                        m.CuotaOver = float.Parse(tbCuotaOver.Text);
                        m.CuotaUnder = float.Parse(tbCuotaUnder.Text);
                        m.DineroOver = Int32.Parse(tbDineroOver.Text);
                        m.DineroUnder = Int32.Parse(tbDineroUnder.Text);
                        m.ID_Evento = m.ID_Evento;
                        MercadoDAO.Update(m);
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Limpia el text box del identificador de mercado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiarMercado_Click(object sender, EventArgs e)
        {
            tbCuotaOver.Clear();
            tbCuotaUnder.Clear();
            tbDineroOver.Clear();
            tbDineroUnder.Clear();
        }

        /// <summary>
        /// Sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCuotaOver_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = true;
            }   
        }

        private void tbCuotaUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void tbDineroOver_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void tbDineroUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = true;
            }
        }
    }
}
