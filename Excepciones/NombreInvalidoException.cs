using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException() : this("El nombre debe contener solo caracteres.")
        {
        }
        public NombreInvalidoException(string message) : base(message)
        {
        }
    }
}