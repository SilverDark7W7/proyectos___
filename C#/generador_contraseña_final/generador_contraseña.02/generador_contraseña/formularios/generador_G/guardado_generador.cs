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
    public partial class guardado_generador : Form
    {
        public guardado_generador()
        {
            InitializeComponent();
        }

        private void guardado_generador_Load(object sender, EventArgs e)
        {

            TemaColors.TemaLogin("color_login");
            panel_central_guardado_generar.BackColor = TemaColors.color_form_recibir;
            picture_linea_generar.BackColor = TemaColors.color_form_recibir;
            panel_superior_guardado_generar.BackColor= TemaColors.boton_borde_recibir;
            lb_cantidad_guardado_generador.BackColor = TemaColors.color_form_recibir;
            lb_contraseña_nueva_guardado_generador.BackColor = TemaColors.color_form_recibir;
            lb_nombre_contrasena_guardado_generador.BackColor = TemaColors.color_form_recibir;
            checkBox_generador_guardado_generador.BackColor = TemaColors.color_form_recibir;
            check_fecha_guardado_generador.BackColor = TemaColors.color_form_recibir;
            num_cifras.BackColor = TemaColors.color_form_recibir;
            txt_nombre_contrasena.BackColor = TemaColors.color_form_recibir;
            txt_contraseña.BackColor = TemaColors.color_form_recibir;
            btn_modificar.BackColor = TemaColors.color_modificar_recibir;
            panel_modificar_guardado_generador.BackColor = TemaColors.color_modificar_recibir;
            panel_cifras_guardado_generador.BackColor = TemaColors.color_celeste_panel_recibir;
            panel_nuevo_nombre_guardado_generador.BackColor = TemaColors.color_celeste_panel_recibir;
            panel_nueva_contra_guardado_generador.BackColor = TemaColors.color_celeste_panel_recibir;
            dtg_imprime_datos_tabla_guardado_generador.BackgroundColor = TemaColors.boton_borde_recibir;

            TemaColors.TemaLogin("color_boton_generar");
            Generar_contraseña_modificada.BackColor = TemaColors.boton_generar_recibir;
            panel_boton_generar.BackColor = TemaColors.boton_generar_recibir;

            TemaColors.TemaLogin("color_boton_guardar");
            btn_guardar_modificacion.BackColor = TemaColors.boton_guardar_recibir;
            panel_boton_guardar_guardado_generador.BackColor = TemaColors.boton_guardar_recibir;

            datos_Sql.coneciones_sql_entrada_salida_datos entrada_Salida_Datos = new datos_Sql.coneciones_sql_entrada_salida_datos();



            dtg_imprime_datos_tabla_guardado_generador.DataSource = entrada_Salida_Datos.cargar_daragrip();
            dtg_imprime_datos_tabla_guardado_generador.Columns["id"].Visible = false;



        }
        public string nombre_contraseña = "";
        generador_pasword min = new generador_pasword();
        verdad VerificarFuerzaContrasena = new verdad();
        datos_Sql.coneciones_sql_entrada_salida_datos entrada_Salida_Datos = new datos_Sql.coneciones_sql_entrada_salida_datos();

       



       

        private void Generar_contraseña_modificada_Click(object sender, EventArgs e)
        {

          
        }

        private void permitir_generador_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void checkBox_generador_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_generador_guardado_generador.Checked == true)
            {
                Generar_contraseña_modificada.Visible = true;
                num_cifras.Visible = true;
                lb_cantidad_guardado_generador.Visible = true;
            }
            else
            {
                Generar_contraseña_modificada.Visible = false;
                num_cifras.Visible = false;
                lb_cantidad_guardado_generador.Visible = false;
            }
        }

        private void Generar_contraseña_modificadaa_Click(object sender, EventArgs e)
        {
            lb_fuerte_debil_guardado_generador.TextAlign = ContentAlignment.MiddleCenter;
            string cantidad_enviar_letras;
            cantidad_enviar_letras = num_cifras.Text;
            min.generador(cantidad_enviar_letras);
            string password_generado;
            try
            {
                int b;
                b = Convert.ToInt32(num_cifras.Text);
                if (b >= 8)
                {
                    password_generado = min.generador(cantidad_enviar_letras);
                    if (password_generado != txt_contraseña.Text)

                    {
                        txt_contraseña.Text = password_generado;
                        lb_fuerte_debil_guardado_generador.Text = VerificarFuerzaContrasena.True_false(password_generado);
                        lb_fuerte_debil_guardado_generador.Visible = true;

                        if (lb_fuerte_debil_guardado_generador.Text == "Fuerte")
                        {
                            progress_guardado_generador.Value = 100;
                          
                        }

                        if (lb_fuerte_debil_guardado_generador.Text == "Media")
                        {
                            progress_guardado_generador.Value = 50;
                           
                        }

                        if (lb_fuerte_debil_guardado_generador.Text == "Debil")
                        {
                            progress_guardado_generador.Value = 25;
                         
                        }
                    }
                    else
                    {
                        password_generado = min.generador(cantidad_enviar_letras);
                        txt_contraseña.Text = password_generado;
                        lb_fuerte_debil_guardado_generador.Text = VerificarFuerzaContrasena.True_false(password_generado);
                        lb_fuerte_debil_guardado_generador.Visible = true;

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

        private void boton_guardar_generar_Click(object sender, EventArgs e)
        {
            if (check_fecha_guardado_generador.Checked == false)
            {
                string datos = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
                string nombre = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[1].Value.ToString();
                string contra = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[2].Value.ToString();

                if (txt_contraseña.Text == contra || txt_nombre_contrasena.Text == nombre)
                {
                    if (MessageBox.Show("Hay datos no cambiados ¿Quiere continuar?", "Verificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string contrasena = "";
                        string id = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
                        nombre = txt_nombre_contrasena.Text;
                        contrasena = txt_contraseña.Text;
                        entrada_Salida_Datos.update(id, nombre, contrasena);
                        dtg_imprime_datos_tabla_guardado_generador.DataSource = entrada_Salida_Datos.cargar_daragrip();
                    }
                }
                if (txt_contraseña.Text != "" || txt_nombre_contrasena.Text != "")
                {
                    string contrasena = "";
                    string id = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
                    nombre = txt_nombre_contrasena.Text;
                    contrasena = txt_contraseña.Text;
                    entrada_Salida_Datos.update(id, nombre, contrasena);
                    dtg_imprime_datos_tabla_guardado_generador.DataSource = entrada_Salida_Datos.cargar_daragrip();
                }
            }
            else
            {
                string datos = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
                string nombre = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[1].Value.ToString();
                string contra = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[2].Value.ToString();

                if (txt_contraseña.Text == contra || txt_nombre_contrasena.Text == nombre)
                {
                    if (MessageBox.Show("Hay datos no cambiados ¿Quiere continuar?", "Verificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string contrasena = "";
                        string id = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
                        nombre = txt_nombre_contrasena.Text;
                        contrasena = txt_contraseña.Text;
                        entrada_Salida_Datos.update_fecha_incluida(id, nombre, contrasena);
                        dtg_imprime_datos_tabla_guardado_generador.DataSource = entrada_Salida_Datos.cargar_daragrip();
                    }
                }
            }
        }

        private void boton_modificar_banco_Click(object sender, EventArgs e)
        {
            string datos = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
            string nombre = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[1].Value.ToString();
            string contra = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[2].Value.ToString();
            txt_contraseña.Text = contra;
            txt_nombre_contrasena.Text = nombre;


            if (datos != "")
            {
                lb_nombre_contrasena_guardado_generador.Visible = true;
                txt_nombre_contrasena.Visible = true;
                panel_nuevo_nombre_guardado_generador.Visible = true;
                checkBox_generador_guardado_generador.Visible = true;
                lb_contraseña_nueva_guardado_generador.Visible = true;
                txt_contraseña.Visible = true;
                panel_nueva_contra_guardado_generador.Visible = true;
                progress_guardado_generador.Visible = true;
                check_fecha_guardado_generador.Visible = true;
                btn_guardar_modificacion.Visible = true;
                panel_boton_guardar_guardado_generador.Visible = true;

            }
            else
            {
                lb_nombre_contrasena_guardado_generador.Visible = false;
                txt_nombre_contrasena.Visible = false;
                panel_nuevo_nombre_guardado_generador.Visible = false;
                checkBox_generador_guardado_generador.Visible = false;
                lb_contraseña_nueva_guardado_generador.Visible = false;
                txt_contraseña.Visible = false;
                panel_nueva_contra_guardado_generador.Visible = false;
                progress_guardado_generador.Visible = false;
                check_fecha_guardado_generador.Visible = false;
                btn_guardar_modificacion.Visible = false;
                panel_boton_guardar_guardado_generador.Visible = false;
            }
        }



        private void checkBox_generador_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_generador_guardado_generador.Checked == true)
            {
                Generar_contraseña_modificada.Visible = true;
                panel_boton_generar.Visible = true;
                num_cifras.Visible = true;
                lb_cantidad_guardado_generador.Visible = true;
                panel_cifras_guardado_generador.Visible = true;
            }
            else
            {
                Generar_contraseña_modificada.Visible = false;
                panel_boton_generar.Visible = false;
                num_cifras.Visible = false;
                lb_cantidad_guardado_generador.Visible = false;
                panel_cifras_guardado_generador.Visible = false;
            }
        }

        private void dtg_imprime_datos_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string datos = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
            string nombre = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[1].Value.ToString();
            string contra = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[2].Value.ToString();
            txt_contraseña.Text = contra;
            txt_nombre_contrasena.Text = nombre;


            if (datos != "")
            {
                lb_nombre_contrasena_guardado_generador.Visible = true;
                txt_nombre_contrasena.Visible = true;
                panel_nuevo_nombre_guardado_generador.Visible = true;
                checkBox_generador_guardado_generador.Visible = true;
                lb_contraseña_nueva_guardado_generador.Visible = true;
                txt_contraseña.Visible = true;
                panel_nueva_contra_guardado_generador.Visible = true;
                progress_guardado_generador.Visible = true;
                check_fecha_guardado_generador.Visible = true;
                btn_guardar_modificacion.Visible = true;
                panel_boton_guardar_guardado_generador.Visible = true;
            }
            else
            {
                lb_nombre_contrasena_guardado_generador.Visible = false;
                txt_nombre_contrasena.Visible = false;
                panel_nuevo_nombre_guardado_generador.Visible = false;
                checkBox_generador_guardado_generador.Visible = false;
                lb_contraseña_nueva_guardado_generador.Visible = false;
                txt_contraseña.Visible = false;
                panel_nueva_contra_guardado_generador.Visible = false;
                progress_guardado_generador.Visible = false;
                check_fecha_guardado_generador.Visible = false;
                btn_guardar_modificacion.Visible = false;
                panel_boton_guardar_guardado_generador.Visible = false;

            }
        }

        private void dtg_imprime_datos_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string datos = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
            string nombre = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[1].Value.ToString();
            string contra = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[2].Value.ToString();
            txt_contraseña.Text = contra;
            txt_nombre_contrasena.Text = nombre;
            if (datos != "")
            {
                lb_nombre_contrasena_guardado_generador.Visible = true;
                txt_nombre_contrasena.Visible = true;
                panel_nuevo_nombre_guardado_generador.Visible = true;
                checkBox_generador_guardado_generador.Visible = true;
                lb_contraseña_nueva_guardado_generador.Visible = true;
                txt_contraseña.Visible = true;
                panel_nueva_contra_guardado_generador.Visible = true;
                progress_guardado_generador.Visible = true;
                check_fecha_guardado_generador.Visible = true;
                btn_guardar_modificacion.Visible = true;
                panel_boton_guardar_guardado_generador.Visible = true;
            }
            else
            {
                lb_nombre_contrasena_guardado_generador.Visible = false;
                txt_nombre_contrasena.Visible = false;
                panel_nuevo_nombre_guardado_generador.Visible = false;
                checkBox_generador_guardado_generador.Visible = false;
                lb_contraseña_nueva_guardado_generador.Visible = false;
                txt_contraseña.Visible = false;
                panel_nueva_contra_guardado_generador.Visible = false;
                progress_guardado_generador.Visible = false;
                check_fecha_guardado_generador.Visible = false;
                btn_guardar_modificacion.Visible = false;
                panel_boton_guardar_guardado_generador.Visible = false;
            }
        }

        private void dtg_imprime_datos_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string datos = Convert.ToString(dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[0].Value);
            string nombre = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[1].Value.ToString();
            string contra = dtg_imprime_datos_tabla_guardado_generador.CurrentRow.Cells[2].Value.ToString();
            txt_contraseña.Text = contra;
            txt_nombre_contrasena.Text = nombre;
            if (datos != "")
            {
                lb_nombre_contrasena_guardado_generador.Visible = true;
                txt_nombre_contrasena.Visible = true;
                panel_nuevo_nombre_guardado_generador.Visible = true;
                checkBox_generador_guardado_generador.Visible = true;
                lb_contraseña_nueva_guardado_generador.Visible = true;
                txt_contraseña.Visible = true;
                panel_nueva_contra_guardado_generador.Visible = true;
                progress_guardado_generador.Visible = true;
                check_fecha_guardado_generador.Visible = true;
                btn_guardar_modificacion.Visible = true;
                panel_boton_guardar_guardado_generador.Visible = true;
            }
            else
            {
                lb_nombre_contrasena_guardado_generador.Visible = false;
                txt_nombre_contrasena.Visible = false;
                panel_nuevo_nombre_guardado_generador.Visible = false;
                checkBox_generador_guardado_generador.Visible = false;
                lb_contraseña_nueva_guardado_generador.Visible = false;
                txt_contraseña.Visible = false;
                panel_nueva_contra_guardado_generador.Visible = false;
                progress_guardado_generador.Visible = false;
                check_fecha_guardado_generador.Visible = false;
                btn_guardar_modificacion.Visible = false;
                panel_boton_guardar_guardado_generador.Visible = false;
            }
        }

        private void picture_regresar_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void picture_regresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            usuario1 f1 = new usuario1();
            f1.Show();
        }

        private void picture_salida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
