namespace gestion_prestamo
{
    partial class Usuario
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
            this.headerAgregarUsuario = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonUserCancel = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerAgregarUsuario
            // 
            this.headerAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerAgregarUsuario.Font = new System.Drawing.Font("Tahoma", 24F);
            this.headerAgregarUsuario.Location = new System.Drawing.Point(0, 0);
            this.headerAgregarUsuario.Name = "headerAgregarUsuario";
            this.headerAgregarUsuario.Size = new System.Drawing.Size(369, 39);
            this.headerAgregarUsuario.TabIndex = 0;
            this.headerAgregarUsuario.Text = "Agregar Usuario";
            this.headerAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelUserName.Location = new System.Drawing.Point(47, 66);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(72, 19);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Nombre:";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelUserLogin.Location = new System.Drawing.Point(50, 121);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(69, 19);
            this.labelUserLogin.TabIndex = 2;
            this.labelUserLogin.Text = "Usuario:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelUserPassword.Location = new System.Drawing.Point(28, 176);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(94, 19);
            this.labelUserPassword.TabIndex = 3;
            this.labelUserPassword.Text = "Contraseña:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(148, 65);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(175, 20);
            this.textBoxUserName.TabIndex = 4;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(148, 120);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(175, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(148, 175);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(175, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // buttonUserCancel
            // 
            this.buttonUserCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUserCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUserCancel.Location = new System.Drawing.Point(0, 259);
            this.buttonUserCancel.Name = "buttonUserCancel";
            this.buttonUserCancel.Size = new System.Drawing.Size(369, 30);
            this.buttonUserCancel.TabIndex = 8;
            this.buttonUserCancel.Text = "Cancelar";
            this.buttonUserCancel.UseVisualStyleBackColor = true;
            this.buttonUserCancel.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUserAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUserAdd.Location = new System.Drawing.Point(0, 229);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(369, 30);
            this.buttonUserAdd.TabIndex = 7;
            this.buttonUserAdd.Text = "Agregar";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click_1);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 289);
            this.Controls.Add(this.buttonUserAdd);
            this.Controls.Add(this.buttonUserCancel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.headerAgregarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerAgregarUsuario;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonUserCancel;
        private System.Windows.Forms.Button buttonUserAdd;
    }
}