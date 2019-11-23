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
    /// Clase del formulario LOGIN
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public LoginForm()
        {
            Database.Connect();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        /// <summary>
        /// Evalúa que el usuario sea administrador y que el password sea el suyo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (LoginDAO.GetAdmin(tbUSUARIO.Text))
            {
                if (LoginDAO.GetPassword(tbUSUARIO.Text, tbPASSWORD.Text) == tbPASSWORD.Text)
                {
                    MainForm newForm = new MainForm(tbUSUARIO.Text);
                    newForm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No tiene permisos de Administrador", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Limpia los campos de Usuario y Password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            tbUSUARIO.Clear();
            tbPASSWORD.Clear();
        }

        /// <summary>
        /// Sale de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hasta luego!");
            this.Close();
        }
    }
}
