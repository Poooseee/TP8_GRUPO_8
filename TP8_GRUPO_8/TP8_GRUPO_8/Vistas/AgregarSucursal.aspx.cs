using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                cargarProvinciasAlDDL();
            }
        }
        private void limpiarCargaSucursal()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            ddlProvincia.SelectedIndex = 0;
            txtDireccion.Text = "";
        }
        public void cargarProvinciasAlDDL()
        {
            NegocioProvincia prov = new NegocioProvincia();
            DataTable dt = new DataTable();
            dt = prov.obtenerTablaProvincias();
            ddlProvincia.DataSource = dt;
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "ID_Provincia";
            ddlProvincia.DataBind();
            ddlProvincia.Items.Insert(0, new ListItem("Seleccione una provincia", "0"));
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int filas;
            NegocioSucursal negSuc = new NegocioSucursal();
            int IdProvincia = int.Parse(ddlProvincia.SelectedValue);
            filas = negSuc.agregarSucursal(txtNombre.Text, txtDescripcion.Text, IdProvincia, txtDireccion.Text);
            if (filas > 0)
            {
                lblMensaje.Text = "Se agrego la sucursal correctamente";
            }
            else lblMensaje.Text = "La sucursal ya existe";
            limpiarCargaSucursal();
        }
    }
}