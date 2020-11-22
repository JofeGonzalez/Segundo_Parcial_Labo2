using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Producto
    {
        private int idProducto;
        private string nombreProducto;

        public Producto(int idProducto, string nombreProducto)
        {
            this.IdProducto = idProducto;
            this.NombreProducto = nombreProducto;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
    }
}
