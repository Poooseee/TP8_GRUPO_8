using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccesoDatos
    {
        string rutaDB = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security=True";

        private SqlConnection obtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaDB);

            try
            {
                cn.Open();
                return cn;
            }catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter obtenerAdaptador(string consulta , SqlConnection cn)
        {
            SqlDataAdapter adaptador;

            try
            {
                adaptador = new SqlDataAdapter(consulta, cn);
                return adaptador;
            }catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable obtenerTabla(string nombreTabla , string sql)
        {
            SqlConnection cn = obtenerConexion();
            SqlDataAdapter adap = obtenerAdaptador(sql, cn);
            DataSet ds = new DataSet();

            adap.Fill(ds , nombreTabla);
            cn.Close();

            return ds.Tables[nombreTabla];
        }

        public bool existe(string consultaSQL)
        {

            SqlConnection conexion = obtenerConexion();
            SqlCommand comando = new SqlCommand(consultaSQL, conexion);
            SqlDataReader datos = comando.ExecuteReader();
            if (datos.Read())
            {
                return true;
            }
            else { return false; }
        }

        public int EjecutarConsulta(string consultaSQL)
        {
            SqlConnection conn = new SqlConnection(rutaDB);
            conn.Open();
            SqlCommand cmd = new SqlCommand(consultaSQL, conn);
            int filas = cmd.ExecuteNonQuery(); // PARA INSERT-UPDATE-DELETE
            conn.Close();
            return filas;
        }
    }
}
