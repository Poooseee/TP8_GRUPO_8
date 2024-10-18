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
    }
}
