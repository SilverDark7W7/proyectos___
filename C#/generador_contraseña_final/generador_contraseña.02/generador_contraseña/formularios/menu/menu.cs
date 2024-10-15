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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }


        private void menu_Load(object sender, EventArgs e)
        {
            TemaColors.TemaLogin("color_login");
            pb2.BackColor = TemaColors.color_form_recibir;
            picture_linea_menu.BackColor = TemaColors.color_form_recibir;
            class_new_buttons1.BackColor = TemaColors.color_form_recibir;
            class_new_buttons2.BackColor = TemaColors.color_form_recibir;
            class_new_buttons3.BackColor = TemaColors.color_form_recibir;
            class_new_buttons4.BackColor = TemaColors.color_form_recibir;
            class_new_buttons1.BorderColor = TemaColors.boton_borde_recibir;
            class_new_buttons2.BorderColor = TemaColors.boton_borde_recibir;
            class_new_buttons3.BorderColor = TemaColors.boton_borde_recibir;
            class_new_buttons4.BorderColor = TemaColors.boton_borde_recibir;
            class_new_buttons1.ForeColor = TemaColors.boton_borde_recibir;
            class_new_buttons2.ForeColor = TemaColors.boton_borde_recibir;
            class_new_buttons3.ForeColor = TemaColors.boton_borde_recibir;
            class_new_buttons4.ForeColor = TemaColors.boton_borde_recibir;
            panel_superior_menu.BackColor = TemaColors.boton_borde_recibir;
        }

        private void class_new_buttons1_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuario1 inciar_program = new usuario1();
            inciar_program.Show();
        }

        private void class_new_buttons2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guardar_contraseña guardar = new Guardar_contraseña();
            guardar.Show();
        }

        private void class_new_buttons3_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularios.busqueda.busqueda_contraseñas a = new formularios.busqueda.busqueda_contraseñas();
            a.Show();
        }

        private void class_new_buttons4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cambiar_datos_usuario inciar_program = new Cambiar_datos_usuario();
            inciar_program.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void picture_regresar_Click(object sender, EventArgs e)
        {

        }

        private void pb2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
