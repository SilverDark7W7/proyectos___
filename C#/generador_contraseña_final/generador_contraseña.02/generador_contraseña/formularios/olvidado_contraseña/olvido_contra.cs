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

namespace generador_contraseña.formularios.olvidado_contraseña
{
    public partial class olvido_contra : Form
    {
        public olvido_contra()
        {
            InitializeComponent();
        }

        private void link_otro_metodo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb_telefono.Visible = false;
            txt_telefono.Visible = false;
            panel_telefono_olvido.Visible = false;
            lb_nombre.Visible = true;
            lb_apellido.Visible = true;
            txt_nombre.Visible = true;
            txt_apellido.Visible = true;
            panel_nombre_olvido.Visible = true;
            panel_apellido_olvido.Visible = true;
        }


        private void class_new_buttons1_Click(object sender, EventArgs e)
        {

            if (txt_nombre.Visible != true && txt_apellido.Visible != true)
            {
                datos_Sql.coneciones_sql_entrada_salida_datos entrada_Salida_Datos = new datos_Sql.coneciones_sql_entrada_salida_datos();
                DataSet a = entrada_Salida_Datos.olvidado_contrasena_telefono(txt_telefono.Text);
                int verificar = a.Tables[0].Rows.Count;
                if (verificar != 0)
                {
                    MessageBox.Show("Veficiafión Exitosa", "Validar", MessageBoxButtons.OK, MessageBoxIcon.None);
                    lb_telefono.Visible = false;
                    txt_telefono.Visible = false;
                    panel_telefono_olvido.Visible = false;
                    lb_nombre.Visible = false;
                    lb_apellido.Visible = false;
                    txt_nombre.Visible = false;
                    txt_apellido.Visible = false;
                    panel_nombre_olvido.Visible = false;
                    panel_apellido_olvido.Visible = false;
                    lb_verf.Visible = false;
                    link_otro_metodo.Visible = false;
                    lb_new.Visible = true;
                    lb_new_contra.Visible = true;
                    lb_verf_contra.Visible = true;
                    txt_contra.Visible = true;
                    txt_verf.Visible = true;
                    panel_nueva_contra_olvido.Visible = true;
                    panel_verificar_olvido.Visible = true;
                    btn_1.Visible = false;
                    btn_new_contra.Visible = true;
                    picture1_mostrar_olvido.Visible = true;
                    picture1_ocultar_olvido.Visible = true;
                    picture2_mostrar_olvido.Visible = true;
                    picture2_ocultar_olvido.Visible = true;

                }
                else
                {
                    MessageBox.Show("Error Datos incorrectos", "Validar", MessageBoxButtons.OK, MessageBoxIcon.None);

                }


            }
            else if (txt_nombre.Visible != false && txt_apellido.Visible != false)
            {
                datos_Sql.coneciones_sql_entrada_salida_datos entrada_Salida_Datos = new datos_Sql.coneciones_sql_entrada_salida_datos();
                DataSet a = entrada_Salida_Datos.olvidado_contrasena_nombre_apellido(txt_nombre.Text, txt_apellido.Text);
                int verificar = a.Tables[0].Rows.Count;
                if (verificar != 0)
                {
                    MessageBox.Show("Veficiafión Exitosa", "Validar", MessageBoxButtons.OK, MessageBoxIcon.None);
                    lb_telefono.Visible = false;
                    txt_telefono.Visible = false;
                    panel_telefono_olvido.Visible = false;
                    lb_nombre.Visible = false;
                    lb_apellido.Visible = false;
                    txt_nombre.Visible = false;
                    txt_apellido.Visible = false;
                    panel_nombre_olvido.Visible = false;
                    panel_apellido_olvido.Visible = false;
                    lb_verf.Visible = false;
                    lb_new.Visible = true;
                    lb_new_contra.Visible = true;
                    lb_verf_contra.Visible = true;
                    link_otro_metodo.Visible = false;
                    txt_contra.Visible = true;
                    txt_verf.Visible = true;
                    panel_nueva_contra_olvido.Visible = true;
                    panel_verificar_olvido.Visible = true;
                    btn_1.Visible = false;
                    btn_new_contra.Visible = true;
                    picture1_mostrar_olvido.Visible = true;
                    picture1_ocultar_olvido.Visible = true;
                    picture2_mostrar_olvido.Visible = true;
                    picture2_ocultar_olvido.Visible = true;


                }
                else
                {
                    MessageBox.Show("Error Datos incorrectos", "Validar", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
            }
        }
        private void btn_new_contra_Click_1(object sender, EventArgs e)
        {
            if (txt_telefono.Text != "")
            {
                if (txt_contra.Text == txt_verf.Text)
                {
                    datos_Sql.coneciones_sql_entrada_salida_datos coneciones_Sql_Entrada = new datos_Sql.coneciones_sql_entrada_salida_datos();
                    coneciones_Sql_Entrada.nueva_contraseña_telefono(txt_telefono.Text, txt_verf.Text);
                }


            }
            if (txt_nombre.Text != "" || txt_apellido.Text != "")
            {
                if (txt_contra.Text == txt_verf.Text)
                {

                    datos_Sql.coneciones_sql_entrada_salida_datos coneciones_Sql_Entrada = new datos_Sql.coneciones_sql_entrada_salida_datos();
                    coneciones_Sql_Entrada.nueva_contraseña_nombre_apellido(txt_nombre.Text, txt_apellido.Text, txt_verf.Text);

                }
                else
                {
                    Error.SetError(txt_verf, "verificacion incorrecta");
                }
            }
        }

        private void panel_central_olvido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login entrar = new Login();
            this.Hide();
            entrar.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void olvido_contra_Load(object sender, EventArgs e)
        {
            TemaColors.TemaLogin("color_login");
            panel_central_olvido.BackColor = TemaColors.color_form_recibir;
            panel_superior_olvido.BackColor = TemaColors.boton_borde_recibir;
            picture_linea_olvido.BackColor = TemaColors.color_form_recibir;
            txt_telefono.BackColor = TemaColors.color_form_recibir;
            txt_nombre.BackColor = TemaColors.color_form_recibir;
            txt_apellido.BackColor = TemaColors.color_form_recibir;
            txt_contra.BackColor = TemaColors.color_form_recibir;
            txt_verf.BackColor = TemaColors.color_form_recibir;
            panel_nueva_contra_olvido.BackColor = TemaColors.boton_borde_recibir;
            panel_telefono_olvido.BackColor = TemaColors.boton_borde_recibir;
            panel_apellido_olvido.BackColor = TemaColors.boton_borde_recibir;
            panel_nombre_olvido.BackColor = TemaColors.boton_borde_recibir;
            panel_verificar_olvido.BackColor = TemaColors.boton_borde_recibir;
           
        }

        private void picture1_ocultar_olvido_Click(object sender, EventArgs e)
        {
            picture1_mostrar_olvido.BringToFront();
            txt_contra.PasswordChar = '\0';
        }

        private void picture1_mostrar_olvido_Click(object sender, EventArgs e)
        {
            picture1_ocultar_olvido.BringToFront();
            txt_contra.PasswordChar = '⁕';
        }

        private void picture2_ocultar_olvido_Click(object sender, EventArgs e)
        {
            picture2_mostrar_olvido.BringToFront();
            txt_verf.PasswordChar = '\0';
        }

        private void picture2_mostrar_olvido_Click(object sender, EventArgs e)
        {
            picture2_ocultar_olvido.BringToFront();
            txt_verf.PasswordChar = '⁕';
        }
    }
}
