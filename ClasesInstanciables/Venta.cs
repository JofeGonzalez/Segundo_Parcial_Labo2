using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public enum modoEntrega
    {
        personal, delivery
    }
    public class Venta
    {
        private int idProducto;
        private int idCliente;
        private modoEntrega modoEntrega;
        public Venta()
        {
        }
        public Venta(int idProducto, int idCliente, modoEntrega modoEntrega)
        {
            this.IdProducto = idProducto;
            this.IdCliente = idCliente;
            this.ModoEntrega = modoEntrega;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public modoEntrega ModoEntrega { get => modoEntrega; set => modoEntrega = value; }
    }
}
