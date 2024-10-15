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
    public class mostrar_tablas
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\OneDrive\Documentos\contabilidad_inventario_mtod_peps .0.02\contabilidad_inventario_mtod_peps\inventario.mdf;Integrated Security=True");
        public string totalAcumulado = "Saldo actual acumulado";
        public DataTable datos1()
        {
            string datos_descripcion = "SELECT * FROM fecha_descripcion ";
            SqlCommand command = new SqlCommand(datos_descripcion, con);
            SqlDataAdapter dato_01 = new SqlDataAdapter(command);
            DataTable tabla_1 = new DataTable();
            dato_01.Fill(tabla_1);
            return tabla_1;
        }
        public DataTable tabla2()
        {
            string datos_descripcion = "SELECT fecha ,descripcion,[Existencias cantidad],[Existencias C/u],[Existencias total]FROM fecha_descripcion ";
            SqlCommand command = new SqlCommand(datos_descripcion, con);
            SqlDataAdapter dato_01 = new SqlDataAdapter(command);
            DataTable tabla_1 = new DataTable();
            dato_01.Fill(tabla_1);
            return tabla_1;
        }
        public void actualizarSaldoAcumulado()
        {
            try
            {
                con.Open();
                decimal totalCantidadCompras = 0;
                decimal totalTotalCompras = 0;
                string calcularTotalCompras = "SELECT SUM([Existencias cantidad]) AS TotalCantidad, SUM([Existencias total]) AS TotalTotal " +
                    "FROM fecha_descripcion WHERE descripcion = 'Compra' ";


                SqlCommand calcularTotalComprasCommand = new SqlCommand(calcularTotalCompras, con);
                SqlDataReader readerCompras = calcularTotalComprasCommand.ExecuteReader();

                if (readerCompras.Read())
                {
                    totalCantidadCompras = readerCompras.GetDecimal(readerCompras.GetOrdinal("TotalCantidad"));
                    totalTotalCompras = readerCompras.GetDecimal(readerCompras.GetOrdinal("TotalTotal"));
                }

                readerCompras.Close();


                decimal totalCantidad = totalCantidadCompras;
                decimal totalTotal = totalTotalCompras;

                string insertarTotal = $"INSERT INTO fecha_descripcion(fecha, descripcion, [Existencias cantidad], [Existencias total]) VALUES (@fecha, '{totalAcumulado}' , @totalCantidad, @totalTotal)";
                SqlCommand totalCommand = new SqlCommand(insertarTotal, con);
                totalCommand.Parameters.AddWithValue("@fecha", DateTime.Now);
                totalCommand.Parameters.AddWithValue("@totalCantidad", totalCantidad);
                totalCommand.Parameters.AddWithValue("@totalTotal", totalTotal);
                totalCommand.ExecuteNonQuery();
            }
            catch(Exception ex) {
                MessageBox.Show($"Error Clase conexion_DTB method: ingresarVentasPEPS---{ex}");
            } finally { 
                con.Close(); 
            }
        }
      public void ingresar_saldo(int cant, float cos_unit)
        {
            try
            {
                con.Open();
                DateTime fecha = DateTime.Now;
                float total = cant * cos_unit;
                string saldo_inicial = "Compra";
                string saldo = "INSERT INTO fecha_descripcion (fecha,descripcion,[Existencias cantidad], [Existencias C/u], [Existencias total]) " +
                    "VALUES (@fecha,@descrip,@cant, @cos_unit, @sum)";
                SqlCommand command = new SqlCommand(saldo, con);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@descrip", saldo_inicial);
                command.Parameters.AddWithValue("@cant", cant);
                command.Parameters.AddWithValue("@cos_unit", cos_unit);
                command.Parameters.AddWithValue("@sum", total);
                command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error consultas SQL: {ex}");
            }
            finally
            {
                con.Close(); 
            }
        }
        public void IngresarCompraPEPS(int cantidad, float costoUnitario)
        {
            try
{
    con.Open();
    DateTime fecha = DateTime.Now;
    decimal total = cantidad * (decimal)costoUnitario; 
    string compra = "Compra";

    string ingresarCompra = "INSERT INTO fecha_descripcion(fecha, descripcion, [Entrada cantidad], [Entrada C/u], [Entrada total],[Existencias cantidad],[Existencias C/u],[Existencias total]) " +
      "VALUES (@fecha, @descrip, @cant, @costo, @total,@Exit_cant,@Exit_uni,@Exit_tot)";
    SqlCommand command = new SqlCommand(ingresarCompra, con);
    command.Parameters.AddWithValue("@fecha", fecha);
    command.Parameters.AddWithValue("@descrip", compra);
    command.Parameters.AddWithValue("@cant", cantidad);
    command.Parameters.AddWithValue("@costo", costoUnitario);
    command.Parameters.AddWithValue("@total", total);
    command.Parameters.AddWithValue("@Exit_cant", cantidad);
    command.Parameters.AddWithValue("@Exit_uni", costoUnitario);
    command.Parameters.AddWithValue("@Exit_tot", total);
    command.ExecuteNonQuery();
            }
            catch (Exception ex)
{
    MessageBox.Show($"Error consultas SQL: {ex}");
}
finally
{
    con.Close();
}
        }

        public void ingresarVentaPEPS(int cantidad)
        {
            try 
            {
                con.Open();
                DateTime ingresarFecha = DateTime.Now;
                string venta = "Venta";
                int cantidadVentas = cantidad;
                if (cantidadVentas<=0)
                {
                    MessageBox.Show($"Ingresar un valor valido o dato correcto Error: cantidad {cantidadVentas}");
                    return;
                }
                string obtenerCostoUnitarioUltimaSaldoIncial = "SELECT TOP 1 [No], [Existencias cantidad],[Existencias C/u],[Existencias total] FROM fecha_descripcion" +
                 " WHERE descripcion = 'Compra'" +
                 " AND [Existencias cantidad] > 0 ORDER BY fecha ASC ";

                SqlCommand sqlCommand = new SqlCommand(obtenerCostoUnitarioUltimaSaldoIncial, con);
                SqlDataReader ExtraerCostoTotal = sqlCommand.ExecuteReader();
                decimal costoUnitario = 0;
                decimal ventaTotal = 0;
                decimal cantidadRestarCompra = 0;
                int IDnum = 0;
                if (ExtraerCostoTotal.Read())
                {
                    cantidadRestarCompra = ExtraerCostoTotal.GetDecimal(ExtraerCostoTotal.GetOrdinal("Existencias cantidad"));
                    costoUnitario = ExtraerCostoTotal.GetDecimal(ExtraerCostoTotal.GetOrdinal("Existencias C/u"));
                    ventaTotal = ExtraerCostoTotal.GetDecimal(ExtraerCostoTotal.GetOrdinal("Existencias total"));
                    IDnum = ExtraerCostoTotal.GetInt32(ExtraerCostoTotal.GetOrdinal("No"));

                }
                else
                {
                    MessageBox.Show("No hay DATOS DE COMPRAS para la cantidad de ventas para calcular el costo unitario y total", "DATOS INSUFICIENTES");
                    return;
                }
                ExtraerCostoTotal.Close();
                decimal Total = cantidadVentas * costoUnitario;
                string ingresarVenta = "INSERT INTO fecha_descripcion(fecha,descripcion,[Salida cantidad],[Salida C/u],[Salida total])" +
                    "VALUES(@fecha,@decrip,@cant,@costUni,@total)";
                SqlCommand commandVentas = new SqlCommand(ingresarVenta, con);
                commandVentas.Parameters.AddWithValue("@fecha",ingresarFecha);
                commandVentas.Parameters.AddWithValue("@decrip", venta);
                commandVentas.Parameters.AddWithValue("@cant", cantidadVentas);
                commandVentas.Parameters.AddWithValue("@costUni", costoUnitario);
                commandVentas.Parameters.AddWithValue("@total", Total);
                commandVentas.ExecuteNonQuery();

                decimal actualizarSaldos = cantidadRestarCompra - cantidadVentas;
                decimal totall = ventaTotal - Total;
                string actualizarCompraCantidades = "UPDATE fecha_descripcion " +
                    "SET [Existencias cantidad] = @actualizarSaldos, [Existencias total] = @tot " +
                    "WHERE [No] = @No";


                SqlCommand actualizarCompra = new SqlCommand(actualizarCompraCantidades, con);
                actualizarCompra.Parameters.AddWithValue("@actualizarSaldos", actualizarSaldos);
                actualizarCompra.Parameters.AddWithValue("@tot", totall);
                actualizarCompra.Parameters.AddWithValue("@No", IDnum);
                actualizarCompra.ExecuteNonQuery();

            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Error Clase conexion_DTB method: ingresarVentasPEPS---{ex}"); 
            } 
            finally 
            { 
             con.Close(); 
            }
        }

    }
}
