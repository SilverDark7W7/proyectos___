using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace canculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void menu_operaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            try
            {
                //  a = Convert.ToInt32(menu_operaciones);
                switch (menu_operaciones.SelectedIndex)
                {
                    case 0:
                        string operacion = "sumar";
                        int suma_int = 0;
                        string suma_char;
                        int num1;
                        num1 = Convert.ToInt32(txt_ciftra1.Text);
                        int num2;
                        num2 = Convert.ToInt32(txt_cifra2.Text);
                        suma_int = num1 + num2;
                        suma_char = Convert.ToString(suma_int);
                        txt_resultado.Text = suma_char;
                        string datos1 = txt_ciftra1.Text;
                        string datos2 = txt_cifra2.Text;
                        DataTable c;
                        resultados_base_datos datos_sql = new resultados_base_datos();
                        c = datos_sql.mostrar_resultados(datos1, datos2, operacion, suma_char);
                        resultados_datos.DataSource = c;
                        break;
                    case 1:
                          string resta = "Restar";
                        int resta_int = 0;
                        string resta_char;
                        int restarnum1;
                        restarnum1 = Convert.ToInt32(txt_ciftra1.Text);
                        int restarnum2;
                        restarnum2 = Convert.ToInt32(txt_cifra2.Text);
                        resta_int = restarnum1 - restarnum2;
                       resta_char = Convert.ToString(resta_int);
                        txt_resultado.Text = resta_char;
                        string restadatos1 = txt_ciftra1.Text;
                        string restadatos2 = txt_cifra2.Text;
                        DataTable restarc;
                        resultados_base_datos restadatos_sql = new resultados_base_datos();
                        restarc = restadatos_sql.mostrar_resultados(restadatos1, restadatos2, resta, resta_char);
                        resultados_datos.DataSource = restarc;
                        break;
                    case 2:
                        string multiplicacion = "Multiplicar";
                        int multiplicar = 0;
                        string multi_char;
                        int multinum1;
                        multinum1 = Convert.ToInt32(txt_ciftra1.Text);
                        int multinum2;
                        multinum2 = Convert.ToInt32(txt_cifra2.Text);
                        multiplicar = multinum1 * multinum2;
                        multi_char = Convert.ToString(multiplicar);
                        txt_resultado.Text =multi_char;
                        string multidatos1 = txt_ciftra1.Text;
                        string multidatos2 = txt_cifra2.Text;
                        DataTable multic;
                        resultados_base_datos multidatos_sql = new resultados_base_datos();
                        multic = multidatos_sql.mostrar_resultados(multidatos1, multidatos2, multiplicacion, multi_char);
                        resultados_datos.DataSource = multic;
                        break;
                    case 3:
                        string dividir = "Dividir";
                        int div_int = 0;
                        string div_char;
                        int divnum1;
                        divnum1 = Convert.ToInt32(txt_ciftra1.Text);
                        int divnum2;
                        divnum2 = Convert.ToInt32(txt_cifra2.Text);
                        div_int = divnum1 + divnum2;
                        div_char = Convert.ToString(div_int);
                        txt_resultado.Text = div_char;
                        string divdatos1 = txt_ciftra1.Text;
                        string divdatos2 = txt_cifra2.Text;
                        DataTable divc;
                        resultados_base_datos divdatos_sql = new resultados_base_datos();
                        divc = divdatos_sql.mostrar_resultados(divdatos1, divdatos2, dividir, div_char);
                        resultados_datos.DataSource = divc;
                        break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datos_resiltados_calculadora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         




             DataTable divc;
             resultados_base_datos datos_sql = new resultados_base_datos();
             string id;
             id = id_fila.Text;
             divc = datos_sql.eliminar_fila(id);
             resultados_datos.DataSource = divc;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable selec;
            resultados_base_datos datos_sql = new resultados_base_datos();
            string id1;
            id1 = id_selecionar.Text;
            selec = datos_sql.select_datos(id1);
            selecionar.DataSource = selec;

            /* DataTable select;
             resultados_base_datos selec = new resultados_base_datos();
             string id_selec= "";
             id_selec = id_selecionar.Text;
             select = selec.select_datos(id_selec);
             selecionar.DataSource = selec;*/

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mod;
            string tipo_operar = "";
            string dato1;
            string dato2;
            string resultado;
            mod =id_modicar.Text;
            switch (menu_modificar.SelectedIndex)
            {

 
                case 0:                  
                    dato1 = numero1.Text;
                    tipo_operar = "sumar";
                    dato2 = numero2.Text;
                    resultado = resultado_modificar.Text;
                    DataTable modificardor;
                    resultados_base_datos datos_sql = new resultados_base_datos();
                    modificardor = datos_sql.update(mod,dato1,tipo_operar,dato2,resultado);
                    resultados_datos.DataSource = modificardor;
                    resultados_datos.Update();
                    break;
                case 1:
                    dato1 = numero1.Text;
                    tipo_operar = "restar";
                    dato2 = numero2.Text;
                    resultado = resultado_modificar.Text;
                    DataTable modificardor2;
                    resultados_base_datos datos_sql2 = new resultados_base_datos();
                    modificardor2 = datos_sql2.update(mod, dato1, tipo_operar, dato2, resultado);
                    resultados_datos.DataSource = modificardor2;
                    resultados_datos.Update();
                    break;
                case 2:
                    dato1 = numero1.Text;
                    tipo_operar = "multiplicar";
                    dato2 = numero2.Text;
                    resultado = resultado_modificar.Text;
                    DataTable modificardor3;
                    resultados_base_datos datos_sql3 = new resultados_base_datos();
                    modificardor3 = datos_sql3.update(mod, dato1, tipo_operar, dato2, resultado);
                     resultados_datos.DataSource = modificardor3;
                    resultados_datos.Update();
                    break;
                case 3:
                    dato1 = numero1.Text;
                    tipo_operar = "dividir";
                    dato2 = numero2.Text;
                    resultado = resultado_modificar.Text;
                    DataTable modificardor4;
                    resultados_base_datos datos_sql4 = new resultados_base_datos();
                    modificardor4 = datos_sql4.update(mod, dato1, tipo_operar, dato2, resultado);
                    resultados_datos.DataSource = modificardor4;
                    resultados_datos.Update();
                    break;


            }

         
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ciftra1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_cifra2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

