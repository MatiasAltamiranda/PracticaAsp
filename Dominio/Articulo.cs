using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }
        public int codigo { get; set; }

        public string nombre { get; set; }

        public Direccion direccion { get; set; }

        public bool importado { get; set; }
    }

    public class NegocioArticulo
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo articulo = new Articulo();
            articulo.id = 1;
            articulo.codigo = 11;
            articulo.nombre = "Telefono";
            articulo.direccion = new Direccion();
            articulo.direccion.Nombre = "España";
            articulo.direccion.altura = 1930;
            articulo.importado = true;
            Articulo articulo2 = new Articulo();
            articulo2.id = 2;
            articulo2.codigo = 22;
            articulo2.nombre = "Computadora";
            articulo2.direccion = new Direccion();
            articulo2.direccion.Nombre = "Avellaneda";
            articulo2.direccion.altura = 632;
            articulo2.importado = false;
            lista.Add(articulo);
            lista.Add(articulo2);

            return lista;
        }
    }
}
