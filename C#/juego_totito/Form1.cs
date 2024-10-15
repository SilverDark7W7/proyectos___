using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOTITO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int turno = 1;
        int empate = 0;
        int jugador1 = 0;
        int jugador2 = 0;

        private void condicion()
        {

            if (turno == 1)
            {
                turno = 2;
            }

            else
            {
                turno = 1;
            }
            labelpuntaje1.Text = jugador1.ToString();
            labelpuntaje2.Text = jugador2.ToString();
        }
        private void puntos()
        {
            if (turno == 1)
            {
                jugador1++;
            }

            else
            {
                if (turno == 2)
                {
                    jugador2++;
                }
            }
            condicion();
        }
        private void comprobar()
        {
            if (boton1.Text == "X" && boton2.Text == "X" && boton3.Text == "X")
            {
                boton4.Visible = false;
                boton5.Visible = false;
                boton6.Visible = false;
                boton7.Visible = false;
                boton8.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos(); 
            }

            else
            if (boton4.Text == "X" && boton5.Text == "X" && boton6.Text == "X")
            {
                boton1.Visible = false;
                boton2.Visible = false;
                boton3.Visible = false;
                boton7.Visible = false;
                boton8.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton7.Text == "X" && boton8.Text == "X" && boton9.Text == "X")
            {
                boton1.Visible = false;
                boton2.Visible = false;
                boton3.Visible = false;
                boton4.Visible = false;
                boton5.Visible = false;
                boton6.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton1.Text == "X" && boton4.Text == "X" && boton7.Text == "X")
            {
                boton2.Visible = false;
                boton5.Visible = false;
                boton8.Visible = false;
                boton3.Visible = false;
                boton6.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton2.Text == "X" && boton5.Text == "X" && boton8.Text == "X")
            {
                boton1.Visible = false;
                boton4.Visible = false;
                boton7.Visible = false;
                boton3.Visible = false;
                boton6.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton3.Text == "X" && boton6.Text == "X" && boton9.Text == "X")
            {
                boton1.Visible = false;
                boton4.Visible = false;
                boton7.Visible = false;
                boton2.Visible = false;
                boton5.Visible = false;
                boton8.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton1.Text == "X" && boton5.Text == "X" && boton9.Text == "X")
            {
                boton2.Visible = false;
                boton3.Visible = false;
                boton4.Visible = false;
                boton6.Visible = false;
                boton7.Visible = false;
                boton8.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton3.Text == "X" && boton5.Text == "X" && boton7.Text == "X")
            {
                boton1.Visible = false;
                boton2.Visible = false;
                boton4.Visible = false;
                boton6.Visible = false;
                boton8.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }
            //-------------------------------------------------------------------------------------------------------

            else
            if (boton1.Text == "O" && boton2.Text == "O" && boton3.Text == "O")
            {
                turnos.Text = "Turno jugador 2";
                boton4.Visible = false;
                boton5.Visible = false;
                boton6.Visible = false;
                boton7.Visible = false;
                boton8.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton4.Text == "O" && boton5.Text == "O" && boton6.Text == "O")
            {
                boton1.Visible = false;
                boton2.Visible = false;
                boton3.Visible = false;
                boton7.Visible = false;
                boton8.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton7.Text == "O" && boton8.Text == "O" && boton9.Text == "O")
            {
                boton1.Visible = false;
                boton2.Visible = false;
                boton3.Visible = false;
                boton4.Visible = false;
                boton5.Visible = false;
                boton6.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton1.Text == "O" && boton4.Text == "O" && boton7.Text == "O")
            {
                boton2.Visible = false;
                boton5.Visible = false;
                boton8.Visible = false;
                boton3.Visible = false;
                boton6.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton2.Text == "O" && boton5.Text == "O" && boton8.Text == "O")
            {
                boton1.Visible = false;
                boton4.Visible = false;
                boton7.Visible = false;
                boton3.Visible = false;
                boton6.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton3.Text == "O" && boton6.Text == "O" && boton9.Text == "O")
            {
                boton1.Visible = false;
                boton4.Visible = false;
                boton7.Visible = false;
                boton2.Visible = false;
                boton5.Visible = false;
                boton8.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton1.Text == "O" && boton5.Text == "O" && boton9.Text == "O")
            {
                boton2.Visible = false;
                boton3.Visible = false;
                boton4.Visible = false;
                boton6.Visible = false;
                boton7.Visible = false;
                boton8.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            if (boton3.Text == "O" && boton5.Text == "O" && boton7.Text == "O")
            {
                boton1.Visible = false;
                boton2.Visible = false;
                boton4.Visible = false;
                boton6.Visible = false;
                boton8.Visible = false;
                boton9.Visible = false;
                MessageBox.Show("GANO JUGAGOR " + turno);
                puntos();
            }

            else
            empate++;
            if (empate == 9)
            {
                MessageBox.Show("HAY UN EMPATE");
            }


        }
        private void llenado(Button y)
        {
            if (y.Text=="" && nombre1.Text == "" && nombre2.Text == "")
            {
                boton1.Enabled = false;
                boton2.Enabled = false;
                boton3.Enabled = false;
                boton4.Enabled = false;
                boton5.Enabled = false;
                boton6.Enabled = false;
                boton7.Enabled = false;
                boton8.Enabled = false;
                boton9.Enabled = false;
            }

            if (y.Text == "")
            {
               

                if (turno == 1)
                {
                    turnos.Text = "Turno Jugador 2";
                    y.Text = "X";
                    comprobar();
                    turno = 2;
                }

                else
                {
                    if (turno == 2)
                    {
                        turnos.Text = "Turno Jugador 1";
                        y.Text = "O";
                        comprobar();
                        turno = 1;
                    }
                }
            }
        }

        
        
        private void boton1_Click(object sender, EventArgs e)
        {

            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }
            else
            {
                llenado(boton1);
                boton1.Enabled = false;
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }
            else
            {
                llenado(boton2);
                boton2.Enabled = false;
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }

            else
            {
                llenado(boton3);
                boton3.Enabled = false;
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }

            else
            {
                llenado(boton4);
                boton4.Enabled = false;
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }

            else
            {
                llenado(boton5);
                boton5.Enabled = false;
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }

            else
            {
                llenado(boton6);
                boton6.Enabled = false;
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }

            else
            {
                llenado(boton7);
                boton7.Enabled = false;
            }
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }
            else
            {
                llenado(boton8);
                boton8.Enabled = false;
            }
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            if (nombre1.Text == "" && nombre2.Text == "")
            {
                errorProvider1.SetError(nombre1, "Debe de ingresar un nombre");
                errorProvider2.SetError(nombre2, "Debe de ingresar un nombre");
            }

            else
            {
                llenado(boton9);
                boton9.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            empate = 0;
            boton1.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            boton4.Visible = true;
            boton5.Visible = true;
            boton6.Visible = true;
            boton7.Visible = true;
            boton8.Visible = true;
            boton9.Visible = true;
            boton1.Text = "";
            boton2.Text = "";
            boton3.Text = "";
            boton4.Text = "";
            boton5.Text = "";
            boton6.Text = "";
            boton7.Text = "";
            boton8.Text = "";
            boton9.Text = "";
            boton1.Enabled = true;
            boton2.Enabled = true;
            boton3.Enabled = true;
            boton4.Enabled = true;
            boton5.Enabled = true;
            boton6.Enabled = true;
            boton7.Enabled = true;
            boton8.Enabled = true;
            boton9.Enabled = true;
        }

        private void botonsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (nombre1.Text != "")
            {
                errorProvider1.SetError(nombre1, "");
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (nombre1.Text != "")
            {
                errorProvider2.SetError(nombre2, "");

            }
        }

        private void botoniniciar_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labeltitulo_Click(object sender, EventArgs e)
        {

        }

        private void boton1_Validated(object sender, EventArgs e)
        {

        }

        private void turnos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
