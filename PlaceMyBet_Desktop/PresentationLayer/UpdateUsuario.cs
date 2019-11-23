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
    public partial class UpdateUsuario : Form
    {
        public List<string> emails;
        public UpdateUsuario(Usuario u)
        {

            InitializeComponent();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioDAO.GetAll();
            emails = new List<string>();
            foreach (Usuario uu in usuarios)
            {
                emails.Add(uu.Email);
            }
            emails.Remove(u.Email);
            tbEmail.Text = u.Email;
            tbEmail.Enabled = false;
            tbNombre.Text = u.Nombre;
            tbApellidos.Text = u.Apellidos;
            tbEdad.Text = u.Edad.ToString();
            tbFondos.Text = u.Fondos.ToString();
            if (u.Administrador)
            {
                checkboxAdmin.Checked = true;
            }
            else
            {
                checkboxAdmin.Checked = false;
            }
            tbPassword.Text = u.Password;
        }

        private void btnGuardarMercado_Click(object sender, EventArgs e)
        {
            if (emails.Contains(tbEmail.Text) || tbEmail.Text == "")
            {
                valEmail.Visible = true;
            }
            else if (tbPassword.Text.Length < 6 || tbPassword.Text == "")
            {
                valPassword.Visible = true;
            }
            else
            {
                valPassword.Visible = false;
                valEmail.Visible = false;
                Usuario user = null;
                DialogResult res = MessageBox.Show("¿Estás seguro que quieres realizar los cambios en el usuario?", "Confirmación nuevo usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    
                    bool admin = false;
                    if (checkboxAdmin.Checked)
                    {
                        admin = true;
                    }
                    user = new Usuario(tbEmail.Text, tbNombre.Text, tbApellidos.Text, Int32.Parse(tbEdad.Text), Int32.Parse(tbFondos.Text), admin, tbPassword.Text);

                    UsuarioDAO.Update(user);
                    this.Close();
                }
            }
        }
    }
}
