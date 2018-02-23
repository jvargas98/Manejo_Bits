using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Int32 datos;
            int resultado;
            datos = Convert.ToInt32(txtDatos.Text);

            datos >>= 1; // Quitar el primer bit que no se utiliza

            resultado = datos & 7; // Hacemos una comparacion de 3 bits con los que podemos obtener 8 resultados

            if (resultado == 0)
            {
                pctbxDireccion.Image = imageList1.Images[0];
            }
            else if (resultado == 1)
            {
                pctbxDireccion.Image = imageList1.Images[1];
            }
            else if(resultado == 2){
                pctbxDireccion.Image = imageList1.Images[2];
            }
            else if (resultado == 3)
            {
                pctbxDireccion.Image = imageList1.Images[3];
            }
            else if (resultado == 4)
            {
                pctbxDireccion.Image = imageList1.Images[4];
            }
            else if (resultado == 5)
            {
                pctbxDireccion.Image = imageList1.Images[5];
            }
            else if (resultado == 6)
            {
                pctbxDireccion.Image = imageList1.Images[6];
            }
            else if (resultado == 7)
            {
                pctbxDireccion.Image = imageList1.Images[7];
            }

            datos >>= 3; // Recorremos 3 bits para quitar los 3 bits de la direccion 

            resultado = datos & 3; // Hacemos una comparacion de 2 bits para obtener 4 resultados

            if (resultado == 0)
            {
                lblTanque.Text = "Vacion";
                progressBar1.Increment(0);
            }
            else if (resultado == 1)
            {
                lblTanque.Text = "50%";
                progressBar1.Increment(50);
            }
            else if (resultado == 2)
            {
                lblTanque.Text = "100%";
                progressBar1.Increment(100);
            }
            else if (resultado == 3)
            {
                lblTanque.Text = "Proceso de llenado";
                progressBar1.Increment(0);
            }

            datos >>= 2; // Recorremos 2 bits para quitar los 2 bits del llenado de tanque

            resultado = datos & 1; // Hacemos una comparacion de 1 bit para obtener 2 resultados

            if (resultado == 0)
            {
                pctbxSensor2.Image = imageList1.Images[8];
            }
            else if(resultado == 1)
            {
                pctbxSensor2.Image = imageList1.Images[9];
            }

            datos >>= 1; // Recorremos 1 bit para quitar el bit del sensor 2

            resultado = datos & 1; // Hacemos una comparacion de 1 bit para obtener 2 resultados

            if (resultado == 0)
            {
                pctbxSensor1.Image = imageList1.Images[8];
            }
            else if(resultado == 1)
            {
                pctbxSensor1.Image = imageList1.Images[9];
            }

            datos >>= 1; // Recorremos 1 bit para quitar el bit del sensor 1

            resultado = datos & 31; // Hacemos una comparacion de 5 bist para obtener 32 resultados para los 31 dias
            lblFecha.Text += resultado.ToString() + "/";

            datos >>= 5; // Recorremos 5 bits para quitar los 5 bits para los dias 

            resultado = datos & 12; // Hacemos una comparacion de 4 bist para obtener 16 resultados para los 12 meses
            lblFecha.Text += resultado.ToString() + "/";

            datos >>= 4; // Recorremos 4 bits para quitar los 4 bits para los meses 

            resultado = datos & 127; // Hacemos una comparacion de 7 bist para obtener 128 resultados para los 127 años
            resultado += 1900;
            lblFecha.Text += resultado.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void btnAjustarfecha_Click(object sender, EventArgs e)
        {
            Int32 fecha;
            Int32 año = dtpFecha.Value.Year - 1900;
            fecha = año;
            fecha <<= 4;
            fecha += dtpFecha.Value.Month;
            fecha <<= 5;
            fecha += dtpFecha.Value.Day;
            txtResultado.Text = fecha.ToString();
        }
    }
}
