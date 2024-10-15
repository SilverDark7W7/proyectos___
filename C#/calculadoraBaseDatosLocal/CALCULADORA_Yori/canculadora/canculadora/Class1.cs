using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace canculadora
{

    class resultados_base_datos
    {

        public DataTable mostrar_resultados(string cifra1, string cifra2, string operacion, string resultado)
        {

            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrgdc\source\repos\canculadora\canculadora\historial_calculadora.mdf;Integrated Security=True");
            conexion.Open();
            string insertar_procedimientos = "INSERT INTO resultados(Primera_cifra,Operacion,Segunda_cifra,Resultado)" +
                "VALUES(@num1,@operacion,@num2,@total)";
            SqlCommand enviar_dtos = new SqlCommand(insertar_procedimientos, conexion);
            enviar_dtos.Parameters.AddWithValue("@num1", cifra1);
            enviar_dtos.Parameters.AddWithValue("@operacion", operacion);
            enviar_dtos.Parameters.AddWithValue("@num2", cifra2);
            enviar_dtos.Parameters.AddWithValue("@total", resultado);

            enviar_dtos.ExecuteNonQuery();// Ejecutar la consulta SQL para insertar los datos en la tabla
            string mostrar = "SELECT * FROM resultados";
            SqlCommand mostrar_consulta = new SqlCommand(mostrar, conexion);
            SqlDataAdapter ejecutar_consulta = new SqlDataAdapter(mostrar_consulta);
            DataTable table = new DataTable();
            ejecutar_consulta.Fill(table);
            return table;
            // num1 = Convert.ToInt32(cifra1);
            //num2 = Convert.ToInt32(cifra2);
        }
        public DataTable eliminar_fila(string dato_id)
        {

            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrgdc\source\repos\canculadora\canculadora\historial_calculadora.mdf;Integrated Security=True");
            conexion.Open();
            string eliminar_fila = "delete from resultados where NO =" + dato_id + "";

            SqlCommand delete = new SqlCommand(eliminar_fila, conexion);
            delete.ExecuteNonQuery();// Ejecutar la consulta SQL para insertar los datos en la tabla
            string mostrar = "SELECT * FROM resultados";
            SqlCommand mostrar_consulta = new SqlCommand(mostrar, conexion);
            SqlDataAdapter ejecutar_consulta = new SqlDataAdapter(mostrar_consulta);
            DataTable table_delete = new DataTable();
            ejecutar_consulta.Fill(table_delete);
            return table_delete;

        }
        public DataTable select_datos(string dato_id)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrgdc\source\repos\canculadora\canculadora\historial_calculadora.mdf;Integrated Security=True");
            conexion.Open();
            string selccionar = "SELECT * FROM resultados WHERE NO =" + dato_id + "";
            SqlCommand delete = new SqlCommand(selccionar, conexion);
            SqlCommand mostrar_consulta = new SqlCommand(selccionar, conexion);
            SqlDataAdapter ejecutar_consulta = new SqlDataAdapter(mostrar_consulta);
            DataTable table_select = new DataTable();
            ejecutar_consulta.Fill(table_select);
            return table_select;
        }
        public DataTable update(string dato_id_update,string dato1,string operacion,string dato2,string resultado)
        {
            int result_id;
            result_id = Convert.ToInt32(dato_id_update);
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jrgdc\source\repos\canculadora\canculadora\historial_calculadora.mdf;Integrated Security=True");
            conexion.Open();
            string modificar = "update resultados set Primera_cifra='" + dato1 + "', Operacion='" + operacion + "', Segunda_cifra='" + dato2 + "', Resultado='" + resultado + "' where NO =" + dato_id_update;
            SqlCommand mostrar_consulta_modificada = new SqlCommand(modificar, conexion);
            mostrar_consulta_modificada.ExecuteNonQuery();// Ejecutar la consulta SQL para insertar los datos en la tabla
            string mostrar = "SELECT * FROM resultados";
            SqlCommand mostrar_consultamodificada = new SqlCommand(mostrar, conexion);
            SqlDataAdapter ejecutar_consultamodificada = new SqlDataAdapter(mostrar_consultamodificada);
            DataTable table_deletemodificada = new DataTable();
            ejecutar_consultamodificada.Fill(table_deletemodificada);
            return table_deletemodificada;


            /*  SqlDataAdapter ejecutar_consulta = new SqlDataAdapter(mostrar_consulta_modificada);
              DataTable table_update = new DataTable();
              ejecutar_consulta.Fill(table_update);
              return table_update;*/

        }





    }

    
}
