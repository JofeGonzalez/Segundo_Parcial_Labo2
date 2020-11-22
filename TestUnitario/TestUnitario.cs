using System;
using ClasesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalidoException()
        {
            Cliente cliente = new Cliente("Jofe", "HolaMundo", 25, "La Luna");
        }
        //[TestMethod]
        //[ExpectedException(typeof(NombreInvalidoException))]
        //public void NombreInvalidoException()
        //{
        //    Cliente cliente = new Cliente("Jose Gonzalez 25", 95959706, 25, "Marte");
        //}
    }
}
