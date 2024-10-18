using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoSucursales
    {
        AccesoDatos ad = new AccesoDatos();
        public DataTable obtenerTablaSucursales()
        {
            string consulta = "Select Id_Sucursal, NombreSucursal,DescripcionSucursal,DescripcionProvincia,DireccionSucursal FROM Sucursal " +
                "inner join Provincia on Sucursal.Id_ProvinciaSucursal = Provincia.Id_Provincia";
            return ad.obtenerTabla("Sucursales", consulta);
        }
        
    }
}
