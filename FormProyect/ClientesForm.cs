using ClasesInstanciables;
using ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProyect
{
    public partial class ClientesForm : Form
    {
        SqlConnection cnx = new SqlConnection("server=DESKTOP-OG6OM47\\SQLEXPRESS; database=BD2Parcial; integrated security = true");
        public ClientesForm()
        {
            InitializeComponent();
            this.Load += Mostrar;
            this.AgregarBtn.Click += Mostrar;
            this.ModificarBtn.Click += Mostrar;
            this.EliminarBtn.Click += Mostrar;
        }
        private void Mostrar(object sender, EventArgs e)
        {
            List<Cliente> clientes = Sql.GetClientes();
            DGVClientes.DataSource = clientes;
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Sql.AgregarCliente(NombreClienteTxt.Text, int.Parse(DniClienteTxt.Text), DireccionClienteTxt.Text);
            MessageBox.Show("Insertado.");
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            Sql.ModificarCliente(NombreClienteTxt.Text, int.Parse(DniClienteTxt.Text), DireccionClienteTxt.Text, int.Parse(IdClienteTxt.Text));
            MessageBox.Show("Actualizado.");
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            Sql.EliminarCliente(int.Parse(IdClienteTxt.Text));
            MessageBox.Show("Eliminado.");
        }

    }
}
