using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            CalculadoraImp cal = new CalculadoraImp();

            decimal iva = cal.calculariva(1550.00m);
            Assert.AreEqual(294.5m, iva);


           decimal hospedaje = cal.estatal(1890.00m);
            Assert.AreEqual(56.7m, hospedaje);

            decimal total = cal.reserva(1890.00m);
           Assert.AreEqual(2305.8m, total);
        }
    }
}

//** Obtener el IVA a partir del monto de una reserva. 19%
//Obtener el impuesto estatal sobre hospedaje a partir del monto de una reserva
//Obtener el monto total de la reserva (con impuestos incluidos)