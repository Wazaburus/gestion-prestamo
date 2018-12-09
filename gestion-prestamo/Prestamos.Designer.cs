namespace gestion_prestamo
{
    partial class Prestamos
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
            this.buttonPrestamosCancelar = new System.Windows.Forms.Button();
            this.buttonPrestamosGuardar = new System.Windows.Forms.Button();
            this.headerPrestamo = new System.Windows.Forms.Label();
            this.labelDeudor = new System.Windows.Forms.Label();
            this.labelGarante = new System.Windows.Forms.Label();
            this.labelDeudorNombre = new System.Windows.Forms.Label();
            this.labelDeudorCedula = new System.Windows.Forms.Label();
            this.labelDeudorTelefono = new System.Windows.Forms.Label();
            this.textBoxDeudorNombre = new System.Windows.Forms.TextBox();
            this.textBoxDeudorCedula = new System.Windows.Forms.TextBox();
            this.textBoxDeudorTelefono = new System.Windows.Forms.TextBox();
            this.labelGaranteNombre = new System.Windows.Forms.Label();
            this.labelGaranteTelefono = new System.Windows.Forms.Label();
            this.labelGaranteCedula = new System.Windows.Forms.Label();
            this.textBoxGaranteTelefono = new System.Windows.Forms.TextBox();
            this.textBoxGaranteCedula = new System.Windows.Forms.TextBox();
            this.textBoxGaranteNombre = new System.Windows.Forms.TextBox();
            this.labelDatosDelPrestamo = new System.Windows.Forms.Label();
            this.textBoxDatosGastos = new System.Windows.Forms.TextBox();
            this.textBoxDatosTiempo = new System.Windows.Forms.TextBox();
            this.textBoxDatosMonto = new System.Windows.Forms.TextBox();
            this.labelDatosTiempo = new System.Windows.Forms.Label();
            this.labelDatosGasto = new System.Windows.Forms.Label();
            this.labelDatosMonto = new System.Windows.Forms.Label();
            this.labelDatosTasa = new System.Windows.Forms.Label();
            this.textBoxDatosTasa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPrestamosCancelar
            // 
            this.buttonPrestamosCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPrestamosCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPrestamosCancelar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonPrestamosCancelar.Location = new System.Drawing.Point(0, 506);
            this.buttonPrestamosCancelar.Name = "buttonPrestamosCancelar";
            this.buttonPrestamosCancelar.Size = new System.Drawing.Size(464, 39);
            this.buttonPrestamosCancelar.TabIndex = 0;
            this.buttonPrestamosCancelar.Text = "Cancelar";
            this.buttonPrestamosCancelar.UseVisualStyleBackColor = true;
            this.buttonPrestamosCancelar.Click += new System.EventHandler(this.buttonPrestamosCancelar_Click);
            // 
            // buttonPrestamosGuardar
            // 
            this.buttonPrestamosGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPrestamosGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPrestamosGuardar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonPrestamosGuardar.Location = new System.Drawing.Point(0, 467);
            this.buttonPrestamosGuardar.Name = "buttonPrestamosGuardar";
            this.buttonPrestamosGuardar.Size = new System.Drawing.Size(464, 39);
            this.buttonPrestamosGuardar.TabIndex = 1;
            this.buttonPrestamosGuardar.Text = "Guardar";
            this.buttonPrestamosGuardar.UseVisualStyleBackColor = true;
            // 
            // headerPrestamo
            // 
            this.headerPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerPrestamo.AutoSize = true;
            this.headerPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.headerPrestamo.Font = new System.Drawing.Font("Tahoma", 24F);
            this.headerPrestamo.Location = new System.Drawing.Point(111, 9);
            this.headerPrestamo.Name = "headerPrestamo";
            this.headerPrestamo.Size = new System.Drawing.Size(249, 39);
            this.headerPrestamo.TabIndex = 2;
            this.headerPrestamo.Text = "Nuevo Prestamo";
            // 
            // labelDeudor
            // 
            this.labelDeudor.AutoSize = true;
            this.labelDeudor.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelDeudor.Location = new System.Drawing.Point(251, 78);
            this.labelDeudor.Name = "labelDeudor";
            this.labelDeudor.Size = new System.Drawing.Size(72, 23);
            this.labelDeudor.TabIndex = 3;
            this.labelDeudor.Text = "Deudor";
            // 
            // labelGarante
            // 
            this.labelGarante.AutoSize = true;
            this.labelGarante.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelGarante.Location = new System.Drawing.Point(249, 209);
            this.labelGarante.Name = "labelGarante";
            this.labelGarante.Size = new System.Drawing.Size(77, 23);
            this.labelGarante.TabIndex = 4;
            this.labelGarante.Text = "Garante";
            // 
            // labelDeudorNombre
            // 
            this.labelDeudorNombre.AutoSize = true;
            this.labelDeudorNombre.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelDeudorNombre.Location = new System.Drawing.Point(58, 116);
            this.labelDeudorNombre.Name = "labelDeudorNombre";
            this.labelDeudorNombre.Size = new System.Drawing.Size(62, 17);
            this.labelDeudorNombre.TabIndex = 5;
            this.labelDeudorNombre.Text = "Nombre:";
            // 
            // labelDeudorCedula
            // 
            this.labelDeudorCedula.AutoSize = true;
            this.labelDeudorCedula.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelDeudorCedula.Location = new System.Drawing.Point(66, 142);
            this.labelDeudorCedula.Name = "labelDeudorCedula";
            this.labelDeudorCedula.Size = new System.Drawing.Size(54, 17);
            this.labelDeudorCedula.TabIndex = 6;
            this.labelDeudorCedula.Text = "Cedula:";
            // 
            // labelDeudorTelefono
            // 
            this.labelDeudorTelefono.AutoSize = true;
            this.labelDeudorTelefono.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelDeudorTelefono.Location = new System.Drawing.Point(55, 168);
            this.labelDeudorTelefono.Name = "labelDeudorTelefono";
            this.labelDeudorTelefono.Size = new System.Drawing.Size(65, 17);
            this.labelDeudorTelefono.TabIndex = 7;
            this.labelDeudorTelefono.Text = "Telefono:";
            // 
            // textBoxDeudorNombre
            // 
            this.textBoxDeudorNombre.Location = new System.Drawing.Point(126, 113);
            this.textBoxDeudorNombre.Name = "textBoxDeudorNombre";
            this.textBoxDeudorNombre.Size = new System.Drawing.Size(322, 20);
            this.textBoxDeudorNombre.TabIndex = 8;
            // 
            // textBoxDeudorCedula
            // 
            this.textBoxDeudorCedula.Location = new System.Drawing.Point(126, 139);
            this.textBoxDeudorCedula.Name = "textBoxDeudorCedula";
            this.textBoxDeudorCedula.Size = new System.Drawing.Size(322, 20);
            this.textBoxDeudorCedula.TabIndex = 9;
            // 
            // textBoxDeudorTelefono
            // 
            this.textBoxDeudorTelefono.Location = new System.Drawing.Point(126, 165);
            this.textBoxDeudorTelefono.Name = "textBoxDeudorTelefono";
            this.textBoxDeudorTelefono.Size = new System.Drawing.Size(322, 20);
            this.textBoxDeudorTelefono.TabIndex = 10;
            // 
            // labelGaranteNombre
            // 
            this.labelGaranteNombre.AutoSize = true;
            this.labelGaranteNombre.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelGaranteNombre.Location = new System.Drawing.Point(65, 247);
            this.labelGaranteNombre.Name = "labelGaranteNombre";
            this.labelGaranteNombre.Size = new System.Drawing.Size(62, 17);
            this.labelGaranteNombre.TabIndex = 11;
            this.labelGaranteNombre.Text = "Nombre:";
            // 
            // labelGaranteTelefono
            // 
            this.labelGaranteTelefono.AutoSize = true;
            this.labelGaranteTelefono.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelGaranteTelefono.Location = new System.Drawing.Point(62, 299);
            this.labelGaranteTelefono.Name = "labelGaranteTelefono";
            this.labelGaranteTelefono.Size = new System.Drawing.Size(65, 17);
            this.labelGaranteTelefono.TabIndex = 13;
            this.labelGaranteTelefono.Text = "Telefono:";
            // 
            // labelGaranteCedula
            // 
            this.labelGaranteCedula.AutoSize = true;
            this.labelGaranteCedula.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelGaranteCedula.Location = new System.Drawing.Point(71, 273);
            this.labelGaranteCedula.Name = "labelGaranteCedula";
            this.labelGaranteCedula.Size = new System.Drawing.Size(54, 17);
            this.labelGaranteCedula.TabIndex = 12;
            this.labelGaranteCedula.Text = "Cedula:";
            // 
            // textBoxGaranteTelefono
            // 
            this.textBoxGaranteTelefono.Location = new System.Drawing.Point(126, 296);
            this.textBoxGaranteTelefono.Name = "textBoxGaranteTelefono";
            this.textBoxGaranteTelefono.Size = new System.Drawing.Size(322, 20);
            this.textBoxGaranteTelefono.TabIndex = 16;
            // 
            // textBoxGaranteCedula
            // 
            this.textBoxGaranteCedula.Location = new System.Drawing.Point(126, 270);
            this.textBoxGaranteCedula.Name = "textBoxGaranteCedula";
            this.textBoxGaranteCedula.Size = new System.Drawing.Size(322, 20);
            this.textBoxGaranteCedula.TabIndex = 15;
            // 
            // textBoxGaranteNombre
            // 
            this.textBoxGaranteNombre.Location = new System.Drawing.Point(126, 244);
            this.textBoxGaranteNombre.Name = "textBoxGaranteNombre";
            this.textBoxGaranteNombre.Size = new System.Drawing.Size(322, 20);
            this.textBoxGaranteNombre.TabIndex = 14;
            // 
            // labelDatosDelPrestamo
            // 
            this.labelDatosDelPrestamo.AutoSize = true;
            this.labelDatosDelPrestamo.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelDatosDelPrestamo.Location = new System.Drawing.Point(201, 337);
            this.labelDatosDelPrestamo.Name = "labelDatosDelPrestamo";
            this.labelDatosDelPrestamo.Size = new System.Drawing.Size(173, 23);
            this.labelDatosDelPrestamo.TabIndex = 17;
            this.labelDatosDelPrestamo.Text = "Datos Del Prestamo";
            // 
            // textBoxDatosGastos
            // 
            this.textBoxDatosGastos.Location = new System.Drawing.Point(126, 424);
            this.textBoxDatosGastos.Name = "textBoxDatosGastos";
            this.textBoxDatosGastos.Size = new System.Drawing.Size(129, 20);
            this.textBoxDatosGastos.TabIndex = 23;
            // 
            // textBoxDatosTiempo
            // 
            this.textBoxDatosTiempo.Location = new System.Drawing.Point(126, 398);
            this.textBoxDatosTiempo.Name = "textBoxDatosTiempo";
            this.textBoxDatosTiempo.Size = new System.Drawing.Size(322, 20);
            this.textBoxDatosTiempo.TabIndex = 22;
            // 
            // textBoxDatosMonto
            // 
            this.textBoxDatosMonto.Location = new System.Drawing.Point(126, 372);
            this.textBoxDatosMonto.Name = "textBoxDatosMonto";
            this.textBoxDatosMonto.Size = new System.Drawing.Size(322, 20);
            this.textBoxDatosMonto.TabIndex = 21;
            // 
            // labelDatosTiempo
            // 
            this.labelDatosTiempo.AutoSize = true;
            this.labelDatosTiempo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelDatosTiempo.Location = new System.Drawing.Point(62, 401);
            this.labelDatosTiempo.Name = "labelDatosTiempo";
            this.labelDatosTiempo.Size = new System.Drawing.Size(58, 17);
            this.labelDatosTiempo.TabIndex = 20;
            this.labelDatosTiempo.Text = "Tiempo:";
            // 
            // labelDatosGasto
            // 
            this.labelDatosGasto.AutoSize = true;
            this.labelDatosGasto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelDatosGasto.Location = new System.Drawing.Point(12, 427);
            this.labelDatosGasto.Name = "labelDatosGasto";
            this.labelDatosGasto.Size = new System.Drawing.Size(108, 17);
            this.labelDatosGasto.TabIndex = 19;
            this.labelDatosGasto.Text = "Gasto De Cierre:";
            // 
            // labelDatosMonto
            // 
            this.labelDatosMonto.AutoSize = true;
            this.labelDatosMonto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelDatosMonto.Location = new System.Drawing.Point(68, 375);
            this.labelDatosMonto.Name = "labelDatosMonto";
            this.labelDatosMonto.Size = new System.Drawing.Size(52, 17);
            this.labelDatosMonto.TabIndex = 18;
            this.labelDatosMonto.Text = "Monto:";
            // 
            // labelDatosTasa
            // 
            this.labelDatosTasa.AutoSize = true;
            this.labelDatosTasa.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelDatosTasa.Location = new System.Drawing.Point(303, 427);
            this.labelDatosTasa.Name = "labelDatosTasa";
            this.labelDatosTasa.Size = new System.Drawing.Size(41, 17);
            this.labelDatosTasa.TabIndex = 24;
            this.labelDatosTasa.Text = "Tasa:";
            // 
            // textBoxDatosTasa
            // 
            this.textBoxDatosTasa.Location = new System.Drawing.Point(350, 424);
            this.textBoxDatosTasa.Name = "textBoxDatosTasa";
            this.textBoxDatosTasa.Size = new System.Drawing.Size(98, 20);
            this.textBoxDatosTasa.TabIndex = 25;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 545);
            this.Controls.Add(this.textBoxDatosTasa);
            this.Controls.Add(this.labelDatosTasa);
            this.Controls.Add(this.textBoxDatosGastos);
            this.Controls.Add(this.textBoxDatosTiempo);
            this.Controls.Add(this.textBoxDatosMonto);
            this.Controls.Add(this.labelDatosTiempo);
            this.Controls.Add(this.labelDatosGasto);
            this.Controls.Add(this.labelDatosMonto);
            this.Controls.Add(this.labelDatosDelPrestamo);
            this.Controls.Add(this.textBoxGaranteTelefono);
            this.Controls.Add(this.textBoxGaranteCedula);
            this.Controls.Add(this.textBoxGaranteNombre);
            this.Controls.Add(this.labelGaranteTelefono);
            this.Controls.Add(this.labelGaranteCedula);
            this.Controls.Add(this.labelGaranteNombre);
            this.Controls.Add(this.textBoxDeudorTelefono);
            this.Controls.Add(this.textBoxDeudorCedula);
            this.Controls.Add(this.textBoxDeudorNombre);
            this.Controls.Add(this.labelDeudorTelefono);
            this.Controls.Add(this.labelDeudorCedula);
            this.Controls.Add(this.labelDeudorNombre);
            this.Controls.Add(this.labelGarante);
            this.Controls.Add(this.labelDeudor);
            this.Controls.Add(this.headerPrestamo);
            this.Controls.Add(this.buttonPrestamosGuardar);
            this.Controls.Add(this.buttonPrestamosCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrestamosCancelar;
        private System.Windows.Forms.Button buttonPrestamosGuardar;
        private System.Windows.Forms.Label headerPrestamo;
        private System.Windows.Forms.Label labelDeudor;
        private System.Windows.Forms.Label labelGarante;
        private System.Windows.Forms.Label labelDeudorNombre;
        private System.Windows.Forms.Label labelDeudorCedula;
        private System.Windows.Forms.Label labelDeudorTelefono;
        private System.Windows.Forms.TextBox textBoxDeudorNombre;
        private System.Windows.Forms.TextBox textBoxDeudorCedula;
        private System.Windows.Forms.TextBox textBoxDeudorTelefono;
        private System.Windows.Forms.Label labelGaranteNombre;
        private System.Windows.Forms.Label labelGaranteTelefono;
        private System.Windows.Forms.Label labelGaranteCedula;
        private System.Windows.Forms.TextBox textBoxGaranteTelefono;
        private System.Windows.Forms.TextBox textBoxGaranteCedula;
        private System.Windows.Forms.TextBox textBoxGaranteNombre;
        private System.Windows.Forms.Label labelDatosDelPrestamo;
        private System.Windows.Forms.TextBox textBoxDatosGastos;
        private System.Windows.Forms.TextBox textBoxDatosTiempo;
        private System.Windows.Forms.TextBox textBoxDatosMonto;
        private System.Windows.Forms.Label labelDatosTiempo;
        private System.Windows.Forms.Label labelDatosGasto;
        private System.Windows.Forms.Label labelDatosMonto;
        private System.Windows.Forms.Label labelDatosTasa;
        private System.Windows.Forms.TextBox textBoxDatosTasa;
    }
}