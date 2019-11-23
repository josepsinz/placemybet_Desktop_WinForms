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
    /// Clase del formulario GESTOR DE USUARIOS Y APUESTAS
    /// </summary>
    public partial class UsuariosApuestasViewer : Form
    {
        private string usuario;

        private string userlogged;
        //private bool edita;
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public UsuariosApuestasViewer(string usuariologeado)
        {
            InitializeComponent();
            userlogged = usuariologeado;
            checkBoxAdmin.Checked = false;
            List<Usuario> usuarios = UsuarioDAO.GetAllUsers();

            foreach (Usuario u in usuarios)
            {
                if (!checkBoxAdmin.Checked)
                {
                    dgvUsuarios.Rows.Add(u.Email, u.Nombre, u.Apellidos, u.Edad, u.Administrador);
                }
                
            }
        }

        /// <summary>
        /// Evalúa una nueva selección en el grid de Usaurios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            usuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            tbSeleccionado.Text = usuario;
        }

        /// <summary>
        /// Permite ver las apuestas de un usuario en concreto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerApuestas_Click(object sender, EventArgs e)
        {
            dgvApuestas.Rows.Clear();
            List<Apuesta> apuestasUsuario = ApuestaDAO.GetByUser(usuario);

            foreach (Apuesta a in apuestasUsuario)
            {
                dgvApuestas.Rows.Add(a.ID, a.TipoMercado, a.Tipo, a.Cuota, a.Apostado, a.ID_Mercado, a.Email);
            }
        }

        /// <summary>
        /// Permite ver todas las apuestas realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTodasApuestas_Click(object sender, EventArgs e)
        {
            dgvApuestas.Rows.Clear();
            List<Apuesta> apuestas = ApuestaDAO.GetAll();

            foreach (Apuesta a in apuestas)
            {
                dgvApuestas.Rows.Add(a.ID, a.TipoMercado, a.Tipo, a.Cuota, a.Apostado, a.ID_Mercado, a.Email);
            }
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

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioDAO.GetAllAdmin();
            List<Usuario> usuarios2 = UsuarioDAO.GetAllUsers();

            if (checkBoxAdmin.Checked)
            {
                dgvUsuarios.Rows.Clear();
                foreach (Usuario u in usuarios)
                {
                    
                    dgvUsuarios.Rows.Add(u.Email, u.Nombre, u.Apellidos, u.Edad, u.Administrador);

                }
            }
            else
            {
                dgvUsuarios.Rows.Clear();
                foreach (Usuario u in usuarios2)
                {

                    dgvUsuarios.Rows.Add(u.Email, u.Nombre, u.Apellidos, u.Edad, u.Administrador);

                }
            }
            
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            AddUsuario newForm = new AddUsuario();
            newForm.ShowDialog(this);
        }

        private void btnEditarEvento_Click(object sender, EventArgs e)
        {
            string usuarioseleccionado = tbSeleccionado.Text;
            Usuario u = UsuarioDAO.GetByEmail(usuarioseleccionado);
            UpdateUsuario newForm = new UpdateUsuario(u);
            newForm.ShowDialog(this);
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            Usuario u = UsuarioDAO.GetByEmail(tbSeleccionado.Text);
            if(userlogged == u.Email)
            {
                valDelete.Visible = true;
            }
            else
            {
                valDelete.Visible = false;
                DialogResult res = MessageBox.Show("¿Está seguro que quiere eliminar el usuario seleccionado?", "Confirmación borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    UsuarioDAO.Delete(u);
                    //FillData();
                }
            }
            
        }
    }
}
