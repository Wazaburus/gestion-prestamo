﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Prestamos = new Prestamos();
            Prestamos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var NewUser = new Usuario();
            NewUser.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loans_dbDataSet.loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter.Fill(this.loans_dbDataSet.loan);
        }
    }
}
