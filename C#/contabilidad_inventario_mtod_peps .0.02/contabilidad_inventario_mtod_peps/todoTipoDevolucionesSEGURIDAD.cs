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

    class todoTipoDevolucionesSEGURIDAD
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\OneDrive\Documentos\contabilidad_inventario_mtod_peps .0.02\contabilidad_inventario_mtod_peps\inventario.mdf;Integrated Security=True");
        public string totalAcumulado = "Saldo actual acumulado";
        public void ingresarDevolucionSobreCompra(int cantidad)
        {
            try
            {
                con.Open();
                DateTime ingresarFecha = DateTime.Now;
                string txtDevolucionSobreCompra = "Devolcion sobre compra";
                int cantidadDevolucion = cantidad;
                if (cantidadDevolucion<0)
                {
                    MessageBox.Show("Igrese un valor valido para hacer el respectivo proceso(DEVOLUCION)","Error");
                    return;
                }
                string obtenerCostoUnitariorRecienteCompra = "SELECT TOP 1 [No],[Existencias cantidad],[Existencias C/u],[Existencias total] FROM fecha_descripcion WHERE descripcion = 'Compra' AND [Existencias cantidad] > 0 ORDER BY fecha DESC";
                SqlCommand command = new SqlCommand(obtenerCostoUnitariorRecienteCompra, con);
                SqlDataReader extraerCostos = command.ExecuteReader();
                decimal costoUnitario = 0;
                decimal compraTotal = 0;
                decimal cantidadRestaCompra = 0;
                int iDnum = 0;
                if (extraerCostos.Read())
                {
                    cantidadRestaCompra = extraerCostos.GetDecimal(extraerCostos.GetOrdinal("Existencias cantidad"));
                    costoUnitario = extraerCostos.GetDecimal(extraerCostos.GetOrdinal("Existencias C/u"));
                    compraTotal = extraerCostos.GetDecimal(extraerCostos.GetOrdinal("Existencias total"));
                    iDnum = extraerCostos.GetInt32(extraerCostos.GetOrdinal("No"));
                }
                else 
                {
                    MessageBox.Show("No hay DATOS DE COMPRAS para la cantidad de ventas para calcular el costo unitario y total", "DATOS INSUFICIENTES");
                    return;
                }
                extraerCostos.Close();
                decimal total = cantidadDevolucion * costoUnitario;
                string ingresarDevolucionCompra = "INSERT INTO fecha_descripcion(fecha,descripcion,[Salida cantidad],[Salida C/u],[Salida total]) VALUES (@fecha,@decrip,@cant,@costUni,@total)";
                SqlCommand sqlCommand = new SqlCommand(ingresarDevolucionCompra, con);
                sqlCommand.Parameters.AddWithValue("@fecha", ingresarFecha);
                sqlCommand.Parameters.AddWithValue("@decrip", txtDevolucionSobreCompra);
                sqlCommand.Parameters.AddWithValue("@cant", cantidadDevolucion);
                sqlCommand.Parameters.AddWithValue("@costUni", costoUnitario);
                sqlCommand.Parameters.AddWithValue("@total", total);
                sqlCommand.ExecuteNonQuery();
                decimal actializarCantidad = cantidadRestaCompra - cantidadDevolucion;
                decimal totall = compraTotal - total;
                string actualizarComprasUsadas = "UPDATE fecha_descripcion SET [Existencias cantidad]=@actualizarCompra,[Existencias total]=@tot WHERE [No] = @No";
                SqlCommand update = new SqlCommand(actualizarComprasUsadas, con);
                update.Parameters.AddWithValue("@actualizarCompra", actializarCantidad);
                update.Parameters.AddWithValue("@tot", totall);
                update.Parameters.AddWithValue("@No", iDnum);
                update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Clase todoTipoDevolucionesSEGURIDAD method: ingresarDevolucionSobreCompra ---   {ex}  ");

            }
            finally
            {
                con.Close();
            }
        }
        public void ingresarDevolucionSobreVenta(int cantidad)
        {
            try
            {
                con.Open();
                DateTime ingresarFecha = DateTime.Now;
                string devoclucionSobreVenta = "Devolucion sobre venta";
                int cantidadDevolucionVenta = cantidad;
                if (cantidadDevolucionVenta < 0)
                {
                    MessageBox.Show($"Ingresar un valor valido o dato correcto Error: cantidad {cantidadDevolucionVenta}");
                    return;
                }
                string obtenerCostoUnitarioRecienteVenta = "SELECT TOP 1  [No],[Salida cantidad],[Salida C/u],[Salida total] FROM fecha_descripcion WHERE descripcion ='Venta' ORDER BY fecha DESC";
                SqlCommand sqlCommand = new SqlCommand(obtenerCostoUnitarioRecienteVenta, con);
                SqlDataReader extraerDatosVenta = sqlCommand.ExecuteReader();
                decimal costoUnitario = 0;
                decimal VentasTotal = 0;
                decimal cantidadSumarCompra = 0;
                int iDnum = 0;
                if (extraerDatosVenta.Read())
                {
                    cantidadSumarCompra = extraerDatosVenta.GetDecimal(extraerDatosVenta.GetOrdinal("Salida cantidad"));
                    costoUnitario = extraerDatosVenta.GetDecimal(extraerDatosVenta.GetOrdinal("Salida C/u"));
                    VentasTotal = extraerDatosVenta.GetDecimal(extraerDatosVenta.GetOrdinal("Salida total"));
                    iDnum = extraerDatosVenta.GetInt32(extraerDatosVenta.GetOrdinal("No"));
                }
                else
                {
                    MessageBox.Show("No hay DATOS DE VENTAS para la cantidad de ventas para calcular el costo unitario y total", "DATOS INSUFICIENTES");
                    return;
                }
                extraerDatosVenta.Close();
                decimal total = cantidadSumarCompra * costoUnitario;
                string ingresarDevolucionVenta = "INSERT INTO fecha_descripcion(fecha,descripcion,[Entrada cantidad],[Entrada C/u],[Entrada total])" +
                    "VALUES(@fecha,@descrip,@cantidad,@costoUni,@tota)";
                SqlCommand command = new SqlCommand(ingresarDevolucionVenta, con);
                command.Parameters.AddWithValue("@fecha", ingresarFecha);
                command.Parameters.AddWithValue("@descrip", devoclucionSobreVenta);
                command.Parameters.AddWithValue("@cantidad", cantidadDevolucionVenta);
                command.Parameters.AddWithValue("@costoUni", costoUnitario);
                command.Parameters.AddWithValue("@tota", total);
                command.ExecuteNonQuery();
                decimal sumarActualizarDatosVenta = cantidadSumarCompra + cantidadDevolucionVenta;
                decimal totall = VentasTotal + total;
                string UpdateCompra = $"UPDATE fecha_descripcion SET [Existencias cantidad]=@actualizarSaldo,[Existencias total]=@tot WHERE descripcion= 'Compra' AND [Existencias C/u] = @cosUni";
                SqlCommand sqlCommand1 = new SqlCommand(UpdateCompra, con);
                sqlCommand1.Parameters.AddWithValue("@actualizarSaldo", sumarActualizarDatosVenta);
                sqlCommand1.Parameters.AddWithValue("@tot", totall);
                sqlCommand1.Parameters.AddWithValue("@cosUni", costoUnitario);
                sqlCommand1.ExecuteNonQuery();
            }catch(Exception ex) {
                MessageBox.Show($"Error Clase todoTipoDevolucionesSEGURIDAD method: ingresarDevolucionSobreCompra ---   {ex}  ");
            }
            finally { con.Close(); }
        }
        public void borrarTablas()
        {
            try
            {
                con.Open();
                string borrarDatosTablas = "TRUNCATE TABLE fecha_descripcion";
                SqlCommand borrar = new SqlCommand(borrarDatosTablas, con);
                borrar.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Clase borrarTablas method: ingresarDevolucionSobreCompra ---   {ex}  ");
            }
            finally
            {
                con.Close();
            }
          }
    }

}
