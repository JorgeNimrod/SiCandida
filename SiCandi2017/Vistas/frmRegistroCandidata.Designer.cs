namespace SiCandi2017.Vistas
{
    partial class frmRegistroCandidata
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
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.dtpAnioConvocatoria = new System.Windows.Forms.DateTimePicker();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtNivelEstudios = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCamara
            // 
            this.cmbCamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(581, 282);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(214, 26);
            this.cmbCamara.TabIndex = 83;
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.Location = new System.Drawing.Point(581, 242);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(214, 34);
            this.btnTomarFoto.TabIndex = 82;
            this.btnTomarFoto.Text = "Capturar/Finalizar";
            this.btnTomarFoto.UseVisualStyleBackColor = true;
            this.btnTomarFoto.Click += new System.EventHandler(this.btnTomarFoto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(150, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 34);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(12, 356);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(132, 34);
            this.btnRegistro.TabIndex = 70;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(581, 6);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(214, 230);
            this.picImagen.TabIndex = 81;
            this.picImagen.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 190);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(552, 160);
            this.txtDescripcion.TabIndex = 69;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(425, 102);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(140, 28);
            this.cmbMunicipio.TabIndex = 68;
            // 
            // dtpAnioConvocatoria
            // 
            this.dtpAnioConvocatoria.Location = new System.Drawing.Point(160, 102);
            this.dtpAnioConvocatoria.Name = "dtpAnioConvocatoria";
            this.dtpAnioConvocatoria.Size = new System.Drawing.Size(173, 26);
            this.dtpAnioConvocatoria.TabIndex = 67;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(160, 70);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(138, 26);
            this.txtCorreoElectronico.TabIndex = 65;
            this.txtCorreoElectronico.TextChanged += new System.EventHandler(this.txtCorreoElectronico_TextChanged);
            // 
            // txtNivelEstudios
            // 
            this.txtNivelEstudios.Location = new System.Drawing.Point(458, 70);
            this.txtNivelEstudios.Name = "txtNivelEstudios";
            this.txtNivelEstudios.Size = new System.Drawing.Size(107, 26);
            this.txtNivelEstudios.TabIndex = 66;
            this.txtNivelEstudios.TextChanged += new System.EventHandler(this.txtNivelEstudios_TextChanged);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(160, 38);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(180, 26);
            this.dtpFechaNacimiento.TabIndex = 63;
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(399, 38);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(166, 26);
            this.txtCurp.TabIndex = 64;
            this.txtCurp.TextChanged += new System.EventHandler(this.txtCurp_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(404, 26);
            this.txtNombre.TabIndex = 62;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "Municipio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Año Convocatoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Fecha Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nivel De Estudios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Curp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nombre Completo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(581, 314);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(214, 76);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frmRegistroCandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 412);
            this.Controls.Add(this.cmbCamara);
            this.Controls.Add(this.btnTomarFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbMunicipio);
            this.Controls.Add(this.dtpAnioConvocatoria);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.txtNivelEstudios);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroCandidata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Candidata";
            this.Load += new System.EventHandler(this.frmRegistroCandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.Button btnTomarFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.DateTimePicker dtpAnioConvocatoria;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtNivelEstudios;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}