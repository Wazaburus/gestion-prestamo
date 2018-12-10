namespace gestion_prestamo
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLoans = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.headerPrestamos = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.headerSeguridad = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLoans.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLoans);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Controls.Add(this.tabSecurity);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLoans
            // 
            this.tabLoans.Controls.Add(this.button1);
            this.tabLoans.Controls.Add(this.headerPrestamos);
            this.tabLoans.Location = new System.Drawing.Point(4, 22);
            this.tabLoans.Margin = new System.Windows.Forms.Padding(2);
            this.tabLoans.Name = "tabLoans";
            this.tabLoans.Padding = new System.Windows.Forms.Padding(2);
            this.tabLoans.Size = new System.Drawing.Size(934, 419);
            this.tabLoans.TabIndex = 0;
            this.tabLoans.Text = "Préstamos";
            this.tabLoans.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(2, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(930, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar Nuevo Préstamo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // headerPrestamos
            // 
            this.headerPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPrestamos.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerPrestamos.Location = new System.Drawing.Point(2, 2);
            this.headerPrestamos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerPrestamos.Name = "headerPrestamos";
            this.headerPrestamos.Size = new System.Drawing.Size(930, 39);
            this.headerPrestamos.TabIndex = 0;
            this.headerPrestamos.Text = "Préstamos";
            this.headerPrestamos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Margin = new System.Windows.Forms.Padding(2);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(2);
            this.tabReports.Size = new System.Drawing.Size(934, 419);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reportes";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.button2);
            this.tabSecurity.Controls.Add(this.headerSeguridad);
            this.tabSecurity.Location = new System.Drawing.Point(4, 22);
            this.tabSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new System.Drawing.Size(934, 419);
            this.tabSecurity.TabIndex = 0;
            this.tabSecurity.Text = "Seguridad";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(934, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar Registro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // headerSeguridad
            // 
            this.headerSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerSeguridad.Font = new System.Drawing.Font("Tahoma", 24F);
            this.headerSeguridad.Location = new System.Drawing.Point(0, 0);
            this.headerSeguridad.Name = "headerSeguridad";
            this.headerSeguridad.Size = new System.Drawing.Size(934, 39);
            this.headerSeguridad.TabIndex = 0;
            this.headerSeguridad.Text = "Seguridad";
            this.headerSeguridad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 465);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.tabLoans.ResumeLayout(false);
            this.tabLoans.PerformLayout();
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLoans;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label headerPrestamos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label headerSeguridad;
    }
}

