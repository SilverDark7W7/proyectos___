using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace contabilidad_inventario_mtod_peps
{
    public partial class inicio : Form
    {
        mostrar_tablas DTB = new mostrar_tablas();
        todoTipoDevolucionesSEGURIDAD devoluciones = new todoTipoDevolucionesSEGURIDAD();
        public inicio()
        {
            InitializeComponent();
        }
        private void inicio_Load(object sender, EventArgs e)
        {
            mostrar_tablas DTB = new mostrar_tablas();
            DTG_datos.DataSource = DTB.tabla2();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btn_ingresar_compra.Visible = true;
            btn_ingresar_venta.Visible = false;
            btn_ingresar_saldo.Visible = false;
            btn_DevoclucionSC.Visible = false;
            btn_DevolucionSV.Visible = false;

            txt_saldo_costo_unitario.Visible = false;
            txt_saldo_cantidad.Visible = false;
            txt_compra_costo_unitario.Visible = true;
            txt_cantidad_compra.Visible = true;
            txt_venta_cantidad.Visible = false;
            txt_sobre_compra_cantidad.Visible = false;
            txt_sobre_venta_cantidad.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            btn_ingresar_compra.Visible = false;
            btn_ingresar_saldo.Visible = false;
            btn_ingresar_venta.Visible = true;
            btn_DevoclucionSC.Visible = false;
            btn_DevolucionSV.Visible = false;

            txt_saldo_costo_unitario.Visible = false;
            txt_saldo_cantidad.Visible = false;
            txt_compra_costo_unitario.Visible = false;
            txt_cantidad_compra.Visible = false;
            txt_venta_cantidad.Visible = true;
            txt_sobre_compra_cantidad.Visible = false;
            txt_sobre_venta_cantidad.Visible = false;
        }
        private void btn_devolucion_sobre_compra_Click(object sender, EventArgs e)
        {
            btn_ingresar_compra.Visible = false;
            btn_ingresar_saldo.Visible = false;
            btn_ingresar_venta.Visible = false;
            btn_DevoclucionSC.Visible = true;
            btn_DevolucionSV.Visible = false;

            
            txt_saldo_costo_unitario.Visible = false;
            txt_saldo_cantidad.Visible = false;
            txt_compra_costo_unitario.Visible = false;
            txt_cantidad_compra.Visible = false;
            txt_venta_cantidad.Visible = false;
            txt_sobre_compra_cantidad.Visible = true;
            txt_sobre_venta_cantidad.Visible = false;
        }
        private void btn_devolucion_sobre_venta_Click(object sender, EventArgs e)
        {
            btn_DevoclucionSC.Visible = false;
            btn_DevolucionSV.Visible = true;
            btn_ingresar_compra.Visible = false;
            btn_ingresar_saldo.Visible = false;
            btn_ingresar_venta.Visible = false;

            txt_saldo_costo_unitario.Visible = false;
            txt_saldo_cantidad.Visible=false;
            txt_compra_costo_unitario.Visible = false;
            txt_cantidad_compra.Visible = false;
            txt_venta_cantidad.Visible = false;
            txt_sobre_compra_cantidad.Visible = false;
            txt_sobre_venta_cantidad.Visible = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_venta_cantidad_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_saldo_inicial_Click(object sender, EventArgs e)
        {

            btn_ingresar_compra.Visible = false;
            btn_ingresar_saldo.Visible = true;
            btn_ingresar_venta.Visible = false;
            btn_DevoclucionSC.Visible = false;
            btn_DevolucionSV.Visible = false;

            txt_saldo_costo_unitario.Visible = true;
            txt_saldo_cantidad.Visible = true;
            txt_compra_costo_unitario.Visible = false;
            txt_cantidad_compra.Visible = false;
            txt_venta_cantidad.Visible = false;
            txt_sobre_compra_cantidad.Visible = false;
            txt_sobre_venta_cantidad.Visible = false;
            


        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                float costo_unit;
                if (!string.IsNullOrEmpty(txt_saldo_cantidad.Text))
                {
                    cantidad = Convert.ToInt32(txt_saldo_cantidad.Text);
                    costo_unit = Convert.ToInt32(txt_saldo_costo_unitario.Text);
                    DTB.ingresar_saldo(cantidad, costo_unit);

                    DTG_datos.DataSource = DTB.tabla2();

                }
            }
            catch(Exception ex) { MessageBox.Show("error: boton ingresar" + ex + " ", "Error"); 
            }
         
        }
        private void btn_ingresar_compra_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                float costo_unit;
                if (!string.IsNullOrEmpty(txt_cantidad_compra.Text))
                {
                    cantidad = int.Parse(txt_cantidad_compra.Text);
                    costo_unit = float.Parse(txt_compra_costo_unitario.Text);
                    DTB.IngresarCompraPEPS(cantidad, costo_unit);
                    DTG_datos.DataSource = DTB.tabla2();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: boton ingresar" + ex + " ", "Error");
            }
        }
        private void btn_ingresar_venta_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                if (!string.IsNullOrEmpty(txt_venta_cantidad.Text))
                {
                    cantidad = int.Parse(txt_venta_cantidad.Text);
                    DTB.ingresarVentaPEPS(cantidad);
                    DTG_datos.DataSource = DTB.tabla2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: boton ingresar" + ex + " ", "Error");
            }
        }
        private void btn_DevolucionSV_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                if (!string.IsNullOrEmpty(txt_sobre_venta_cantidad.Text))
                {
                    cantidad = int.Parse(txt_sobre_venta_cantidad.Text);
                    devoluciones.ingresarDevolucionSobreVenta(cantidad);
                    DTG_datos.DataSource = DTB.tabla2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: boton ingresar" + ex + " ", "Error");
            }
        }
        private void btn_DevoclucionSC_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                if (!string.IsNullOrEmpty(txt_sobre_compra_cantidad.Text))
                {
                 cantidad = int.Parse(txt_sobre_compra_cantidad.Text);
                 devoluciones.ingresarDevolucionSobreCompra(cantidad);
                 DTG_datos.DataSource = DTB.tabla2();
                }
            }
            catch (Exception ex)
            {
             MessageBox.Show("error: boton ingresar" + ex + " ", "Error");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DTB.actualizarSaldoAcumulado();
            DTG_datos.DataSource = DTB.tabla2();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Datos_completos a = new Datos_completos();
            a.Show();
        }

        private void txt_saldo_costo_unitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_cantidad_compra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_devolucion_venta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_devolucion_compra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sobre_venta_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sobre_compra_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_central_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_cantidad_compra_Leave(object sender, EventArgs e)
        {
            if (txt_cantidad_compra.Text == "") 
            {
                txt_cantidad_compra.Text = "Cantidad";
            }
        }

        private void txt_cantidad_compra_Click(object sender, EventArgs e)
        {
            txt_cantidad_compra.Clear();
        }

        private void txt_compra_costo_unitario_Leave(object sender, EventArgs e)
        {
            if(txt_compra_costo_unitario.Text=="")
            {
                txt_compra_costo_unitario.Text = "Costo";

            }
        }

        private void txt_compra_costo_unitario_Click(object sender, EventArgs e)
        {
            txt_compra_costo_unitario.Clear();

        }

        private void txt_saldo_cantidad_Leave(object sender, EventArgs e)
        {
            if (txt_saldo_cantidad.Text == "")
            {
                txt_saldo_cantidad.Text = "Cantidad";


            }
        }

        private void txt_saldo_cantidad_Click(object sender, EventArgs e)
        {
            txt_saldo_cantidad.Clear();

        }

        private void txt_saldo_costo_unitario_Leave(object sender, EventArgs e)
        {
            if (txt_saldo_costo_unitario.Text== "")
            {
                txt_saldo_costo_unitario.Text= "Costo";

            }
        }

        private void txt_saldo_costo_unitario_Click(object sender, EventArgs e)
        {
            txt_saldo_costo_unitario.Clear();
        }

        private void txt_devolucion_venta_Leave(object sender, EventArgs e)
        {
            if(txt_devolucion_venta.Text=="")
            {
                txt_devolucion_venta.Text = "Cantidad";
            }
        }

        private void txt_devolucion_venta_Click(object sender, EventArgs e)
        {
            txt_devolucion_venta.Clear();
        }

        private void txt_venta_cantidad_Leave(object sender, EventArgs e)
        {
            if(txt_venta_cantidad.Text=="")
            {
                txt_venta_cantidad.Text = "Cantidad";
            }
        }

        private void txt_venta_cantidad_Click(object sender, EventArgs e)
        {
            txt_venta_cantidad.Clear();
        }

        private void txt_sobre_venta_cantidad_Leave(object sender, EventArgs e)
        {
            if(txt_sobre_venta_cantidad.Text=="")
            {
                txt_sobre_venta_cantidad.Text = "Cantidad";
            }
        }

        private void txt_sobre_venta_cantidad_Click(object sender, EventArgs e)
        {
            txt_sobre_venta_cantidad.Clear();
        }

        private void txt_devolucion_compra_Leave(object sender, EventArgs e)
        {
            if(txt_devolucion_compra.Text=="")
            {
                txt_devolucion_compra.Text = "Cantidad";
            }
        }

        private void txt_devolucion_compra_Click(object sender, EventArgs e)
        {
            txt_devolucion_compra.Clear();
        }

        private void txt_sobre_compra_cantidad_Leave(object sender, EventArgs e)
        {
            if(txt_sobre_compra_cantidad.Text=="")
            {
                txt_sobre_compra_cantidad.Text = "Cantidad";
            }
        }

        private void txt_sobre_compra_cantidad_Click(object sender, EventArgs e)
        {
            txt_sobre_compra_cantidad.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de limpiar los datos ", "confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                devoluciones.borrarTablas();
                DTG_datos.DataSource = DTB.tabla2();


            }
            else
            {

            }
        }
    }
}

