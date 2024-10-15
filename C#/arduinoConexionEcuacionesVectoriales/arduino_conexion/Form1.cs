using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace arduino_conexion
{

    public partial class Form1 : Form
    {
        string lax;
        string lay;

        System.IO.Ports.SerialPort ardi;
        public Form1()
        {
            

            InitializeComponent();
            ardi = new System.IO.Ports.SerialPort();
            ardi.PortName = "COM9";
            ardi.BaudRate = 9600;

            try
            {
                if (!ardi.IsOpen)
                    ardi.Open();
                MessageBox.Show("Se conecto correctamente al arduino PUERTO: COM9", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ardi.Close();

            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
        private void ReiniciarArduino()
        {
            if (ardi.IsOpen)
            {
                ardi.WriteLine("apagar");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ecuacion_Click(object sender, EventArgs e)
        {
            lb_ecu.Visible = true;
            txt_ecuacion.Visible = true;
            combox_menu_cord.Visible = true;
            lb_vec_ecu.Visible = true;
            txt_Cx.Visible = false;
            txt_Cy.Visible = false;
            lb_x.Visible = false;
            lb_y.Visible = false;
            btn_formular_ecua.Visible = true;
            btn_formular_x_y.Visible = false;
            lb_puntos.Visible = false;
        }

        private void btn_vectores_Click(object sender, EventArgs e)
        {
            lb_ecu.Visible = false;
            txt_ecuacion.Visible = false;
            combox_menu_cord.Visible = false;
            lb_vec_ecu.Visible = false;

            txt_Cx.Visible = true;
            txt_Cy.Visible = true;
            lb_x.Visible = true;
            lb_y.Visible = true;
            btn_formular_ecua.Visible = false;
            btn_formular_x_y.Visible = true;
            lb_puntos.Visible = false;
        }

        private void btn_formular_x_y_Click(object sender, EventArgs e)
        {
            string x = txt_Cx.Text;
            string y = txt_Cy.Text;
            CX_CY vec = new CX_CY(x, y);
            MagnitudLabel.Visible = true;
            DireccionLabel.Visible = true;
            MagnitudLabel.Text = $"Magnitud: {vec.R}";
            DireccionLabel.Text = $"Dirección: {vec.angulo}";



        }

        private void btn_formular_ecua_Click(object sender, EventArgs e)
        {
            string a = txt_ecuacion.Text;
            string menu = combox_menu_cord.Text;
            char partido = ',';
            string[] partes = a.Split(partido);
            string parte1 = partes[0].Trim();
            string parte2 = partes[1].Trim();
            string total = parte1 + menu + parte2;
            total.Trim();
            a = a.Trim();
            a = a.ToLower();
            lb_vec_ecu.Text = total;


            /*     string direcion = combox_menu_cord.SelectedItem.ToString();
                 string ecuacicon_completa = string.Format(a, direcion, ",");
                 string b;
                 b = ecuacicon_completa.Trim();
                 string ecuacion = b.ToLower();*/


            ecuacion_generales generales = new ecuacion_generales(a);

            if (generales.EsOperacionValida)
            {
                
                MagnitudLabel.Text = $"Magnitud:  {generales.Magnitud}";
                DireccionLabel.Text = $"Dirección: {generales.Direccion} grados";
                ResultadoXLabel.Text = $"Resultado en X:   {generales.ResultadoX_Decimales }";
                ResultadoYLabel.Text = $"Resultado en Y:   {generales.ResultadoY_Decimales }";
                string X = Convert.ToString(generales.ResultadoX_Entero);
                string Y = Convert.ToString(generales.ResultadoY_Entero);
                lax = X;
                lay = Y;
            }
            else
            {
                MessageBox.Show("Operación de vector no válida.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ardi.Open();
                ReiniciarArduino();
                if (!string.IsNullOrEmpty(lax) && !string.IsNullOrEmpty(lay))
                {
                    int x = Convert.ToInt32(lax);
                    int y = Convert.ToInt32(lay);
                    if (x <= 5 && y <= 5)
                    {
                        lb_puntos.Visible = true;
                        lb_puntos.Text = $"Puntos: P1(0,0) P2({x},{y})";
                        lb_puntos.Refresh();
                        ardi.Write($"{x}_{y}");

                    }
                    else
                    {
                        string mensajeError = "Error: cantidad mayor al alcance de la matriz";
                        lb_puntos.Text = lb_puntos.Text + $" P1(0,0) P2({x},{y})";
                        tiempo_error.Interval = 4000;
                        tiempo_error.Tick += (s, ev) =>
                        {
                            lb_puntos.Text = lb_puntos.Text.Replace(" # " + mensajeError, "");
                            tiempo_error.Stop();
                        };
                        tiempo_error.Start();
                    }

                }
                else
                {
                    string mensajeError = "Error: datos de los puntos no legibles Codigo alcance no llegado";
                    tiempo_error.Interval = 4000;
                    tiempo_error.Tick += (s, ev) =>
                    {
                        lb_puntos.Text = lb_puntos.Text.Replace(" # " + mensajeError, " #");
                        tiempo_error.Stop();
                    };
                    tiempo_error.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: datos no funcionales " + ex.Message, "Error-Codigo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (ardi != null && ardi.IsOpen)
                {
                    ardi.Close(); 
                }
            }

        }

        private void Tiempo_error_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
