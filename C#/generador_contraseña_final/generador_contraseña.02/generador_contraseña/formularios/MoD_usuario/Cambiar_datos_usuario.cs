using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generador_contraseña
{
    public partial class Cambiar_datos_usuario : Form
    {
        public Cambiar_datos_usuario()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Cambiar_datos_usuario_Load(object sender, EventArgs e)
        {
            TemaColors.TemaLogin("color_login");
            panel_central_cambiard.BackColor = TemaColors.color_form_recibir;
            panel_superior_cambiard.BackColor = TemaColors.boton_borde_recibir;
            picture_linea_cambiod.BackColor = TemaColors.color_form_recibir;
            lb_antiguo_user.BackColor = TemaColors.color_form_recibir;
            lb_antigua_contra.BackColor = TemaColors.color_form_recibir;
            lb_nuevo_user.BackColor = TemaColors.color_form_recibir;
            lb_nueva_contra.BackColor = TemaColors.color_form_recibir;
            txt_antiguo_nombre.BackColor = TemaColors.color_form_recibir;
            txt_antigua_contraseña.BackColor = TemaColors.color_form_recibir;
            txt_usuario.BackColor = TemaColors.color_form_recibir;
            txt_contra_usuario.BackColor = TemaColors.color_form_recibir;
            btn_generador.BackColor = TemaColors.color_form_recibir;

            TemaColors.TemaLogin("color_cambio_datos");
            panel_inferior_1.BackColor = TemaColors.color_borde_botones_cambio_recibir;
            panel_inferior_2.BackColor = TemaColors.color_borde_botones_cambio_recibir;
            panel_inferior_3.BackColor = TemaColors.color_borde_botones_cambio_recibir;
            panel_inferior_4.BackColor = TemaColors.color_borde_botones_cambio_recibir;
            btn_generador.BorderColor = TemaColors.color_borde_botones_cambio_recibir;
            btn_generador.ForeColor = TemaColors.color_borde_botones_cambio_recibir;

        }

        private void btn_generadorr_Click(object sender, EventArgs e)
        {

            if (txt_antigua_contraseña.Text != "" || txt_antiguo_nombre.Text != "" || txt_contra_usuario.Text != "" || txt_usuario.Text != "")
            {
                DialogResult result = MessageBox.Show("Esta seguro que quiere cambiar los datos del usuario", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        datos_Sql.coneciones_sql_entrada_salida_datos coneciones_Sql_Entrada = new datos_Sql.coneciones_sql_entrada_salida_datos();
                        coneciones_Sql_Entrada.cambio_datos_usuario_update(txt_usuario.Text, txt_contra_usuario.Text, txt_antiguo_nombre.Text);
                        error.SetError(txt_usuario, " Datos Modificados");
                        error.SetError(txt_contra_usuario, " Datos Modificados ");
                        error.SetError(txt_antiguo_nombre, " Datos Modificados");
                        error.SetError(txt_antigua_contraseña, " Datos Modificados ");
                        MessageBox.Show("Su cambio de datos a sido Exitoso", "Validación", MessageBoxButtons.OK, MessageBoxIcon.None);
                        break;
                    case DialogResult.No:
                        error.SetError(txt_usuario, " No se realizo la modificacion");
                        error.SetError(txt_contra_usuario, " No se realizo la modificacion ");
                        error.SetError(txt_antiguo_nombre, " No se realizo la modificacion");
                        error.SetError(txt_antigua_contraseña, " No se realizo la modificacion ");
                        break;
                }
            }
            else
            {
                error.SetError(txt_usuario, "Datos incompletos");
                error.SetError(txt_contra_usuario, "Datos incompletos");
                error.SetError(txt_antiguo_nombre, "Datos incompletos");
                error.SetError(txt_antigua_contraseña, "Datos incompletos");

            }



        }

        private void control_txt1__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_central_cambiard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picture1_ocultar_cambio_Click(object sender, EventArgs e)
        {
            picture1_mostrar_cambio.BringToFront();
            txt_antigua_contraseña.PasswordChar = '\0';
        }

        private void picture1_mostrar_cambio_Click(object sender, EventArgs e)
        {
            picture1_ocultar_cambio.BringToFront();
            txt_antigua_contraseña.PasswordChar = '⁕';
        }

        private void picture2_ocultar_cambio_Click(object sender, EventArgs e)
        {
            picture2_mostrar_cambio.BringToFront();
            txt_contra_usuario.PasswordChar = '\0';
        }

        private void picture2_mostrar_cambio_Click(object sender, EventArgs e)
        {
            picture2_ocultar_cambio.BringToFront();
            txt_contra_usuario.PasswordChar = '⁕';
        }
    }
}
