﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiCandi2017.Comun;
using SiCandi2017.Controlador;
using SiCandi_Library.Modelo;
using System.Drawing.Imaging;

namespace SiCandi2017.Vistas
{
    public partial class frmRegistroMunicipio : Form
    {
        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }
        public frmRegistroMunicipio()
        {
            InitializeComponent();
        }

        private void frmRegistroMunicipio_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (this.txtNombreMunicipio.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNombreMunicipio, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNombreMunicipio, "Campo necesario");
                this.txtNombreMunicipio.Focus();
            }
            else if (this.txtDescripcion.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtDescripcion, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtDescripcion, "Campo necesario");
                this.txtDescripcion.Focus();
            }
            else
            {
                Municipio nMunicipio = new Municipio();

                nMunicipio.sNombre = txtNombreMunicipio.Text;
                nMunicipio.sDescripcion = txtDescripcion.Text;
                nMunicipio.sLogotipo = ImagenString;
                ManejoMunicipio.Guardar(nMunicipio);

                MessageBox.Show("¡Municipio Registrado!");
                txtNombreMunicipio.Clear();
                txtDescripcion.Clear();
                txtNombreMunicipio.Focus();
                pcbLogo.Image = null;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNombreMunicipio_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarMunicipio v = new frmBuscarMunicipio();
            v.ShowDialog();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen|*.jpg;*.png;*gif;*.bmp";
                //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Seleccione una imagen";
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    string logo = BuscarImagen.FileName;
                    this.pcbLogo.ImageLocation = logo;
                    ImagenBitmap = new System.Drawing.Bitmap(logo);
                    ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
                    pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }
    }
}
