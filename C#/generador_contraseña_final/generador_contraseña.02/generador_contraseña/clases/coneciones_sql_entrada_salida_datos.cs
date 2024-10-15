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



    namespace datos_Sql
    {

    class coneciones_sql_entrada_salida_datos
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True");

        public void recibir_datos(string contrasena, string nombre_contraseña)
        {
            conexion.Open();
            string enviar_contrasena = "INSERT INTO Guardado_contrasenas (Nombre_contrasena,Contrasena)" +
            "VALUES (@Nombre_contrasena, @Contrasena) ";
            SqlCommand enviar_datos = new SqlCommand(enviar_contrasena, conexion);
            enviar_datos.Parameters.AddWithValue("@Nombre_contrasena", nombre_contraseña);
            enviar_datos.Parameters.AddWithValue("@Contrasena", contrasena);
            enviar_datos.ExecuteNonQuery();
            conexion.Close();
        }
        public void recibir_datos_fecha_incluida(string contrasena, string nombre_contraseña)
        {
            conexion.Open();
            string enviar_contrasena = "INSERT INTO Guardado_contrasenas (Nombre_contrasena,Contrasena,fecha)" +
            "VALUES (@Nombre_contrasena, @Contrasena,GETDATE()) ";
            SqlCommand enviar_datos = new SqlCommand(enviar_contrasena, conexion);
            enviar_datos.Parameters.AddWithValue("@Nombre_contrasena", nombre_contraseña);
            enviar_datos.Parameters.AddWithValue("@Contrasena", contrasena);
            enviar_datos.ExecuteNonQuery();
            conexion.Close();
        }



        public DataTable cargar_daragrip()
        {
            string enviar_datos_datagrip = "SELECT * FROM Guardado_contrasenas";
            SqlCommand mostras_tabla_todos_datos = new SqlCommand(enviar_datos_datagrip, conexion);
            SqlDataAdapter consulta = new SqlDataAdapter(mostras_tabla_todos_datos);
            DataTable Tabla = new DataTable();
            consulta.Fill(Tabla);
            return Tabla;

        }
        public void update(string id_dato, string nombre_contrase_nueva, string contrasena_nueva)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True ");
            conexion.Open();

            int id_contra = 0;

            id_contra = Convert.ToInt32(id_dato);

            string Upddate = "UPDATE Guardado_contrasenas  SET Nombre_contrasena='" + nombre_contrase_nueva + "',Contrasena='" + contrasena_nueva + "'WHERE id=" + id_contra;
            SqlCommand mostrar_consulta_modificada = new SqlCommand(Upddate, conexion);
            mostrar_consulta_modificada.ExecuteNonQuery();
            conexion.Close();

        }
        public void update_fecha_incluida(string id_dato, string nombre_contrase_nueva, string contrasena_nueva)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True  ");
            conexion.Open();

            int id_contra = 0;

            id_contra = Convert.ToInt32(id_dato);

            string Upddate = "UPDATE Guardado_contrasenas  SET Nombre_contrasena='" + nombre_contrase_nueva + "',Contrasena='" + contrasena_nueva + "',fecha= GETDATE() WHERE id=" + id_contra;
            SqlCommand mostrar_consulta_modificada = new SqlCommand(Upddate, conexion);
            mostrar_consulta_modificada.ExecuteNonQuery();
            conexion.Close();

        }



        public void cambio_datos_usuario_update(string nombre, string contraseña, string nombre_usuario)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True");
            conexion.Open();
            string cambio_datos = "UPDATE Usuario SET Usuario=@nombre, Contrasena=@contraseña WHERE Usuario=@usuario";
            SqlCommand ejecutar_consulta = new SqlCommand(cambio_datos, conexion);
            ejecutar_consulta.Parameters.AddWithValue("@nombre", nombre);
            ejecutar_consulta.Parameters.AddWithValue("@contraseña", contraseña);
            ejecutar_consulta.Parameters.AddWithValue("@usuario", nombre_usuario);
            ejecutar_consulta.ExecuteNonQuery();
            conexion.Close();

        }
        public string registrar_usuarios(string nombre_user, string contrasena, string nombre, string apellido, string telefono)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True  ");
            conexion.Open();
            string registrar_nuevo_usuario = "INSERT INTO Usuario(Usuario,contrasena,nombre,apellido,telefono)" +
                "VALUES (@user,@contra,@nomb,@apell,@cell) ";
            SqlCommand inser = new SqlCommand(registrar_nuevo_usuario, conexion);
            inser.Parameters.AddWithValue("@user", nombre_user);
            inser.Parameters.AddWithValue("@contra", contrasena);
            inser.Parameters.AddWithValue("@nomb", nombre);
            inser.Parameters.AddWithValue("@apell", apellido);
            inser.Parameters.AddWithValue("@cell", telefono);
            inser.ExecuteNonQuery();
            conexion.Close();
            string verf = "1 ";
            return verf;
        }

        public DataTable busqueda(string nombre)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True ");
            conexion.Open();
            string buscar = "SELECT * FROM Guardado_contrasenas WHERE Nombre_contrasena =@nom_contra";
            SqlCommand select = new SqlCommand(buscar, conexion);
            select.Parameters.AddWithValue("@NOM_CONTRA", nombre);
            SqlDataAdapter consulta = new SqlDataAdapter(select);
            DataTable Tabla = new DataTable();
            consulta.Fill(Tabla);
            return Tabla;




        }
        public void delete(string id)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True ");
            conexion.Open();
            string delete = "DELETE FROM Guardado_contrasenas WHERE id=@ID ";
            SqlCommand delet = new SqlCommand(delete, conexion);
            delet.Parameters.AddWithValue("@ID", id);
            delet.ExecuteNonQuery();
            conexion.Close();
        }

        public DataSet olvidado_contrasena_telefono(string telefono)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True");
            SqlCommand recuperar = new SqlCommand("Select * From Usuario WHERE telefono=@cell", conexion);
            recuperar.Parameters.AddWithValue("@cell", telefono);

            conexion.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(recuperar);
            DataSet Cargar = new DataSet();
            adapt.Fill(Cargar);
            conexion.Close();
            return Cargar;
        }
        public DataSet olvidado_contrasena_nombre_apellido(string nombre, string apellido)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True ");
            SqlCommand recuperar = new SqlCommand("Select * From Usuario WHERE (nombre=@nom AND apellido=@apell)", conexion);
            recuperar.Parameters.AddWithValue("@nom", nombre);
            recuperar.Parameters.AddWithValue("@apell", apellido);
            conexion.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(recuperar);
            DataSet Cargar = new DataSet();
            adapt.Fill(Cargar);
            conexion.Close();
            return Cargar;

        }
        public void nueva_contraseña_telefono(string telefono,string contra )
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True ");
            conexion.Open();
            string cambio_datos = "UPDATE Usuario SET  Contrasena=@contraseña WHERE telefono=@cell";
            SqlCommand ejecutar_consulta = new SqlCommand(cambio_datos, conexion);
            ejecutar_consulta.Parameters.AddWithValue("@contraseña", contra);
            ejecutar_consulta.Parameters.AddWithValue("@cell", telefono);
            ejecutar_consulta.ExecuteNonQuery();
            conexion.Close();

        }
        public void nueva_contraseña_nombre_apellido(string nombre,string apellido,string contra)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\delac\Music\generador_contraseña_posiblemente_final\generador_contraseña.02\generador_contraseña\base_datos\Login.mdf;Integrated Security=True ");
            conexion.Open();
            string cambio_datos = "UPDATE Usuario SET  Contrasena=@contraseña WHERE (nombre=@nom AND apellido=@apell) ";
            SqlCommand ejecutar_consulta = new SqlCommand(cambio_datos, conexion);
            ejecutar_consulta.Parameters.AddWithValue("@nom", nombre);
            ejecutar_consulta.Parameters.AddWithValue("@apell", apellido);
            ejecutar_consulta.Parameters.AddWithValue("@contraseña", contra);
            ejecutar_consulta.ExecuteNonQuery();
            conexion.Close();

        }
    }

    }

