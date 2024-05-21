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

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Articulo> list = (List<Articulo>)Session["listado"];
                Articulo seleccionado = list.Find(a => a.id == id);
                tbID.Text = seleccionado.id.ToString();
                tbNombre.Text = seleccionado.nombre;
                tbCodigo.Text = seleccionado.codigo.ToString();
                tbDireccion.Text = seleccionado.direccion.Nombre;
                tbAltura.Text = seleccionado.direccion.altura.ToString();

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