using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Muebles_JJ.Core.Domain;
using System.Data;


namespace Muebles_JJ.Core
{
    public class Prueba
    {
        MySqlConnection AbrirConexion()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection();
                mySqlConnection.ConnectionString = "Server=localhost;Port=3306;Database=star_jj;Uid=root;";
                mySqlConnection.Open();
                return mySqlConnection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ColorProducto> ConsultarProducto()
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection = AbrirConexion();
                DataSet datos = new DataSet();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = mySqlConnection;
                cmd.CommandText = "select * from color_producto";
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(datos);
                List<ColorProducto> listProductos = new List<ColorProducto>();
                if(datos != null)
                {
                    listProductos = Generic.ToList<ColorProducto>(datos.Tables[0]);
                }
                return listProductos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                    mySqlConnection.Dispose();
                }
            }
        }
    }
}
