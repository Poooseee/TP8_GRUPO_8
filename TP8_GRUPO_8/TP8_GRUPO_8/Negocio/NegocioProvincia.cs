using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace Negocio
{
    public class NegocioProvincia
    {
        public DataTable obtenerTablaProvincias()
        {
        DaoProvincias dao = new DaoProvincias();
            return dao.ObtenerProvincias();
        }

    }
}
