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
            DataSet ds = new DataSet();
            SqlConnection cn = obtenerConexion();
            SqlDataAdapter adap = obtenerAdaptador(sql, cn);

            adap.Fill(ds , nombreTabla);
            cn.Close();

            return ds.Tables[nombreTabla];
        }
    }
}
