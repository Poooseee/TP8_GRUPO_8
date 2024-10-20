﻿using DAO;
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
            Sucursal suc = new Sucursal();
            suc.NombreSucursal1 = NombreSucursal;
            suc.DescripcionSucursal1 = DescripcionSucursal;
            suc.IdProvinciaSucursal1 = IdProvinciaSucursal;
            suc.DireccionSucursal1 = DireccionSucursal;
            DaoSucursales Ds = new DaoSucursales();
            filas = Ds.AgregarSucursal(suc);
            return filas;
        }
        
        public DataTable buscarSucursalPorID(int idSucursal)
        {
            DaoSucursales daoSucursales=new DaoSucursales();
            return daoSucursales.buscarSucursalPorID(idSucursal);
        }

        public int eliminarSucursal(int idSucursal)
        {
            int filas;  
            DaoSucursales ds = new DaoSucursales();
            bool existe = ds.ExisteSucursal(idSucursal);

            if (existe)
            {
                filas = ds.eliminarSucursal(idSucursal);

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
