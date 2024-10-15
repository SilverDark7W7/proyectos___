using System;
using Pasword;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region
        private void txt_Enter(object sender, EventArgs e)
        {
            //textbox que tiene el evento enter al estar activo
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in panel_central.Controls)
            {
                //si es un panel y su nombre inicia con p, concatenando el nombre del textbox
                //entonces cambiara de color

                if (ctrl is Panel && ctrl.Name == "p" + txt.Name)
                {
                    TemaColors.TemaLogin("color1_textbox");
                    ctrl.BackColor = TemaColors.color1_txt_recibir;

                }
            }

        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in panel_central.Controls)
            {
                if (ctrl is Panel && ctrl.Name == "p" + txt.Name)
                {
                    TemaColors.TemaLogin("color2_textbox");
                    ctrl.BackColor = TemaColors.color2_txt_recibir;

                }
            }
        }

#endregion
        //cadena de conexion 
        datos_Sql.coneciones_sql_entrada_salida_datos coneciones_Sql_Entrada = new datos_Sql.coneciones_sql_entrada_salida_datos();

        string conectar = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True";
        private void Login_Load(object sender, EventArgs e)
        {
            TemaColors.TemaLogin("color_login");
            pb1.BackColor = TemaColors.color_form_recibir;
            lb_usuario.BackColor = TemaColors.color_form_recibir;
            lb_contraseña.BackColor = TemaColors.color_form_recibir;
            linkLabel_olvido.BackColor = TemaColors.color_form_recibir;
            label_registro.BackColor = TemaColors.color_form_recibir;
            label_user_contra_error.BackColor = TemaColors.color_form_recibir;
            picturebox_perfil.BackColor = TemaColors.color_form_recibir;
            picturebox_linea.BackColor = TemaColors.color_form_recibir;
            picturebox_mostrar.BackColor = TemaColors.color_form_recibir;
            picturebox_ocultar.BackColor = TemaColors.color_form_recibir;
            txt_usuario.BackColor = TemaColors.color_form_recibir;
            txt_contrasena.BackColor = TemaColors.color_form_recibir;
            panel_central.BackColor = TemaColors.color_form_recibir;
            btn_entrar.BackColor = TemaColors.boton_recibir;
            btn_cerrar_login.BackColor = TemaColors.boton_recibir;

            TemaColors.TemaLogin("color2_textbox");
            ptxt_usuario.BackColor = TemaColors.color2_txt_recibir;
            ptxt_contrasena.BackColor = TemaColors.color2_txt_recibir;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_contrasena.Text == "")
            {
                MessageBox.Show(" FALTAN DATOS", "ERROR DE SESÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                //crear la conexion, no crear la cadena de conexion
                SqlConnection envia_datos = new SqlConnection(conectar);
                SqlCommand cdm = new SqlCommand("select * from Usuario where (Usuario=@Usuario1 AND Contrasena=@Contrasena1) OR (Usuario=@Usuario2 AND Contrasena=@Contrasena2)", envia_datos);
                cdm.Parameters.AddWithValue("@Usuario1", txt_usuario.Text);
                cdm.Parameters.AddWithValue("@Contrasena1", txt_contrasena.Text);
                cdm.Parameters.AddWithValue("@Usuario2","usuario2");
                cdm.Parameters.AddWithValue("@Contrasena2","contrasena2");
                envia_datos.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cdm);
                DataSet Cargar = new DataSet();
                adapt.Fill(Cargar);
                envia_datos.Close();
                int contar_usuario1 = Cargar.Tables[0].Rows.Count;
                int contar_usuario2 = Cargar.Tables[0].Rows.Count;
                if (contar_usuario1 == 1)
                {
                    string a;
                    a = txt_usuario.Text;
                    label_user_contra_error.Visible = false;
                    MessageBox.Show("Hola " + a, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Hide();
                    menu iniciar_programa = new menu();
                    iniciar_programa.Show();


                }

               else if (contar_usuario2 == 2   )
                {
                    string a;
                    a = txt_usuario.Text;
                    MessageBox.Show("Hola " + a, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    menu iniciar_programa2 = new menu();
                    iniciar_programa2.Show();
                }
                else
                {
                    label_user_contra_error.Visible = true;
                        

                    MessageBox.Show("Nose pudo ingresar");

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }






        }

        private void btn_entrar_Enter(object sender, EventArgs e)
        {
        }

        private void btn_cerrar_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
   
        private void linkLabel_olvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            formularios.olvidado_contraseña.olvido_contra a = new formularios.olvidado_contraseña.olvido_contra();
            a.Show();
        }

        private void label_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            registro_ususario registro = new registro_ususario();
            registro.Show();
        }

        private void picturebox_ocultar_Click(object sender, EventArgs e)
        {
            picturebox_mostrar.BringToFront();
            txt_contrasena.PasswordChar = '\0';
        }

        private void picturebox_mostrar_Click(object sender, EventArgs e)
        {
            picturebox_ocultar.BringToFront();
            txt_contrasena.PasswordChar = '⁕';
        }

        private void pb1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void control_txt1__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void control_txt1__TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}

