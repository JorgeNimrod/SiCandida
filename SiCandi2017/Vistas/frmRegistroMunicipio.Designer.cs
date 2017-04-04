namespace SiCandi2017.Vistas
{
    partial class frmRegistroMunicipio
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
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.txtNombreMunicipio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(127, 218);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(167, 27);
            this.btnExaminar.TabIndex = 43;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(264, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 34);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(24, 382);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(132, 34);
            this.btnRegistro.TabIndex = 41;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(162, 382);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 34);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 274);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(372, 102);
            this.txtDescripcion.TabIndex = 39;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Descripcion";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Location = new System.Drawing.Point(127, 65);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(167, 147);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 37;
            this.pcbLogo.TabStop = false;
            // 
            // txtNombreMunicipio
            // 
            this.txtNombreMunicipio.Location = new System.Drawing.Point(20, 30);
            this.txtNombreMunicipio.Name = "txtNombreMunicipio";
            this.txtNombreMunicipio.Size = new System.Drawing.Size(372, 26);
            this.txtNombreMunicipio.TabIndex = 36;
            this.txtNombreMunicipio.TextChanged += new System.EventHandler(this.txtNombreMunicipio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre Del Municipio";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frmRegistroMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 437);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.txtNombreMunicipio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistroMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Municipio";
            this.Load += new System.EventHandler(this.frmRegistroMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TextBox txtNombreMunicipio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}