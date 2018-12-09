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
            this.headerText = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabLoans.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLoans
            // 
            this.tabLoans.Controls.Add(this.button1);
            this.tabLoans.Controls.Add(this.headerText);
            this.tabLoans.Location = new System.Drawing.Point(4, 25);
            this.tabLoans.Name = "tabLoans";
            this.tabLoans.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoans.Size = new System.Drawing.Size(1248, 519);
            this.tabLoans.TabIndex = 0;
            this.tabLoans.Text = "Préstamos";
            this.tabLoans.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1242, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar Nuevo Préstamo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // headerText
            // 
            this.headerText.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerText.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(3, 3);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(1242, 48);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Préstamos";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(1248, 519);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reportes";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Location = new System.Drawing.Point(4, 25);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new System.Drawing.Size(1248, 519);
            this.tabSecurity.TabIndex = 0;
            this.tabSecurity.Text = "Seguridad";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.tabLoans.ResumeLayout(false);
            this.tabLoans.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLoans;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label headerText;
    }
}

