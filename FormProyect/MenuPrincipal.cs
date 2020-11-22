using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProyect
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            ClientesForm cForm = new ClientesForm();
            cForm.Show();
        }

        private void VentasBtn_Click(object sender, EventArgs e)
        {
            VentasForm vForm = new VentasForm();
            vForm.Show();
        }

        private void ClientesBtn_MouseEnter(object sender, EventArgs e)
        {
            this.ClientesBtn.BackColor = Color.Green;
        }

        private void ClientesBtn_MouseLeave(object sender, EventArgs e)
        {
            this.ClientesBtn.BackColor = Color.Chocolate;
        }

        private void VentasBtn_MouseEnter(object sender, EventArgs e)
        {
            this.VentasBtn.BackColor = Color.Green;
        }

        private void VentasBtn_MouseLeave(object sender, EventArgs e)
        {
            this.VentasBtn.BackColor = Color.Chocolate;
        }
    }
}
