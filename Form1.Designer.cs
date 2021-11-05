
using System.ComponentModel;

namespace Inmobiliaria
{
    partial class Form1

    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (Components != null))
            {
                Components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrecio = new System.Windows.Forms.Button();
            this.lblInmueble = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.radiobtnPiso = new System.Windows.Forms.RadioButton();
            this.radiobtnLocal = new System.Windows.Forms.RadioButton();
            this.txtNumPiso = new System.Windows.Forms.TextBox();
            this.txtVentanas = new System.Windows.Forms.TextBox();
            this.lblNumPiso = new System.Windows.Forms.Label();
            this.lblVentanas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(135, 260);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(140, 36);
            this.btnPrecio.TabIndex = 0;
            this.btnPrecio.Text = "Calcular Precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            // 
            // lblInmueble
            // 
            this.lblInmueble.AutoSize = true;
            this.lblInmueble.Location = new System.Drawing.Point(51, 30);
            this.lblInmueble.Name = "lblInmueble";
            this.lblInmueble.Size = new System.Drawing.Size(91, 13);
            this.lblInmueble.TabIndex = 3;
            this.lblInmueble.Text = "Tipo de inmueble:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(168, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 139);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(44, 155);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(298, 20);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Location = new System.Drawing.Point(21, 193);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(92, 13);
            this.lblSuperficie.TabIndex = 7;
            this.lblSuperficie.Text = "Superficie (en m2)";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(150, 193);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(93, 13);
            this.lblAntiguedad.TabIndex = 8;
            this.lblAntiguedad.Text = "Antigüedad (años)";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(297, 193);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(63, 13);
            this.lblPrecioBase.TabIndex = 9;
            this.lblPrecioBase.Text = "Precio base";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(44, 209);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(49, 20);
            this.txtSuperficie.TabIndex = 10;
            this.txtSuperficie.TextChanged += new System.EventHandler(this.txtSuperficie_TextChanged);
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(180, 209);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(46, 20);
            this.txtAntiguedad.TabIndex = 11;
            this.txtAntiguedad.TextChanged += new System.EventHandler(this.txtAntiguedad_TextChanged);
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(288, 209);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(83, 20);
            this.txtPrecioBase.TabIndex = 12;
            this.txtPrecioBase.TextChanged += new System.EventHandler(this.txtPrecioBase_TextChanged);
            // 
            // radiobtnPiso
            // 
            this.radiobtnPiso.AutoSize = true;
            this.radiobtnPiso.Location = new System.Drawing.Point(180, 28);
            this.radiobtnPiso.Name = "radiobtnPiso";
            this.radiobtnPiso.Size = new System.Drawing.Size(45, 17);
            this.radiobtnPiso.TabIndex = 13;
            this.radiobtnPiso.TabStop = true;
            this.radiobtnPiso.Text = "Piso";
            this.radiobtnPiso.UseVisualStyleBackColor = true;
            this.radiobtnPiso.CheckedChanged += new System.EventHandler(this.radiobtnPiso_CheckedChanged);
            // 
            // radiobtnLocal
            // 
            this.radiobtnLocal.AutoSize = true;
            this.radiobtnLocal.Location = new System.Drawing.Point(300, 26);
            this.radiobtnLocal.Name = "radiobtnLocal";
            this.radiobtnLocal.Size = new System.Drawing.Size(51, 17);
            this.radiobtnLocal.TabIndex = 14;
            this.radiobtnLocal.TabStop = true;
            this.radiobtnLocal.Text = "Local";
            this.radiobtnLocal.UseVisualStyleBackColor = true;
            this.radiobtnLocal.CheckedChanged += new System.EventHandler(this.radiobtnLocal_CheckedChanged);
            // 
            // txtNumPiso
            // 
            this.txtNumPiso.Location = new System.Drawing.Point(168, 83);
            this.txtNumPiso.Name = "txtNumPiso";
            this.txtNumPiso.Size = new System.Drawing.Size(58, 20);
            this.txtNumPiso.TabIndex = 15;
            this.txtNumPiso.TextChanged += new System.EventHandler(this.txtNumPiso_TextChanged);
            // 
            // txtVentanas
            // 
            this.txtVentanas.Location = new System.Drawing.Point(288, 83);
            this.txtVentanas.Name = "txtVentanas";
            this.txtVentanas.Size = new System.Drawing.Size(63, 20);
            this.txtVentanas.TabIndex = 16;
            this.txtVentanas.TextChanged += new System.EventHandler(this.txtVentanas_TextChanged);
            // 
            // lblNumPiso
            // 
            this.lblNumPiso.AutoSize = true;
            this.lblNumPiso.Location = new System.Drawing.Point(162, 65);
            this.lblNumPiso.Name = "lblNumPiso";
            this.lblNumPiso.Size = new System.Drawing.Size(81, 13);
            this.lblNumPiso.TabIndex = 17;
            this.lblNumPiso.Text = "Número de piso";
            // 
            // lblVentanas
            // 
            this.lblVentanas.AutoSize = true;
            this.lblVentanas.Location = new System.Drawing.Point(266, 65);
            this.lblVentanas.Name = "lblVentanas";
            this.lblVentanas.Size = new System.Drawing.Size(119, 13);
            this.lblVentanas.TabIndex = 18;
            this.lblVentanas.Text = "Cantidad de ventanales";
            // 
            // BotonPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 348);
            this.Controls.Add(this.lblVentanas);
            this.Controls.Add(this.lblNumPiso);
            this.Controls.Add(this.txtVentanas);
            this.Controls.Add(this.txtNumPiso);
            this.Controls.Add(this.radiobtnLocal);
            this.Controls.Add(this.radiobtnPiso);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblInmueble);
            this.Controls.Add(this.btnPrecio);
            this.Name = "BotonPrecio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label lblInmueble;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.RadioButton radiobtnPiso;
        private System.Windows.Forms.RadioButton radiobtnLocal;
        private System.Windows.Forms.TextBox txtNumPiso;
        private System.Windows.Forms.TextBox txtVentanas;
        private System.Windows.Forms.Label lblNumPiso;
        private System.Windows.Forms.Label lblVentanas;

        public IContainer Components { get => components; set => components = value; }
    }
}

