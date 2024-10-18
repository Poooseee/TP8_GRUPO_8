using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAO
{
    public class DaoProvincias
    {
        public DataTable ObtenerProvincias()
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "SELECT * FROM Provincia";
            return datos.obtenerTabla("Provincias", consulta);
        }
    }
}
