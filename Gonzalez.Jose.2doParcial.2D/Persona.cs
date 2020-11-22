using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        private string nombre;
        private int dni;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }
        public int DNI
        {
            get { return dni; }
            set { this.dni = ValidarDni(value); }
        }
        public string StringToDNI
        {
            set { this.dni = ValidarDni(value); }
        }
        public Persona()
        {
        }
        public Persona(string nombre)
        {
            this.Nombre = nombre;

        }
        public Persona(string nombre, int dni) : this(nombre)
        {
            this.DNI = dni;
        }
        public Persona(string nombre, string dni) : this(nombre)
        {
            this.StringToDNI = dni;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Nombre: {this.Nombre}"));
            sb.AppendLine(string.Format($"Dni: {this.DNI}"));
            return sb.ToString();
        }
        public static int ValidarDni(int dato)
        {
            if (dato < 1 || dato > 99999999)
            {
                throw new DniInvalidoException();
            }
            return dato;
        }
        public static int ValidarDni(string dato)
        {
            if (!int.TryParse(dato, out int dni))
            {
                throw new DniInvalidoException();
            }
            else
            {
                return ValidarDni(dni);
            }
        }
        public static string ValidarNombreApellido(string dato)
        {
            foreach (char item in dato)
            {
                if (!(char.IsLetter(item)) || char.IsWhiteSpace(item))
                {
                    return null;
                }
            }
            return dato;
        }
    }
}
