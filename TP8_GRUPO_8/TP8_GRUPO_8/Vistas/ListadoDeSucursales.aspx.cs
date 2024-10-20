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
                cargarTodasLasSucursales();
            }
        }
        public void cargarTodasLasSucursales()
        {
            NegocioSucursal ns = new NegocioSucursal();
            DataTable dt = new DataTable();
            dt = ns.ObtenerTablaSucursales();
            gvSucursales.DataSource = dt;
            gvSucursales.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtSucursal.Text.Trim().Length > 0)
            {
                int id = int.Parse(txtSucursal.Text);

                NegocioSucursal negocioSucursal = new NegocioSucursal();
                DataTable dt = new DataTable();

                dt = negocioSucursal.buscarSucursalPorID(id);
                gvSucursales.DataSource = dt;
                gvSucursales.DataBind();

                txtSucursal.Text = "";
            }
        }

        protected void btnTodos_Click(object sender, EventArgs e)
        {
            cargarTodasLasSucursales();
           
        }
    }
}