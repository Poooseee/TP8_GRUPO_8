using Entidades;
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
        public bool ExisteSucursal(int id)
        {
            return ad.existe("SELECT * FROM Sucursal WHERE Id_Sucursal = " + id);
        }

        public int AgregarSucursal(Sucursal suc)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            string consultaAgregarSucursal = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) " +
               "VALUES ('" + suc.NombreSucursal1 + "','" + suc.DescripcionSucursal1 + "'," + suc.IdProvinciaSucursal1 + ",'" + suc.DireccionSucursal1 + "')";
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

        public int eliminarSucursal(int idSucursal)
        {
            AccesoDatos ad = new AccesoDatos();

            string consulta = "DELETE FROM Sucursal WHERE Id_Sucursal = " + idSucursal;
            return ad.EjecutarConsulta(consulta);
        }
    }
}
