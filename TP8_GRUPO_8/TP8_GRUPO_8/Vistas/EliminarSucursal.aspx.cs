using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioSucursal negSuc = new NegocioSucursal();
            int idSucursal = int.Parse(txtIdSucursal.Text);

            switch (negSuc.eliminarSucursal(idSucursal))
            {
                //SE PUDO ELIMINAR
                case 1:
                    lblEliminado.Text = "La sucursal ha sido eliminada";
                    lblEliminado.ForeColor = Color.Green;
                    txtIdSucursal.Text = "";
                    break;
                //NO SE PUDO ELIMINAR
                case -1:
                    lblEliminado.Text = "Hubo un problema para eliminar la sucursal";
                    txtIdSucursal.Text = "";
                    break;
                //NO EXISTE LA SUCURSAL
                case 0:
                    lblEliminado.Text = "La sucursal buscada no existe";
                    txtIdSucursal.Text = "";
                    break;
            }
        }
    }
}