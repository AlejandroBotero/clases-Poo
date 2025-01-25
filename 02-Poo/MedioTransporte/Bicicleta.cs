using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.MedioTransporte
{
    public class Bicicleta : Vehiculo
    {
        public Bicicleta(string marca, string color, string modelo, uint anhoFabricacion, int numeroLlantas, double precioVenta) : base(marca, color, modelo, anhoFabricacion, numeroLlantas, precioVenta)
        {
        }

        public override double Acelerar()
        {
            Velocidad += 2;
            return Velocidad;
        }
    }
}
