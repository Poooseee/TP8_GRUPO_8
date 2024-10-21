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
        DaoSucursales daoSucursales = new DaoSucursales();
        public DataTable ObtenerTablaSucursales()
        {
            
            return daoSucursales.obtenerTablaSucursales();
        }

        public int agregarSucursal(string NombreSucursal, string DescripcionSucursal, int IdProvinciaSucursal, string DireccionSucursal)
        {
            int filas;
            Sucursal suc = new Sucursal();
            suc.NombreSucursal1 = NombreSucursal;
            suc.DescripcionSucursal1 = DescripcionSucursal;
            suc.IdProvinciaSucursal1 = IdProvinciaSucursal;
            suc.DireccionSucursal1 = DireccionSucursal;
            DaoSucursales Ds = new DaoSucursales();

            //Si no encuentra ninguna sucursal, sigue
            if (!Ds.VerificarSucursal(suc))
            {
                filas = Ds.AgregarSucursal(suc);
                return filas;
            }
            //Si ya existe una sucursal, devuelve 0
            return 0;
        }
        
        public DataTable buscarSucursalPorID(int idSucursal)
        {
            return daoSucursales.buscarSucursalPorID(idSucursal);
        }

        public DataTable buscarSucursalPorProvincia(int idProvincia)
        {
            return daoSucursales.buscarSucursalPorProvincia(idProvincia);
        }

        public int eliminarSucursal(int idSucursal)
        {
            int filas;  
            bool existe = daoSucursales.ExisteSucursal(idSucursal);

            if (existe)
            {
                filas = daoSucursales.eliminarSucursal(idSucursal);

                if(filas == 1)
                {
                    return 1; //SE PUDO ELIMINAR
                }
                else
                {
                    return -1; //NO SE PUDO ELIMINAR
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
