using System;
using Pasword;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generador_contraseña.formularios.busqueda
{
    public partial class busqueda_contraseñas : Form
    {
        public busqueda_contraseñas()
        {
            InitializeComponent();
        }

        private void busqueda_contraseñas_Load(object sender, EventArgs e)
        {
            TemaColors.TemaLogin("color_login");
            panel_central_busqueda.BackColor = TemaColors.color_form_recibir;
            picture_linea_busqueda.BackColor = TemaColors.color_form_recibir;
            panel_superior_busqueda.BackColor = TemaColors.boton_borde_recibir;
            lb_nombre_contra_busqueda.BackColor = TemaColors.color_form_recibir;
            txt_nombre_busqueda.BackColor = TemaColors.color_form_recibir;
            dtg_selec.BackgroundColor = TemaColors.boton_borde_recibir;
            dtg_selec_from.BackgroundColor = TemaColors.boton_borde_recibir;

            TemaColors.TemaLogin("color_botones_busqueda");
            btn_buscar_busqueda.BackColor = TemaColors.color_btn_buscar_recibir;
            btn_eliminar_busqueda.BackColor = TemaColors.color_btn_eliminar_recibir;
            panel_btn_busqueda.BackColor = TemaColors.color_btn_buscar_recibir;
            panel_btn_eliminar.BackColor = TemaColors.color_btn_eliminar_recibir;
            panel_nombre_contra_busqueda.BackColor = TemaColors.color_panel_busqueda_recibir;



            datos_Sql.coneciones_sql_entrada_salida_datos coneciones_Sql_Entrada= new datos_Sql.coneciones_sql_entrada_salida_datos();
            dtg_selec_from.DataSource = coneciones_Sql_Entrada.cargar_daragrip();
        }

    
        private void class_new_buttons1_Click(object sender, EventArgs e)
        {
            if (dtg_selec_from.CurrentRow != null)
            {

                if (MessageBox.Show("Esta seguro que quiere eliminar la contraseña, se eliminara permanentemente", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    datos_Sql.coneciones_sql_entrada_salida_datos delete = new datos_Sql.coneciones_sql_entrada_salida_datos();
                    string datos = Convert.ToString(dtg_selec_from.CurrentRow.Cells[0].Value);
                    delete.delete(datos);
                    dtg_selec_from.DataSource = delete.cargar_daragrip();
                    dtg_selec_from.Columns["id"].Visible = false;
                }
                else
                {
                    datos_Sql.coneciones_sql_entrada_salida_datos delete = new datos_Sql.coneciones_sql_entrada_salida_datos();
                    dtg_selec_from.DataSource = delete.cargar_daragrip();
                    dtg_selec_from.Columns["id"].Visible = false;


                }
            }
        }

        private void txt_nombre_busqueda_Enter(object sender, EventArgs e)
        {
            datos_Sql.coneciones_sql_entrada_salida_datos select = new datos_Sql.coneciones_sql_entrada_salida_datos();
            dtg_selec.DataSource = select.busqueda(txt_nombre_busqueda.Text);
        }

        private void btn_buscar_busqueda_Click(object sender, EventArgs e)
        {
            datos_Sql.coneciones_sql_entrada_salida_datos select = new datos_Sql.coneciones_sql_entrada_salida_datos();
            dtg_selec.Visible = true;
            dtg_selec.DataSource = select.busqueda(txt_nombre_busqueda.Text);
            dtg_selec.Columns["id"].Visible = false;
            dtg_selec.Visible = true;
            dtg_selec_from.Columns["id"].Visible = false;
        }

        private void btn_eliminar_busqueda_Click(object sender, EventArgs e)
        {
            if (dtg_selec_from.CurrentRow != null)
            {

                if (MessageBox.Show("Esta seguro que quiere eliminar la contraseña, se eliminara permanentemente", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    datos_Sql.coneciones_sql_entrada_salida_datos delete = new datos_Sql.coneciones_sql_entrada_salida_datos();
                    string datos = Convert.ToString(dtg_selec_from.CurrentRow.Cells[0].Value);
                    delete.delete(datos);
                    dtg_selec_from.DataSource = delete.cargar_daragrip();
                    dtg_selec_from.Columns["id"].Visible = false;
                }
                else
                {
                    datos_Sql.coneciones_sql_entrada_salida_datos delete = new datos_Sql.coneciones_sql_entrada_salida_datos();
                    dtg_selec_from.DataSource = delete.cargar_daragrip();
                    dtg_selec_from.Columns["id"].Visible = false;


                }
            }
        }
        private void dtg_selec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_selec_from.Columns["id"].Visible = false;

        }

        private void dtg_selec_from_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_selec_from.Columns["id"].Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu1 = new menu();
            menu1.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_central_busqueda_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
