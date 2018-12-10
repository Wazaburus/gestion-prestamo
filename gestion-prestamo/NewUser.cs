using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_prestamo
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUserAdd_Click_1(object sender, EventArgs e)
        {
            var db = new db.loans_dbEntities();
            var username = textBoxUserName.Text;
            var loginText = textBoxLogin.Text;
            var password = textBoxPassword.Text;



            #region validations
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("El nombre del usuario es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(loginText))
            {
                MessageBox.Show("El usuario es obligatorio!");
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("La contraseña es obligatoria!");
                return;
            }
            #endregion

            #region db
            var login = new db.login();
            login.username = loginText;
            login.password = password;
            login.name = username;
            login.disable = false;
            db.logins.Add(login);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Usuario registrado.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar en la DB");
                MessageBox.Show(ex.Message);
            }
            #endregion
            
        }
    }
}
