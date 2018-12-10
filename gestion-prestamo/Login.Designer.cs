namespace gestion_prestamo
{
    partial class Login
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginUser = new System.Windows.Forms.TextBox();
            this.buttonLoginExit = new System.Windows.Forms.Button();
            this.buttonLoginEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Lime;
            this.labelLogin.Location = new System.Drawing.Point(288, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(82, 25);
            this.labelLogin.TabIndex = 20;
            this.labelLogin.Text = "LOGIN";
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginUser.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUser.ForeColor = System.Drawing.Color.Lime;
            this.labelLoginUser.Location = new System.Drawing.Point(50, 70);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(112, 25);
            this.labelLoginUser.TabIndex = 19;
            this.labelLoginUser.Text = "USUARIO";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.ForeColor = System.Drawing.Color.Lime;
            this.labelLoginPassword.Location = new System.Drawing.Point(6, 165);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(156, 25);
            this.labelLoginPassword.TabIndex = 18;
            this.labelLoginPassword.Text = "CONTRASEÑA";
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(211, 170);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(245, 20);
            this.textBoxLoginPassword.TabIndex = 17;
            this.textBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.Location = new System.Drawing.Point(211, 75);
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.Size = new System.Drawing.Size(245, 20);
            this.textBoxLoginUser.TabIndex = 16;
            // 
            // buttonLoginExit
            // 
            this.buttonLoginExit.Location = new System.Drawing.Point(365, 221);
            this.buttonLoginExit.Name = "buttonLoginExit";
            this.buttonLoginExit.Size = new System.Drawing.Size(91, 41);
            this.buttonLoginExit.TabIndex = 15;
            this.buttonLoginExit.Text = "SALIR";
            this.buttonLoginExit.UseVisualStyleBackColor = true;
            this.buttonLoginExit.Click += new System.EventHandler(this.buttonLoginExit_Click);
            // 
            // buttonLoginEnter
            // 
            this.buttonLoginEnter.Location = new System.Drawing.Point(211, 221);
            this.buttonLoginEnter.Name = "buttonLoginEnter";
            this.buttonLoginEnter.Size = new System.Drawing.Size(91, 41);
            this.buttonLoginEnter.TabIndex = 14;
            this.buttonLoginEnter.Text = "ENTRAR";
            this.buttonLoginEnter.UseVisualStyleBackColor = true;
            this.buttonLoginEnter.Click += new System.EventHandler(this.buttonLoginEnter_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestion_prestamo.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 273);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelLoginUser);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.textBoxLoginUser);
            this.Controls.Add(this.buttonLoginExit);
            this.Controls.Add(this.buttonLoginEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginUser;
        private System.Windows.Forms.Button buttonLoginExit;
        private System.Windows.Forms.Button buttonLoginEnter;
    }
}