
using ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Cliente : Persona
    {
        private int idCliente;
        private string direccionCliente;
        public Cliente():base()
        {
        }
        public Cliente(string nombre, int dni, int idCliente, string direccionCliente) : base(nombre, dni)
        {
            this.idCliente = idCliente;
            this.direccionCliente = direccionCliente;
        }
        public Cliente(string nombre, string dni, int idCliente, string direccionCliente) : base(nombre, dni)
        {
            this.idCliente = idCliente;
            this.direccionCliente = direccionCliente;
        }


        public int IdCliente { get => idCliente; set => idCliente =  value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }
    }
}
