namespace SiCandi2017.Vistas
{
    partial class frmMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCandidatas = new System.Windows.Forms.Button();
            this.btnMunicipio = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCandidatas);
            this.groupBox1.Controls.Add(this.btnMunicipio);
            this.groupBox1.Location = new System.Drawing.Point(-2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(6, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 75);
            this.button1.TabIndex = 3;
            this.button1.Tag = "3";
            this.button1.Text = "REPORTES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCandidatas
            // 
            this.btnCandidatas.Enabled = false;
            this.btnCandidatas.Location = new System.Drawing.Point(6, 15);
            this.btnCandidatas.Name = "btnCandidatas";
            this.btnCandidatas.Size = new System.Drawing.Size(221, 78);
            this.btnCandidatas.TabIndex = 1;
            this.btnCandidatas.Tag = "1";
            this.btnCandidatas.Text = "CANDIDATAS";
            this.btnCandidatas.UseVisualStyleBackColor = true;
            this.btnCandidatas.Click += new System.EventHandler(this.btnCandidatas_Click);
            // 
            // btnMunicipio
            // 
            this.btnMunicipio.Enabled = false;
            this.btnMunicipio.Location = new System.Drawing.Point(6, 99);
            this.btnMunicipio.Name = "btnMunicipio";
            this.btnMunicipio.Size = new System.Drawing.Size(221, 76);
            this.btnMunicipio.TabIndex = 2;
            this.btnMunicipio.Tag = "2";
            this.btnMunicipio.Text = "MUNICIPIOS";
            this.btnMunicipio.UseVisualStyleBackColor = true;
            this.btnMunicipio.Click += new System.EventHandler(this.btnMunicipio_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 308);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.frmMenu_Activated);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCandidatas;
        private System.Windows.Forms.Button btnMunicipio;
    }
}