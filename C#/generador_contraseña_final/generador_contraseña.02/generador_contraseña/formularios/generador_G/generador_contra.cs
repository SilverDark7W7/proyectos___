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
    public partial class usuario1 : Form
    {        
       generador_pasword min = new generador_pasword();
        verdad VerificarFuerzaContrasena = new verdad();
        public string nombre_contraseña= "";
        datos_Sql.coneciones_sql_entrada_salida_datos entrada_Salida_Datos = new datos_Sql.coneciones_sql_entrada_salida_datos();
        public usuario1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True ");
            TemaColors.TemaLogin("color_login");
            panel_central_generar_c.BackColor = TemaColors.color_form_recibir;
            panel_superior_generar.BackColor = TemaColors.boton_borde_recibir;
            picture_linea_generar.BackColor = TemaColors.color_form_recibir;
            label_cantidad_cifras.BackColor = TemaColors.color_form_recibir;
            label_nombre_contra.BackColor = TemaColors.color_form_recibir;
            lb_imprime_f_d_m.BackColor = TemaColors.color_form_recibir;
            label_nombre_contra.BackColor = TemaColors.color_form_recibir; ;
            check_fecha.BackColor = TemaColors.color_form_recibir;
            control_txt1.BackColor = TemaColors.color_form_recibir;
            num_cifras.BackColor = TemaColors.color_form_recibir; 
            Nombre_contrasena.BackColor = TemaColors.color_form_recibir;

            TemaColors.TemaLogin("textbox_borde");
            panel_contra_generada.BackColor = TemaColors.txt_borde_recibir;
            panel_longitud_contra.BackColor = TemaColors.txt_borde_recibir;
            panel_nombre_contra.BackColor = TemaColors.txt_borde_recibir;


            TemaColors.TemaLogin("color_boton_generar");
            boton_generar_contra_generar.BackColor = TemaColors.boton_generar_recibir;
            boton_guardar_generar.BackColor = TemaColors.boton_generar_recibir;
            
            panel_boton_generar.BackColor = TemaColors.boton_generar_recibir;

            TemaColors.TemaLogin("color_boton_guardar");
            boton_guardar_generar.BackColor = TemaColors.boton_guardar_recibir;
            panel_boton_guardar_banco.BackColor = TemaColors.boton_guardar_recibir;


        }
        private void boton_generar_contra_generar_Click(object sender, EventArgs e)
        {
           

            if (num_cifras.Text == "")
            {
                
                    MessageBox.Show("NO HAY CONTRASEÑA GENERADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                
            }

            if (Nombre_contrasena.Text == "")
            {
                
                    MessageBox.Show("NO HAY CONTRASEÑA GENERADA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                
            }
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
                    if (password_generado != control_txt1.Text)// si la cadena password_generado(retorno de la clase) es diferente                                                              // al textbox se llama al metodo 
                    {
                        control_txt1.Text = password_generado;
                        //IPR_generar.Text = min.generador(logitud_letras_texbox);
                        //  si queire usar lo de arriba, seria pero solo dando un clik al boton por que simpre 
                        //imprime lo mismmo 
                        lb_imprime_f_d_m.Text = VerificarFuerzaContrasena.True_false(password_generado);
                        lb_imprime_f_d_m.Visible = true;

                        if (lb_imprime_f_d_m.Text == "Fuerte")
                        {
                            progressbar_contra.Value = 100;

                        }

                        if (lb_imprime_f_d_m.Text == "Media")
                        {
                            progressbar_contra.Value = 50;
                          
                        }

                        if (lb_imprime_f_d_m.Text == "Debil")
                        {
                            progressbar_contra.Value = 25;
                           
                        }

                    }
                    else
                    // Si el valor generado es igual al anteriormente guardado, se vuelve a llamar al método
                    {// si es igua llama otra vez para hacer un reinicio de llamado de la clase y hacer nuevamente la accion
                        password_generado = min.generador(cantidad_enviar_letras);
                        // generador() para generar otra cadena diferente
                        control_txt1.Text = password_generado;
                        lb_imprime_f_d_m.Text = VerificarFuerzaContrasena.True_false(password_generado);
                        lb_imprime_f_d_m.Visible = true;

                       

                    }
                    check_fecha.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cantidad menor de 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check_fecha.Visible = false;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("En los llamados");
            }
        }

        private void boton_guardar_generar_Click(object sender, EventArgs e)
        {

            if (check_fecha.Checked == false)
            {
                if (Nombre_contrasena.Text != "")
                {

                    entrada_Salida_Datos.recibir_datos(control_txt1.Text, Nombre_contrasena.Text);
                    this.Hide();

                    guardado_generador guardar = new guardado_generador();

                    guardar.Show();
                    lb_error_guardado.Visible = false;
                    Nombre_contrasena.Text = "";

                }
                else
                {
                    lb_error_guardado.Text = "INGRESE EL NOMBRE ";
                    lb_error_guardado.Visible = true;
                }
            }
            else
            {
                if (Nombre_contrasena.Text != "")
                {

                    entrada_Salida_Datos.recibir_datos_fecha_incluida(control_txt1.Text, Nombre_contrasena.Text);
                    this.Hide();

                    guardado_generador guardar = new guardado_generador();

                    guardar.Show();
                    lb_error_guardado.Visible = false;
                    Nombre_contrasena.Text = "";

                }
                else
                {
                    lb_error_guardado.Text = "INGRESE EL NOMBRE ";
                    lb_error_guardado.Visible = true;
                }
            }

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void control_txt1__TextChanged(object sender, EventArgs e)
        {
            

        }

        private void panel_superior_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_imprime_f_d_m_Click(object sender, EventArgs e)
        {

        }

        private void picture_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void IPR_generar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void control_txt1__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel_central_generar_c_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}




/* int a;
           a = Convert.ToInt32(num_cifras.Text);
           if (a>=8)
           {
               string pasword= "";
               Random rnd = new Random();
               for ( int i=0;i>a;i++)
               {
                   char letraAleatoria = (char)rnd.Next('a', 'z' + 1);
                   pasword += letraAleatoria.ToString();
               }
               IPR_generar.Text = pasword;
/////
///         Random letrasMinusculas = new Random();
                    string password = "";
                    for (int i = 0; i < a; i++)
                    {
                        char letraAleatoria = (char)letrasMinusculas.Next('1', 'z' + 1);
                        password += letraAleatoria.ToString();
                    }
                    IPR_generar.Text = password;
           }*/