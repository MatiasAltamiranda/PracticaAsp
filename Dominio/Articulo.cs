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
         Articulo articulo2 = new Articulo();
            articulo2.id = 2;
            articulo2.codigo = 22;
            articulo2.nombre = "Computadora";
            lista.Add(articulo);
            lista.Add(articulo2);

            return lista;
        }
    }
}
