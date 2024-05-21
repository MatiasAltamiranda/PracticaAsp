using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace PrimerPagina
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
                if (Session["listado"] == null)
                {
                    NegocioArticulo negocioArticulo = new NegocioArticulo();
                    Session["listado"] = negocioArticulo.listar();
                }
            

            // Enlaza la lista de artículos a dgvArticulo
            dgvArticulo.DataSource = (List<Articulo>)Session["listado"];
            dgvArticulo.DataBind();
        }

        protected void dgvArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
           var id = dgvArticulo.SelectedDataKey.Value.ToString();
            Response.Redirect("nuevoArticulo.aspx?id=" + id);
        }
    }
}