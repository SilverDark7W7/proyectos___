using Pasword;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace generador_contraseña
{
    public partial class Guardar_contraseña : Form
    {
        
        public Guardar_contraseña()
        {
            InitializeComponent();
        }
        public string nombre_contraseña = "";
        generador_pasword min = new generador_pasword();
        verdad VerificarFuerzaContrasena = new verdad();
        datos_Sql.coneciones_sql_entrada_salida_datos entrada_Salida_Datos = new datos_Sql.coneciones_sql_entrada_salida_datos();

        private void Guardar_contraseña_Load(object sender, EventArgs e)
        {
            TemaColors.TemaLogin("color_login");
            panel_central_banco.BackColor = TemaColors.color_form_recibir;
            picture_linea_banco.BackColor = TemaColors.color_form_recibir;
            lb_cantidad_banco.BackColor = TemaColors.color_form_recibir;
            lb_nombre_contrasena_banco.BackColor = TemaColors.color_form_recibir;
            lb_nueva_contraseña_banco.BackColor = TemaColors.color_form_recibir;
            checkBox_generador_banco.BackColor = TemaColors.color_form_recibir;
            check_fecha_banco.BackColor = TemaColors.color_form_recibir;
            panel_superior_banco.BackColor = TemaColors.boton_borde_recibir;
            boton_modificar_banco.BackColor = TemaColors.color_modificar_recibir;
            panel_modificar_banco.BackColor = TemaColors.color_modificar_recibir;
            lb_fuerte_debil.BackColor = TemaColors.color_form_recibir; 
            num_cifras_form_guardado.BackColor = TemaColors.color_form_recibir;
            txt_contraseña_form_guardado.BackColor = TemaColors.color_form_recibir; 
            txt_nombre_contrasena_form_guardado.BackColor = TemaColors.color_form_recibir;
            dtg_imprime_datos_tabla.BackgroundColor = TemaColors.boton_borde_recibir;

            TemaColors.TemaLogin("color_boton_generar");
            Generar_contraseña_modificada.BackColor = TemaColors.boton_generar_recibir;
            panel_boton_generar_banco.BackColor = TemaColors.boton_generar_recibir;

           

            TemaColors.TemaLogin("color_boton_guardar");
            boton_guardar_banco.BackColor = TemaColors.boton_guardar_recibir;
            panel_boton_guardar_banco.BackColor = TemaColors.boton_guardar_recibir;

            TemaColors.TemaLogin("textbox_borde");
            panel_cifras_banco.BackColor = TemaColors.txt_borde_recibir;
            panel_nombre_contra_banco.BackColor = TemaColors.txt_borde_recibir;
            panel_nueva_contra_banco.BackColor = TemaColors.txt_borde_recibir;


            datos_Sql.coneciones_sql_entrada_salida_datos entrada_Salida_Datos = new datos_Sql.coneciones_sql_entrada_salida_datos();
        dtg_imprime_datos_tabla.DataSource = entrada_Salida_Datos.cargar_daragrip();
            dtg_imprime_datos_tabla.Columns["id"].Visible = false;

            
        }

        private void regrear_menu_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_modificar_banco_Click(object sender, EventArgs e)
        {
            string datos = Convert.ToString(dtg_imprime_datos_tabla.CurrentRow.Cells[0].Value);
            string nombre = dtg_imprime_datos_tabla.CurrentRow.Cells[1].Value.ToString();
            string contra = dtg_imprime_datos_tabla.CurrentRow.Cells[2].Value.ToString();
            txt_contraseña_form_guardado.Text = contra;
            txt_nombre_contrasena_form_guardado.Text = nombre;

            if (datos == null)
            {
                MessageBox.Show("No ha seleccionado una contraseña a modificar");
                return;

            }

            if (datos != "")
            {

                lb_nombre_contrasena_banco.Visible = true;
                txt_nombre_contrasena_form_guardado.Visible = true;
                checkBox_generador_banco.Visible = true;
                lb_nombre_contrasena_banco.Visible = true;
                lb_nueva_contraseña_banco.Visible = true;
                txt_contraseña_form_guardado.Visible = true;
                progressbar_banco.Visible = true;
                boton_guardar_banco.Visible = true;
                panel_boton_guardar_banco.Visible = true;
                panel_nombre_contra_banco.Visible = true;
                panel_nueva_contra_banco.Visible = true;

            }
            else
            {
                lb_nombre_contrasena_banco.Visible = false;
                txt_nombre_contrasena_form_guardado.Visible = false;
                checkBox_generador_banco.Visible = false;
                lb_nombre_contrasena_banco.Visible = false;
                lb_nueva_contraseña_banco.Visible = false;
                txt_contraseña_form_guardado.Visible = false;
                progressbar_banco.Visible = false;
                boton_guardar_banco.Visible = false;
                panel_boton_guardar_banco.Visible = false;
                panel_nombre_contra_banco.Visible = false;
                panel_nueva_contra_banco.Visible = false;
            }
        }



        private void Generar_contraseña_modificada_Click_1(object sender, EventArgs e)
        {
            lb_fuerte_debil.TextAlign = ContentAlignment.MiddleCenter;
            string cantidad_enviar_letras;
            cantidad_enviar_letras = num_cifras_form_guardado.Text;
            min.generador(cantidad_enviar_letras);
            string password_generado;
            try
            {
                int b;
                b = Convert.ToInt32(num_cifras_form_guardado.Text);
                if (b >= 8)
                {
                    password_generado = min.generador(cantidad_enviar_letras);
                    if (password_generado != txt_contraseña_form_guardado.Text)

                    {
                        txt_contraseña_form_guardado.Text = password_generado;
                        lb_fuerte_debil.Text = VerificarFuerzaContrasena.True_false(password_generado);
                        lb_fuerte_debil.Visible = true;

                        if(lb_fuerte_debil.Text == "Fuerte")
                        {
                            progressbar_banco.Value = 100;
                        }

                        if (lb_fuerte_debil.Text == "Media")
                        {
                            progressbar_banco.Value = 50;
                        }

                        if (lb_fuerte_debil.Text == "Debil")
                        {
                            progressbar_banco.Value = 25;
                        }
                    }
                    else
                    {
                        password_generado = min.generador(cantidad_enviar_letras);
                        txt_contraseña_form_guardado.Text = password_generado;
                        lb_fuerte_debil.Text = VerificarFuerzaContrasena.True_false(password_generado);
                        lb_fuerte_debil.Visible = true;

                    }
                }
                else
                {


                    MessageBox.Show("Cantidad menor de 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("En los llamados");
            }
        }

        private void boton_guardar_banco_Click(object sender, EventArgs e)
        {
            if (check_fecha_banco.Checked == false)
            {
                string datos = Convert.ToString(dtg_imprime_datos_tabla.CurrentRow.Cells[0].Value);
                string nombre = dtg_imprime_datos_tabla.CurrentRow.Cells[1].Value.ToString();
                string contra = dtg_imprime_datos_tabla.CurrentRow.Cells[2].Value.ToString();

                if (txt_contraseña_form_guardado.Text == contra || txt_nombre_contrasena_form_guardado.Text == nombre)
                {
                    if (MessageBox.Show("Hay datos no cambiados ¿Quiere continuar?", "Verificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string contrasena = "";
                        string id = Convert.ToString(dtg_imprime_datos_tabla.CurrentRow.Cells[0].Value);
                        nombre = txt_nombre_contrasena_form_guardado.Text;
                        contrasena = txt_contraseña_form_guardado.Text;
                        entrada_Salida_Datos.update(id, nombre, contrasena);
                        dtg_imprime_datos_tabla.DataSource = entrada_Salida_Datos.cargar_daragrip();
                    }
                }
                if (txt_contraseña_form_guardado.Text != "" || txt_nombre_contrasena_form_guardado.Text != "")
                {
                    string contrasena = "";
                    string id = Convert.ToString(dtg_imprime_datos_tabla.CurrentRow.Cells[0].Value);
                    nombre = txt_nombre_contrasena_form_guardado.Text;
                    contrasena = txt_contraseña_form_guardado.Text;
                    entrada_Salida_Datos.update(id, nombre, contrasena);
                    dtg_imprime_datos_tabla.DataSource = entrada_Salida_Datos.cargar_daragrip();
                }
            }
            else
            {
                string datos = Convert.ToString(dtg_imprime_datos_tabla.CurrentRow.Cells[0].Value);
                string nombre = dtg_imprime_datos_tabla.CurrentRow.Cells[1].Value.ToString();
                string contra = dtg_imprime_datos_tabla.CurrentRow.Cells[2].Value.ToString();

                if (txt_contraseña_form_guardado.Text == contra || txt_nombre_contrasena_form_guardado.Text == nombre)
                {
                    if (MessageBox.Show("Hay datos no cambiados ¿Quiere continuar?", "Verificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string contrasena = "";
                        string id = Convert.ToString(dtg_imprime_datos_tabla.CurrentRow.Cells[0].Value);
                        nombre = txt_nombre_contrasena_form_guardado.Text;
                        contrasena = txt_contraseña_form_guardado.Text;
                        entrada_Salida_Datos.update_fecha_incluida(id, nombre, contrasena);
                        dtg_imprime_datos_tabla.DataSource = entrada_Salida_Datos.cargar_daragrip();
                    }
                }
            }
        }

        private void checkBox_generador_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_generador_banco.Checked == true)
            {
                Generar_contraseña_modificada.Visible = true;
                panel_boton_generar_banco.Visible = true;
                num_cifras_form_guardado.Visible = true;
                lb_cantidad_banco.Visible = true;
                panel_cifras_banco.Visible = true;
                check_fecha_banco.Visible = true;
            }
            else
            {
                Generar_contraseña_modificada.Visible = false;
                panel_boton_generar_banco.Visible = false;
                num_cifras_form_guardado.Visible = false;
                lb_cantidad_banco.Visible = false;
                panel_cifras_banco.Visible = false;
                check_fecha_banco.Visible = false;
            }
        }
      

        private void dtg_imprime_datos_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtg_imprime_datos_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string datos = Convert.ToString(dtg_imprime_datos_tabla.CurrentRow.Cells[0].Value);
            string nombre = dtg_imprime_datos_tabla.CurrentRow.Cells[1].Value.ToString();
            string contra = dtg_imprime_datos_tabla.CurrentRow.Cells[2].Value.ToString();
            txt_contraseña_form_guardado.Text = contra;
            txt_nombre_contrasena_form_guardado.Text = nombre;
            if (datos != "")
            {
                lb_nombre_contrasena_banco.Visible = true;
                txt_nombre_contrasena_form_guardado.Visible = true;
                checkBox_generador_banco.Visible = true;
                lb_nombre_contrasena_banco.Visible = true;
                lb_nueva_contraseña_banco.Visible = true;
                txt_contraseña_form_guardado.Visible = true;
                progressbar_banco.Visible = true;
                boton_guardar_banco.Visible = true;
                panel_boton_guardar_banco.Visible = true;
                panel_nombre_contra_banco.Visible = true;
                panel_nueva_contra_banco.Visible = true;
            }
            else
            {
                lb_nombre_contrasena_banco.Visible = false;
                txt_nombre_contrasena_form_guardado.Visible = false;
                checkBox_generador_banco.Visible = false;
                lb_nombre_contrasena_banco.Visible = false;
                lb_nueva_contraseña_banco.Visible = false;
                txt_contraseña_form_guardado.Visible = false;
                progressbar_banco.Visible = false;
                boton_guardar_banco.Visible = false;
                panel_boton_guardar_banco.Visible = false;
                panel_nombre_contra_banco.Visible = false;
                panel_nueva_contra_banco.Visible = false;
            }
        }

        private void dtg_imprime_datos_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string datos = Convert.ToString(dtg_imprime_datos_tabla.CurrentRow.Cells[0].Value);
            string nombre = dtg_imprime_datos_tabla.CurrentRow.Cells[1].Value.ToString();
            string contra = dtg_imprime_datos_tabla.CurrentRow.Cells[2].Value.ToString();
            txt_contraseña_form_guardado.Text = contra;
            txt_nombre_contrasena_form_guardado.Text = nombre;

           
            if (datos != "")
            {
                lb_nombre_contrasena_banco.Visible = true;
                txt_nombre_contrasena_form_guardado.Visible = true;
                checkBox_generador_banco.Visible = true;
                lb_nombre_contrasena_banco.Visible = true;
                lb_nueva_contraseña_banco.Visible = true;
                txt_contraseña_form_guardado.Visible = true;
                progressbar_banco.Visible = true;
                boton_guardar_banco.Visible = true;
                panel_boton_guardar_banco.Visible = true;
                panel_nombre_contra_banco.Visible = true;
                panel_nueva_contra_banco.Visible = true;

            }
            else
            {
                lb_nombre_contrasena_banco.Visible = false;
                txt_nombre_contrasena_form_guardado.Visible = false;
                checkBox_generador_banco.Visible = false;
                lb_nombre_contrasena_banco.Visible = false;
                lb_nueva_contraseña_banco.Visible = false;
                txt_contraseña_form_guardado.Visible = false;
                progressbar_banco.Visible = false;
                boton_guardar_banco.Visible = false;
                panel_boton_guardar_banco.Visible = false;
                panel_nombre_contra_banco.Visible = false;
                panel_nueva_contra_banco.Visible = false;
            }
        }

        private void panel_central_banco_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picture_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_menu_Click(object sender, EventArgs e)
        {

        }
    }
}
