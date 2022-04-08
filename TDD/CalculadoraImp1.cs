using System;

namespace TDD
{
    internal class CalculadoraImp
    {
        public decimal calculariva(decimal monto)
        {
            return 0.19m * monto;
        }

        public decimal estatal(decimal monto)
        {
            return 0.03m * monto;
        }

        public decimal reserva(decimal monto)
        {
            return (0.19m * monto) + (0.03m * monto) + monto;
        }
    }
}