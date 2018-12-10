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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLoans = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loans_dbDataSet = new gestion_prestamo.loans_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.headerPrestamos = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.headerSeguridad = new System.Windows.Forms.Label();
            this.loanTableAdapter = new gestion_prestamo.loans_dbDataSetTableAdapters.loanTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debbtornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtordocumentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtortelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loans_dbDataSet)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLoans
            // 
            this.tabLoans.Controls.Add(this.dataGridView1);
            this.tabLoans.Controls.Add(this.button1);
            this.tabLoans.Controls.Add(this.headerPrestamos);
            this.tabLoans.Location = new System.Drawing.Point(4, 25);
            this.tabLoans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLoans.Name = "tabLoans";
            this.tabLoans.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLoans.Size = new System.Drawing.Size(1248, 519);
            this.tabLoans.TabIndex = 0;
            this.tabLoans.Text = "Préstamos";
            this.tabLoans.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.debbtornameDataGridViewTextBoxColumn,
            this.debtordocumentidDataGridViewTextBoxColumn,
            this.debtortelephoneDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loanBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 440);
            this.dataGridView1.TabIndex = 2;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "loan";
            this.loanBindingSource.DataSource = this.loans_dbDataSet;
            // 
            // loans_dbDataSet
            // 
            this.loans_dbDataSet.DataSetName = "loans_dbDataSet";
            this.loans_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1242, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar Nuevo Préstamo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // headerPrestamos
            // 
            this.headerPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPrestamos.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerPrestamos.Location = new System.Drawing.Point(3, 2);
            this.headerPrestamos.Name = "headerPrestamos";
            this.headerPrestamos.Size = new System.Drawing.Size(1242, 48);
            this.headerPrestamos.TabIndex = 0;
            this.headerPrestamos.Text = "Préstamos";
            this.headerPrestamos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReports.Size = new System.Drawing.Size(1248, 519);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reportes";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.button2);
            this.tabSecurity.Controls.Add(this.headerSeguridad);
            this.tabSecurity.Location = new System.Drawing.Point(4, 25);
            this.tabSecurity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new System.Drawing.Size(1248, 519);
            this.tabSecurity.TabIndex = 0;
            this.tabSecurity.Text = "Seguridad";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1248, 33);
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
            this.headerSeguridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerSeguridad.Name = "headerSeguridad";
            this.headerSeguridad.Size = new System.Drawing.Size(1248, 48);
            this.headerSeguridad.TabIndex = 0;
            this.headerSeguridad.Text = "Seguridad";
            this.headerSeguridad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Número";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debbtornameDataGridViewTextBoxColumn
            // 
            this.debbtornameDataGridViewTextBoxColumn.DataPropertyName = "debbtor_name";
            this.debbtornameDataGridViewTextBoxColumn.HeaderText = "Deudor";
            this.debbtornameDataGridViewTextBoxColumn.Name = "debbtornameDataGridViewTextBoxColumn";
            this.debbtornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtordocumentidDataGridViewTextBoxColumn
            // 
            this.debtordocumentidDataGridViewTextBoxColumn.DataPropertyName = "debtor_document_id";
            this.debtordocumentidDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.debtordocumentidDataGridViewTextBoxColumn.Name = "debtordocumentidDataGridViewTextBoxColumn";
            this.debtordocumentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtortelephoneDataGridViewTextBoxColumn
            // 
            this.debtortelephoneDataGridViewTextBoxColumn.DataPropertyName = "debtor_telephone";
            this.debtortelephoneDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.debtortelephoneDataGridViewTextBoxColumn.Name = "debtortelephoneDataGridViewTextBoxColumn";
            this.debtortelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "debt";
            this.debtDataGridViewTextBoxColumn.HeaderText = "Pendiente";
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 572);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLoans.ResumeLayout(false);
            this.tabLoans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loans_dbDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private loans_dbDataSet loans_dbDataSet;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private loans_dbDataSetTableAdapters.loanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debbtornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtordocumentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtortelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
    }
}

