using System;
using System.Collections.Generic;
using System.Linq;
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
            NegocioArticulo NegocioArticulo = new NegocioArticulo();
            dgvArticulo.DataSource = NegocioArticulo.listar();
            dgvArticulo.DataBind();
        }
    }
}