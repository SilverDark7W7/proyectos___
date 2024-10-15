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
    public partial class registro_ususario : Form
    {
        public registro_ususario()
        {
            InitializeComponent();
        }
        datos_Sql.coneciones_sql_entrada_salida_datos coneciones_Sql_Entrada = new datos_Sql.coneciones_sql_entrada_salida_datos();    

        private void btn_register_Click(object sender, EventArgs e)
        {
          
        }


        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_nombre_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Text = "Nombre";
            }
        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "Nombre Usuario";
            }
        }

        private void txt_apellido_Click(object sender, EventArgs e)
        {
            txt_apellido.Clear();
        }

        private void txt_apellido_Leave(object sender, EventArgs e)
        {
            if (txt_apellido.Text == "")
            {
                txt_apellido.Text = "Apellido";
            }
        }

        private void txt_contra_Click(object sender, EventArgs e)
        {
            txt_contra.Clear();
        }

        private void txt_contra_Leave(object sender, EventArgs e)
        {
            if (txt_contra.Text == "")
            {
                txt_contra.Text = "Contraseña";
            }
        }

        private void txt_cell_Click(object sender, EventArgs e)
        {
            txt_cell.Clear();
        }

        private void txt_cell_Leave(object sender, EventArgs e)
        {
            if (txt_cell.Text == "")
            {
                txt_cell.Text = "Telefono";
            }
        }

        private void txt_confirmar_Click(object sender, EventArgs e)
        {
            txt_confirmar.Clear();
        }

        private void txt_confirmar_Leave(object sender, EventArgs e)
        {
            if (txt_confirmar.Text == "")
            {
                txt_confirmar.Text = "Confirmar Contraseña";
            }
        }

        private void txt_contra_TextChanged(object sender, EventArgs e)
        {
            if(txt_contra.Text != "")
            {
                txt_contra.PasswordChar = '⁕';
            }

            if(txt_contra.Text == "Contraseña")
            {
                txt_contra.PasswordChar = '\0';
            }
        }

        private void txt_confirmar_TextChanged(object sender, EventArgs e)
        {
            if (txt_confirmar.Text != "")
            {
                txt_confirmar.PasswordChar = '⁕';
            }

            if (txt_confirmar.Text == "Confirmar Contraseña")
            {
                txt_confirmar.PasswordChar = '\0';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login regresar = new Login();
            regresar.Show();
        }

        private void registro_ususario_Load(object sender, EventArgs e)
        {
            TemaColors.TemaLogin("color_login");
            panel_central_registro.BackColor = TemaColors.color_form_recibir;
            picture_linea_registro.BackColor = TemaColors.color_form_recibir;
            panel_superior_registro.BackColor = TemaColors.boton_borde_recibir;
            pictureBox6.BackColor = TemaColors.color_form_recibir;
            txt_nombre.BackColor = TemaColors.color_textbox_registro_recibir;
            txt_apellido.BackColor = TemaColors.color_textbox_registro_recibir;
            txt_cell.BackColor = TemaColors.color_textbox_registro_recibir;
            txt_user.BackColor = TemaColors.color_textbox_registro_recibir;
            txt_contra.BackColor = TemaColors.color_textbox_registro_recibir;
            txt_confirmar.BackColor = TemaColors.color_textbox_registro_recibir;
            picture1_mostrar.BackColor = TemaColors.color_form_recibir;
            picture2_mostrar.BackColor = TemaColors.color_form_recibir;
            picture1_ocultar.BackColor = TemaColors.color_form_recibir;
            picture2_ocultar.BackColor = TemaColors.color_form_recibir;
            btn_register.BackColor = TemaColors.boton_verde_recibir;
            panel_nombre_registro.BackColor = TemaColors.color_celeste2_panel_recibir;
            panel_apellido_registro.BackColor = TemaColors.color_celeste2_panel_recibir;
            panel_telefono_registro.BackColor = TemaColors.color_celeste2_panel_recibir;
            panel_nu_registro.BackColor = TemaColors.color_celeste2_panel_recibir;
            panel_contra_registro.BackColor = TemaColors.color_celeste2_panel_recibir;
            panel_confirmar_registro.BackColor = TemaColors.color_celeste2_panel_recibir;
        }

        private void class_new_buttons1_Click(object sender, EventArgs e)
        {


            if (txt_apellido.Text != "" || txt_cell.Text != "" || txt_nombre.Text != "" || txt_user.Text != "" || txt_contra.Text != "")
            {


                if (txt_contra.Text == txt_confirmar.Text)
                {
                    coneciones_Sql_Entrada.registrar_usuarios(txt_user.Text, txt_confirmar.Text, txt_nombre.Text, txt_apellido.Text, txt_cell.Text);
                    string a = coneciones_Sql_Entrada.registrar_usuarios(txt_user.Text, txt_confirmar.Text, txt_nombre.Text, txt_apellido.Text, txt_cell.Text);
                    int b = Convert.ToInt32(a);
                    if (b != 0)
                    {
                        MessageBox.Show("Su registro a sido exitoso", "validación", MessageBoxButtons.OK, MessageBoxIcon.None);
                        error.SetError(txt_confirmar, "");
                        DialogResult resultado_elegido = MessageBox.Show("Quiere entrar con su nuevo usuario ", "Confirmación verificada", MessageBoxButtons.YesNoCancel);
                        switch (resultado_elegido)
                        {
                            case DialogResult.Yes:
                                this.Hide();
                                menu entrar = new menu();
                                entrar.Show();
                                break;
                            case DialogResult.No:
                                this.Hide();
                                Login entrar1 = new Login();
                                entrar1.Show();
                                break;
                            case DialogResult.Cancel:
                                txt_user.Text = "";
                                txt_contra.Text = "";
                                txt_confirmar.Text = "";
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    error.SetError(txt_confirmar, "Contraseña incorrecta");
                }
            }
            
                if(txt_nombre.Text =="Nombre" && txt_apellido.Text =="Apellido" && txt_cell.Text == "Telefono" && txt_user.Text == "Nombre Usuario" && txt_contra.Text == "Contraseña" && txt_confirmar.Text == "Confirmar Contraseña")
                {
                    MessageBox.Show("No se ha llenado ningun dato", "AVISO");
                }

                else
                if (txt_nombre.Text == "Nombre" || txt_apellido.Text == "Apellido" || txt_cell.Text == "Telefono" || txt_user.Text == "Nombre Usuario" || txt_contra.Text == "Contraseña" || txt_confirmar.Text == "Confirmar Contraseña")
                {
                    MessageBox.Show("Falta datos por llenar", "AVISO");
                }

            
        }

        private void picture2_ocultar_Click(object sender, EventArgs e)
        {
            picture2_mostrar.BringToFront();
            txt_confirmar.PasswordChar = '\0';
        }

        private void panel_central_registro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picture2_mostrar_Click(object sender, EventArgs e)
        {
            picture2_ocultar.BringToFront();
            txt_confirmar.PasswordChar = '⁕';
        }

        private void picture1_ocultar_Click(object sender, EventArgs e)
        {
            picture1_mostrar.BringToFront();
            txt_contra.PasswordChar = '\0';
        }

        private void picture1_mostrar_Click(object sender, EventArgs e)
        {
            picture1_ocultar.BringToFront();
            txt_contra.PasswordChar = '⁕';
        }
    }
}
