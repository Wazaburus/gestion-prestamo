using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            var home = new Home();
            home.Show();
        }
    }
}
