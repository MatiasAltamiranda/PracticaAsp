using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace PrimerPagina
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["listado"] == null)
                {
                    Session["listado"] = new List<Articulo>();
                }
            }
        }

        protected void enviarArticulo_Click(object sender, EventArgs e)
        {

        
            Articulo nuevo = new Articulo();
            nuevo.nombre = tbNombre.Text;
            nuevo.id = int.Parse(tbID.Text);
            nuevo.codigo = int.Parse(tbCodigo.Text);
            nuevo.direccion = new Direccion();
            nuevo.direccion.Nombre = tbDireccion.Text;
            nuevo.direccion.altura = int.Parse(tbAltura.Text); 

            ((List<Articulo>)Session["listado"]).Add(nuevo);

            Response.Redirect("default.aspx");

        }

       
    }
}