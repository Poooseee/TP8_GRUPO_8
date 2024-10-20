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

        public int eliminarSucursal(int idSucursal)
        {
            string sql = "SELECT 1 FROM NombreDeLaTabla WHERE IdSucursal = " + idSucursal;

            int filas;
            AccesoDatos ad = new AccesoDatos();
            DaoSucursales ds = new DaoSucursales();

            bool existe = ad.existe(sql);

            if (existe)
            {
                filas = ds.eliminarSucursal(idSucursal);

                if(filas == 1)
                {
                    return 1; //SE PUDO ELIMINAR
                }
                else
                {
                    return 0; //NO SE PUDO ELIMINAR
                }
            }
            else
            {
                //NO EXISTE UNA SUCURSAL CON ESE ID
                return 0;
            }
        }
    }
}
