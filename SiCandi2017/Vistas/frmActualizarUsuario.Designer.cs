﻿namespace SiCandi2017.Vistas
{
    partial class frmActualizarUsuario
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
            this.btnCancelarAgregarUsuario = new System.Windows.Forms.Button();
            this.btbAceptarAgregarUsuario = new System.Windows.Forms.Button();
            this.txtEmailAgregarUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarAgregarUsuario
            // 
            this.btnCancelarAgregarUsuario.Location = new System.Drawing.Point(227, 38);
            this.btnCancelarAgregarUsuario.Name = "btnCancelarAgregarUsuario";
            this.btnCancelarAgregarUsuario.Size = new System.Drawing.Size(86, 39);
            this.btnCancelarAgregarUsuario.TabIndex = 24;
            this.btnCancelarAgregarUsuario.Text = "Cancelar";
            this.btnCancelarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarUsuario.Click += new System.EventHandler(this.btnCancelarAgregarUsuario_Click);
            // 
            // btbAceptarAgregarUsuario
            // 
            this.btbAceptarAgregarUsuario.Location = new System.Drawing.Point(136, 38);
            this.btbAceptarAgregarUsuario.Name = "btbAceptarAgregarUsuario";
            this.btbAceptarAgregarUsuario.Size = new System.Drawing.Size(86, 39);
            this.btbAceptarAgregarUsuario.TabIndex = 23;
            this.btbAceptarAgregarUsuario.Text = "Registrar";
            this.btbAceptarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btbAceptarAgregarUsuario.Click += new System.EventHandler(this.btbAceptarAgregarUsuario_Click);
            // 
            // txtEmailAgregarUsuario
            // 
            this.txtEmailAgregarUsuario.Location = new System.Drawing.Point(100, 6);
            this.txtEmailAgregarUsuario.Name = "txtEmailAgregarUsuario";
            this.txtEmailAgregarUsuario.Size = new System.Drawing.Size(213, 26);
            this.txtEmailAgregarUsuario.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Matricula";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmActualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 93);
            this.Controls.Add(this.btnCancelarAgregarUsuario);
            this.Controls.Add(this.btbAceptarAgregarUsuario);
            this.Controls.Add(this.txtEmailAgregarUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmActualizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Usuario";
            this.Load += new System.EventHandler(this.frmActualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarAgregarUsuario;
        private System.Windows.Forms.Button btbAceptarAgregarUsuario;
        private System.Windows.Forms.TextBox txtEmailAgregarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}