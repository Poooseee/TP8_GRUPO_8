using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ListadoDeSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NegocioSucursal ns = new NegocioSucursal();
                DataTable dt = new DataTable();
                dt = ns.ObtenerTablaSucursales();
                gvSucursales.DataSource = dt;
                gvSucursales.DataBind();
            }
        }
    }
}