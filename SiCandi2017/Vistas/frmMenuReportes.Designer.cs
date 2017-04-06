namespace SiCandi2017.Vistas
{
    partial class frmMenuReportes
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.gbxButtons = new System.Windows.Forms.GroupBox();
            this.btnCandiporConvo = new System.Windows.Forms.Button();
            this.btnCandiporMuni = new System.Windows.Forms.Button();
            this.btnCandiPuntuAlta = new System.Windows.Forms.Button();
            this.btnCandiGanaMuni = new System.Windows.Forms.Button();
            this.btnCandiCaptuCapturi = new System.Windows.Forms.Button();
            this.gbxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxButtons
            // 
            this.gbxButtons.Controls.Add(this.btnCandiCaptuCapturi);
            this.gbxButtons.Controls.Add(this.btnCandiGanaMuni);
            this.gbxButtons.Controls.Add(this.btnCandiPuntuAlta);
            this.gbxButtons.Controls.Add(this.btnCandiporMuni);
            this.gbxButtons.Controls.Add(this.btnCandiporConvo);
            this.gbxButtons.Location = new System.Drawing.Point(12, 12);
            this.gbxButtons.Name = "gbxButtons";
            this.gbxButtons.Size = new System.Drawing.Size(708, 165);
            this.gbxButtons.TabIndex = 0;
            this.gbxButtons.TabStop = false;
            // 
            // btnCandiporConvo
            // 
            this.btnCandiporConvo.Location = new System.Drawing.Point(6, 16);
            this.btnCandiporConvo.Name = "btnCandiporConvo";
            this.btnCandiporConvo.Size = new System.Drawing.Size(135, 125);
            this.btnCandiporConvo.TabIndex = 0;
            this.btnCandiporConvo.Text = "Candidatas por Convocatora";
            this.btnCandiporConvo.UseVisualStyleBackColor = true;
            this.btnCandiporConvo.Click += new System.EventHandler(this.btnCandiporConvo_Click);
            // 
            // btnCandiporMuni
            // 
            this.btnCandiporMuni.Location = new System.Drawing.Point(144, 16);
            this.btnCandiporMuni.Name = "btnCandiporMuni";
            this.btnCandiporMuni.Size = new System.Drawing.Size(135, 125);
            this.btnCandiporMuni.TabIndex = 1;
            this.btnCandiporMuni.Text = "Candidatas por Municipio";
            this.btnCandiporMuni.UseVisualStyleBackColor = true;
            this.btnCandiporMuni.Click += new System.EventHandler(this.btnCandiporMuni_Click);
            // 
            // btnCandiPuntuAlta
            // 
            this.btnCandiPuntuAlta.Location = new System.Drawing.Point(285, 16);
            this.btnCandiPuntuAlta.Name = "btnCandiPuntuAlta";
            this.btnCandiPuntuAlta.Size = new System.Drawing.Size(135, 125);
            this.btnCandiPuntuAlta.TabIndex = 2;
            this.btnCandiPuntuAlta.Text = "Candidata con Puntuacion mas Alta";
            this.btnCandiPuntuAlta.UseVisualStyleBackColor = true;
            this.btnCandiPuntuAlta.Click += new System.EventHandler(this.btnCandiPuntuAlta_Click);
            // 
            // btnCandiGanaMuni
            // 
            this.btnCandiGanaMuni.Location = new System.Drawing.Point(426, 16);
            this.btnCandiGanaMuni.Name = "btnCandiGanaMuni";
            this.btnCandiGanaMuni.Size = new System.Drawing.Size(135, 125);
            this.btnCandiGanaMuni.TabIndex = 3;
            this.btnCandiGanaMuni.Text = "Candidatas Ganadoras por Municipio";
            this.btnCandiGanaMuni.UseVisualStyleBackColor = true;
            this.btnCandiGanaMuni.Click += new System.EventHandler(this.btnCandiGanaMuni_Click);
            // 
            // btnCandiCaptuCapturi
            // 
            this.btnCandiCaptuCapturi.Location = new System.Drawing.Point(567, 16);
            this.btnCandiCaptuCapturi.Name = "btnCandiCaptuCapturi";
            this.btnCandiCaptuCapturi.Size = new System.Drawing.Size(135, 125);
            this.btnCandiCaptuCapturi.TabIndex = 4;
            this.btnCandiCaptuCapturi.Text = "Candidatas capturadas por Capturista";
            this.btnCandiCaptuCapturi.UseVisualStyleBackColor = true;
            this.btnCandiCaptuCapturi.Click += new System.EventHandler(this.btnCandiCaptuCapturi_Click);
            // 
            // frmMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 204);
            this.Controls.Add(this.gbxButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Reportes";
            this.gbxButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.GroupBox gbxButtons;
        private System.Windows.Forms.Button btnCandiCaptuCapturi;
        private System.Windows.Forms.Button btnCandiGanaMuni;
        private System.Windows.Forms.Button btnCandiPuntuAlta;
        private System.Windows.Forms.Button btnCandiporMuni;
        private System.Windows.Forms.Button btnCandiporConvo;
    }
}