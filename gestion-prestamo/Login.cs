using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace gestion_prestamo
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread t = new Thread(new ThreadStart(startSplash));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void startSplash()
        {
            Application.Run(new Splash());
        }

        private void buttonLoginExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLoginEnter_Click(object sender, EventArgs e)
        {
            var db = new db.loans_dbEntities();
            string query = (from login in db.logins where login.username == textBoxLoginUser.Text && login.password == textBoxLoginPassword.Text select login.name).FirstOrDefault();
            if (query != null)
            {
                this.Hide();
                MessageBox.Show("Bienvenido");
                var home = new Home();
                home.Show();
            }
            else
                MessageBox.Show("Usuario Incorrecto");
            {
                return;
            }
        }
    }
}
