namespace SiCandi2017.Vistas
{
    partial class frmRegistrarUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancelarAgregarUsuario = new System.Windows.Forms.Button();
            this.btbAceptarAgregarUsuario = new System.Windows.Forms.Button();
            this.txtEmailAgregarUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenaAgregarUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 28);
            this.comboBox1.TabIndex = 28;
            // 
            // btnCancelarAgregarUsuario
            // 
            this.btnCancelarAgregarUsuario.Location = new System.Drawing.Point(239, 125);
            this.btnCancelarAgregarUsuario.Name = "btnCancelarAgregarUsuario";
            this.btnCancelarAgregarUsuario.Size = new System.Drawing.Size(86, 39);
            this.btnCancelarAgregarUsuario.TabIndex = 27;
            this.btnCancelarAgregarUsuario.Text = "Cancelar";
            this.btnCancelarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarUsuario.Click += new System.EventHandler(this.btnCancelarAgregarUsuario_Click);
            // 
            // btbAceptarAgregarUsuario
            // 
            this.btbAceptarAgregarUsuario.Location = new System.Drawing.Point(147, 125);
            this.btbAceptarAgregarUsuario.Name = "btbAceptarAgregarUsuario";
            this.btbAceptarAgregarUsuario.Size = new System.Drawing.Size(86, 39);
            this.btbAceptarAgregarUsuario.TabIndex = 26;
            this.btbAceptarAgregarUsuario.Text = "Agregar";
            this.btbAceptarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btbAceptarAgregarUsuario.Click += new System.EventHandler(this.btbAceptarAgregarUsuario_Click);
            // 
            // txtEmailAgregarUsuario
            // 
            this.txtEmailAgregarUsuario.Location = new System.Drawing.Point(112, 9);
            this.txtEmailAgregarUsuario.Name = "txtEmailAgregarUsuario";
            this.txtEmailAgregarUsuario.Size = new System.Drawing.Size(213, 26);
            this.txtEmailAgregarUsuario.TabIndex = 25;
            // 
            // txtContrasenaAgregarUsuario
            // 
            this.txtContrasenaAgregarUsuario.Location = new System.Drawing.Point(112, 50);
            this.txtContrasenaAgregarUsuario.Name = "txtContrasenaAgregarUsuario";
            this.txtContrasenaAgregarUsuario.PasswordChar = '*';
            this.txtContrasenaAgregarUsuario.Size = new System.Drawing.Size(213, 26);
            this.txtContrasenaAgregarUsuario.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Matricula";
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCancelarAgregarUsuario);
            this.Controls.Add(this.btbAceptarAgregarUsuario);
            this.Controls.Add(this.txtEmailAgregarUsuario);
            this.Controls.Add(this.txtContrasenaAgregarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.frmRegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCancelarAgregarUsuario;
        private System.Windows.Forms.Button btbAceptarAgregarUsuario;
        private System.Windows.Forms.TextBox txtEmailAgregarUsuario;
        private System.Windows.Forms.TextBox txtContrasenaAgregarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}