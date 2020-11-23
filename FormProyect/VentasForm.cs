using ClasesAbstractas;
using ClasesInstanciables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensiones;

namespace FormProyect
{
    public partial class VentasForm : Form
    {
        List<Venta> ventas;
        List<Venta> ventasEntregadas;
        Local local;
        Thread pedidoFinalizado;

        public VentasForm()
        {
            InitializeComponent();
            this.ventasEntregadas = new List<Venta>();
            this.ventas = Sql.LeerPedidosXml();
            this.Load += LlenarComboBoxProductos;
            this.Load += LlenarComboBoxClientes;
            this.Load += LlenarComboBoxEntrega;
            this.AgregarBtn.Click += MostrarPreparacion;
            this.MouseMove += MostrarPreparacion;

            this.local = new Local();
            this.local.ventaFinalizada += LlenarPedidosFinalizados;
        }
        private void LlenarComboBoxProductos(object sender, EventArgs e)
        {
            List<Producto> productos = Sql.GetProductos();
            foreach (Producto prod in productos)
            {
                ProductosCbx.Items.Add(prod.NombreProducto);
            }
        }
        private void LlenarComboBoxClientes(object sender, EventArgs e)
        {
            List<Cliente> clientes = Sql.GetClientes();
            foreach (Persona clie in clientes)
            {
                ClientesCbx.Items.Add(clie.Nombre);
            }
        }
        private void LlenarComboBoxEntrega(object sender, EventArgs e)
        {
            EntregaCbx.Items.Add(modoEntrega.personal);
            EntregaCbx.Items.Add(modoEntrega.delivery);

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            int idP = Sql.GetIdProducto(ProductosCbx.SelectedItem.ToString());
            int idC = Sql.GetIdCliente(ClientesCbx.SelectedItem.ToString());
            Sql.AgregarVenta(idP, idC, (modoEntrega)EntregaCbx.SelectedItem);
            Venta item = new Venta(idP, idC, (modoEntrega)EntregaCbx.SelectedItem);
            ventas.Add(item);
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            this.pedidoFinalizado = new Thread(new ParameterizedThreadStart(this.local.HiloVenta));
            this.pedidoFinalizado.Start(ventas);
        }
        private void MostrarPreparacion(object sender, EventArgs e)
        {
            DGVPreparacion.DataSource = null;
            DGVPreparacion.DataSource = ventas;
        }
        private void LlenarPedidosFinalizados(Venta venta)
        {
            if (ListBoxFinalizados.InvokeRequired)
            {
                FinalizarVenta fin = new FinalizarVenta(LlenarPedidosFinalizados);
                this.Invoke(fin, new object[] { venta });
            }
            else
            {
                ventasEntregadas.Add(venta);
                ventas.Remove(venta);
                Cliente cliente = Sql.GetDatosCliente(venta.IdCliente);
                ListBoxFinalizados.Items.Add(cliente.Nombre.DevolverString());
            }
        }

        private void VentasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sql.GuardarPedidosXml(ventas);
            if (pedidoFinalizado.IsAlive)
            {
                pedidoFinalizado.Abort();
            }
        }
    }
}