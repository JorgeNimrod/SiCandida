﻿namespace SiCandi2017.Vistas
{
    partial class frmBuscarCandidata
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.dgvDatosCandidata = new System.Windows.Forms.DataGridView();
            this.pkCandidata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAnioConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCurp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNivelEstudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarCandidata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(256, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 31);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(141, 406);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 31);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(26, 406);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 31);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(707, 379);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(73, 20);
            this.lblRegistros.TabIndex = 13;
            this.lblRegistros.Text = "Registro:";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Checked = true;
            this.ckbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStatus.Location = new System.Drawing.Point(29, 378);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(75, 24);
            this.ckbStatus.TabIndex = 12;
            this.ckbStatus.Text = "Status";
            this.ckbStatus.UseVisualStyleBackColor = true;
            this.ckbStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            // 
            // dgvDatosCandidata
            // 
            this.dgvDatosCandidata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCandidata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkCandidata,
            this.dtAnioConvocatoria,
            this.sNombreCompleto,
            this.dtFechaNacimiento,
            this.sDescripcion,
            this.sCorreoElectronico,
            this.sCurp,
            this.sNivelEstudios});
            this.dgvDatosCandidata.Location = new System.Drawing.Point(26, 48);
            this.dgvDatosCandidata.Name = "dgvDatosCandidata";
            this.dgvDatosCandidata.RowHeadersVisible = false;
            this.dgvDatosCandidata.Size = new System.Drawing.Size(803, 324);
            this.dgvDatosCandidata.TabIndex = 11;
            this.dgvDatosCandidata.DataSourceChanged += new System.EventHandler(this.dgvDatosCandidata_DataSourceChanged);
            // 
            // pkCandidata
            // 
            this.pkCandidata.DataPropertyName = "pkCandidata";
            this.pkCandidata.HeaderText = "Matricula";
            this.pkCandidata.Name = "pkCandidata";
            // 
            // dtAnioConvocatoria
            // 
            this.dtAnioConvocatoria.DataPropertyName = "dtAnioConvocatoria";
            this.dtAnioConvocatoria.HeaderText = "Comvocatoria";
            this.dtAnioConvocatoria.Name = "dtAnioConvocatoria";
            // 
            // sNombreCompleto
            // 
            this.sNombreCompleto.DataPropertyName = "sNombreCompleto";
            this.sNombreCompleto.HeaderText = "Nombre Completo";
            this.sNombreCompleto.Name = "sNombreCompleto";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.DataPropertyName = "dtFechaNacimiento";
            this.dtFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            // 
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "sDescripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            // 
            // sCorreoElectronico
            // 
            this.sCorreoElectronico.DataPropertyName = "sCorreoElectronico";
            this.sCorreoElectronico.HeaderText = "Correo";
            this.sCorreoElectronico.Name = "sCorreoElectronico";
            // 
            // sCurp
            // 
            this.sCurp.DataPropertyName = "sCurp";
            this.sCurp.HeaderText = "CURP";
            this.sCurp.Name = "sCurp";
            // 
            // sNivelEstudios
            // 
            this.sNivelEstudios.DataPropertyName = "sNivelEstudios";
            this.sNivelEstudios.HeaderText = "Nivel Estudios";
            this.sNivelEstudios.Name = "sNivelEstudios";
            // 
            // txtBuscarCandidata
            // 
            this.txtBuscarCandidata.Location = new System.Drawing.Point(243, 18);
            this.txtBuscarCandidata.Name = "txtBuscarCandidata";
            this.txtBuscarCandidata.Size = new System.Drawing.Size(584, 26);
            this.txtBuscarCandidata.TabIndex = 10;
            this.txtBuscarCandidata.TextChanged += new System.EventHandler(this.txtBuscarCandidata_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar Candidata Por Nombre";
            // 
            // frmBuscarCandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 455);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.dgvDatosCandidata);
            this.Controls.Add(this.txtBuscarCandidata);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBuscarCandidata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Candidata";
            this.Load += new System.EventHandler(this.frmBuscarCandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.DataGridView dgvDatosCandidata;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkCandidata;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAnioConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCurp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNivelEstudios;
        private System.Windows.Forms.TextBox txtBuscarCandidata;
        private System.Windows.Forms.Label label1;
    }
}