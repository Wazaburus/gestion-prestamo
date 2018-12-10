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
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debbtornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtordocumentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtortelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loans_dbDataSet = new gestion_prestamo.loans_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.headerPrestamos = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.headerSeguridad = new System.Windows.Forms.Label();
            this.loanTableAdapter = new gestion_prestamo.loans_dbDataSetTableAdapters.loanTableAdapter();
            this.dataGridViewSeguridad = new System.Windows.Forms.DataGridView();
            this.loansdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loans_dbDataSet1 = new gestion_prestamo.loans_dbDataSet1();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new gestion_prestamo.loans_dbDataSet1TableAdapters.loginTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loans_dbDataSet)).BeginInit();
            this.tabSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeguridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loans_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
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
            this.tabLoans.Controls.Add(this.dataGridViewPrestamos);
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
            // dataGridViewPrestamos
            // 
            this.dataGridViewPrestamos.AllowUserToAddRows = false;
            this.dataGridViewPrestamos.AllowUserToDeleteRows = false;
            this.dataGridViewPrestamos.AllowUserToResizeColumns = false;
            this.dataGridViewPrestamos.AllowUserToResizeRows = false;
            this.dataGridViewPrestamos.AutoGenerateColumns = false;
            this.dataGridViewPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.debbtornameDataGridViewTextBoxColumn,
            this.debtordocumentidDataGridViewTextBoxColumn,
            this.debtortelephoneDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn});
            this.dataGridViewPrestamos.DataSource = this.loanBindingSource;
            this.dataGridViewPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(2, 64);
            this.dataGridViewPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.ReadOnly = true;
            this.dataGridViewPrestamos.RowTemplate.Height = 24;
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(930, 353);
            this.dataGridViewPrestamos.TabIndex = 2;
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
            this.tabSecurity.Controls.Add(this.dataGridViewSeguridad);
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
            this.button2.Size = new System.Drawing.Size(934, 27);
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
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSeguridad
            // 
            this.dataGridViewSeguridad.AllowUserToAddRows = false;
            this.dataGridViewSeguridad.AllowUserToDeleteRows = false;
            this.dataGridViewSeguridad.AllowUserToResizeColumns = false;
            this.dataGridViewSeguridad.AllowUserToResizeRows = false;
            this.dataGridViewSeguridad.AutoGenerateColumns = false;
            this.dataGridViewSeguridad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSeguridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeguridad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.name,
            this.username,
            this.password,
            this.disable});
            this.dataGridViewSeguridad.DataSource = this.loginBindingSource;
            this.dataGridViewSeguridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeguridad.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewSeguridad.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSeguridad.Name = "dataGridViewSeguridad";
            this.dataGridViewSeguridad.ReadOnly = true;
            this.dataGridViewSeguridad.RowTemplate.Height = 24;
            this.dataGridViewSeguridad.Size = new System.Drawing.Size(934, 353);
            this.dataGridViewSeguridad.TabIndex = 3;
            // 
            // loansdbDataSetBindingSource
            // 
            this.loansdbDataSetBindingSource.DataSource = this.loans_dbDataSet;
            this.loansdbDataSetBindingSource.Position = 0;
            // 
            // loans_dbDataSet1
            // 
            this.loans_dbDataSet1.DataSetName = "loans_dbDataSet1";
            this.loans_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.loans_dbDataSet1;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Usuario";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Contraseña";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // disable
            // 
            this.disable.DataPropertyName = "disable";
            this.disable.HeaderText = "Deshabilitado";
            this.disable.Name = "disable";
            this.disable.ReadOnly = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 465);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLoans.ResumeLayout(false);
            this.tabLoans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loans_dbDataSet)).EndInit();
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeguridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loans_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private loans_dbDataSet loans_dbDataSet;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private loans_dbDataSetTableAdapters.loanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debbtornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtordocumentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtortelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewSeguridad;
        private System.Windows.Forms.BindingSource loansdbDataSetBindingSource;
        private loans_dbDataSet1 loans_dbDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private loans_dbDataSet1TableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disable;
    }
}

