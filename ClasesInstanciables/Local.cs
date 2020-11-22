using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public delegate void FinalizarVenta(Venta venta);
    public class Local
    {
        public event FinalizarVenta ventaFinalizada;
        private List<Venta> ventas;
        Random random = new Random();
        public Local()
        {
            this.ventaFinalizada += finalizarPedido;
            this.ventas = new List<Venta>();
        }
        public void HiloVenta(object ventaFinalizada)
        {
            List<Venta> ventas = (List<Venta>)ventaFinalizada;
            while (true)
            {
                int ind = random.Next(ventas.Count);
                Thread.Sleep(new Random().Next(4000, 10000));
                if(!object.ReferenceEquals(this.ventaFinalizada, null))
                {
                    this.ventaFinalizada.Invoke(ventas[ind]);
                }
            }
        }
        public void finalizarPedido(Venta venta)
        {   
            this.ventas.Add(venta);
        }
    }
}