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

        public int AgregarSucursal(string NombreSucursal, string DescripcionSucursal, int IdProvinciaSucursal, string DireccionSucursal)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            string consultaAgregarSucursal = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) " +
               "VALUES ('" + NombreSucursal + "','" + DescripcionSucursal + "'," + IdProvinciaSucursal + ",'" + DireccionSucursal + "')";
            return accesoDatos.EjecutarConsulta(consultaAgregarSucursal);
        }

        public DataTable buscarSucursalPorID(int idSucursal)
        {
            AccesoDatos ad = new AccesoDatos();
            string consulta = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE," +
                "DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal" +
                " WHERE Id_Sucursal = " + idSucursal;

            return ad.obtenerTabla("gvSucursales", consulta);
        }
    }
}
