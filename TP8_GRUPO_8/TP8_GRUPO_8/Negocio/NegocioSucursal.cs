using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioSucursal
    {
        public NegocioSucursal()
        {

        }

        public DataTable ObtenerTablaSucursales()
        {
            DaoSucursales daoSucursales = new DaoSucursales();
            return daoSucursales.obtenerTablaSucursales();
        }

        public int agregarSucursal(string NombreSucursal, string DescripcionSucursal, int IdProvinciaSucursal, string DireccionSucursal)
        {
            int filas;
            DaoSucursales Ds = new DaoSucursales();
            filas = Ds.AgregarSucursal(NombreSucursal, DescripcionSucursal, IdProvinciaSucursal, DireccionSucursal);
            return filas;
        }
        
        public DataTable buscarSucursalPorID(int idSucursal)
        {
            DaoSucursales daoSucursales=new DaoSucursales();
            return daoSucursales.buscarSucursalPorID(idSucursal);
        }
    }
}
