using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cultural
{

    public partial class Form1 : Form
    {
        int posicionActual = 0;
        string[] vector;
        bool permitido = false;

        public Form1()
        {
            InitializeComponent();


        }
     
        private void btnabrir_Click(object sender, EventArgs e)
        {
            try 
            {
                openFileDialog1.Title = " Buscar Palabras";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    permitido = true;
                    TextReader leer = new StreamReader(openFileDialog1.FileName);
                    string Texto = leer.ReadToEnd();
                    vector = Texto.Split(new char[] { '\n' });
                    leer.Close();
                }

            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Error escoja un archivo .txt permitido--{ex}--", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                imprimirSiguienteLinea();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error escoja un archivo .txt permitido--{ex}--", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }
        public void imprimirSiguienteLinea()
        {
            try
            {

                if (permitido)
                {
                    if (posicionActual < vector.Length)
                    {
                        label1.Text = vector[posicionActual];
                        posicionActual++;
                    }
                }
                else
                {
                    MessageBox.Show("Error sin datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
         


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error escoja un archivo .txt permitido--{ex}--", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            l_minutos.Left = up1.Left - ((l_minutos.Width - up1.Width) / 2);
            l_segundos.Left = up2.Left - ((l_segundos.Width - up2.Width) / 2);


        }



        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            control.Stop();

        }

        private void btn_Pasusar1_Click(object sender, EventArgs e)
        {
            control.Stop();
        }

        private void btn_comenzar_Click(object sender, EventArgs e)
        {
            control.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb1Numero_Click(object sender, EventArgs e)
        {
            up1.Visible = false;
            down1.Visible = false;
            up2.Visible = true;
            down2.Visible = true;
        }

        private void l_minutos_Click(object sender, EventArgs e)
        {
            up1.Visible = true;
            down1.Visible = true;
            up2.Visible = false;
            down2.Visible = false;

        }

        private void up1_Click(object sender, EventArgs e)
        {
            l_minutos.Text = (int.Parse(l_minutos.Text) + 1).ToString();

        }

        private void down1_Click(object sender, EventArgs e)
        {
            int minutos;
            if (int.TryParse(l_minutos.Text, out minutos) && minutos > 0)
            {
                minutos--;
                l_minutos.Text = minutos.ToString();
            }
        }

        private void up2_Click(object sender, EventArgs e)
        {
            l_segundos.Text = (int.Parse(l_segundos.Text) + 1).ToString();


        }

        private void down2_Click(object sender, EventArgs e)
        {
            int segundos;
            if (int.TryParse(l_segundos.Text, out segundos) && segundos > 0)
            {
                segundos--;
                l_segundos.Text = segundos.ToString();
            }
        }
        int minutos;
        int segundos;
        bool pro = false;
        public void btn_iniciar_tiempo_Click(object sender, EventArgs e)
        {
            
            if (permitido == true) 
            {
                int.TryParse(l_minutos.Text, out minutos);
                int.TryParse(l_segundos.Text, out segundos);

                if (pro)
                {
                    progressBar1.Enabled = true;
                }
                else
                {
                    if (minutos != 0)
                    {
                        progressBar1.Maximum = segundos;
                        progressBar1.Value = progressBar1.Maximum;
                    }

                    progressBar1.Enabled = false;

                    pro = true;
                }
            }
            else
            {
                MessageBox.Show("escoja el archivo de palabras primero","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
      


            btn_pausartm.BringToFront();
            temporizador.Interval = 1000;
            temporizador.Start();

            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
   
        
    }

        private void btn_pausartm_Click(object sender, EventArgs e)
        {
            btn_iniciar_tiempo.BringToFront();
            temporizador.Enabled = false;
          //  progressBar1.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            up1.Visible = true;
            down1.Visible = true;
            up2.Visible = false;
            down2.Visible = false;
           progressBar1.Value = 0;
            Progreso.Stop();
            temporizador.Stop();
            btn_iniciar_tiempo.BringToFront();
            l_minutos.Text = "00";
            l_segundos.Text = "00";

        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            ///*
            ///para si despues de 1 minutos el label de minutos e ponga cero y los de segundos en 60 segundos 
            /// 
            /// 
            ///
            
            if (segundos == 0 && minutos == 0 )
            {
                temporizador.Stop();
                MessageBox.Show("Cambio de Jugador","EL TIEMPO FINALIZO GAME-OVER", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (segundos == 0 && minutos > 0)
                {
                    segundos = 60;
                    minutos--;
                    l_minutos.Text = minutos.ToString();
                    l_segundos.Text = "60";
                }
                segundos--;
                l_segundos.Text = segundos.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Text = "00";

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            int tiempo = Convert.ToInt32(textBox1.Text);
            tiempo--;

            if (tiempo == -1)
            {
                timer1.Stop();
                MessageBox.Show("Game over ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox1.Text = tiempo.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}











































/* int numero = int.Parse(textBox1.Text);
            numero -= 1;
            textBox1.Text = numero.ToString();

            if (textBox1.Text == "0")
            {
                timer1.Stop();
                MessageBox.Show("El tiempo se ha agotado", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

/*seg -= 1;
string minutos= min.ToString("0#");
string hor = hora.ToString("0#");
string segundos = seg.ToString("0#");
if (hora < 10) { hor = hora.ToString("0#");}
if (min < 10) { minutos =min.ToString("0#"); }
if (seg < 10) { segundos = seg.ToString("0#"); }

if(seg==0 && min > 0)
{
    min -= 1;
    seg = 60;
}
if (min == 0 && hora>0 && seg == 0)
{
    seg = 60;
    hora -= 1;
    min = 59;

}
if (min == 0 && hora == 0 && seg == 0)
{
    timer1.Stop();
    MessageBox.Show("Se acabo el tiempo", "Finalizo", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
label1.Text=hor+":"+minutos+":"+segundos+":";*/










