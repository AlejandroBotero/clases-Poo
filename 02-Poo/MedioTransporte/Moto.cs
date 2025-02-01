using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.MedioTransporte
{
    public class Moto : Vehiculo
    {
        public Moto(string marca, string color, string modelo, uint anhoFabricacion, int numeroLlantas, double precioVenta) : base(marca, color, modelo, anhoFabricacion, numeroLlantas, precioVenta)
        {
        }

        public override double Acelerar()
        {
            throw new NotImplementedException();
        }
    }
}
