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
    public partial class AddUsuario : Form
    {
        public List<string> emails;
        public AddUsuario()
        {
            InitializeComponent();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioDAO.GetAll();
            emails = new List<string>();
            foreach (Usuario u in usuarios)
            {
                emails.Add(u.Email);
            }
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
                DialogResult res = MessageBox.Show("¿Estás seguro que quieres añadir el usuario?", "Confirmación nuevo usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    bool admin = false;
                    if (checkboxAdmin.Checked)
                    {
                        admin = true;
                    }
                    user = new Usuario(tbEmail.Text, tbNombre.Text, tbApellidos.Text, Int32.Parse(tbEdad.Text), Int32.Parse(tbFondos.Text), admin, tbPassword.Text);

                    UsuarioDAO.Insert(user);
                    this.Close();
                }
            }
        }
    }
}
