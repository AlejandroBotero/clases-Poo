using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Poo.SolucionAlejo.Enums;

namespace _02_Poo.MedioTransporte
{
    public class Avion : Vehiculo
    {
        public double Altura { get; private set; } = 0;
        public int Turbinas { get;}

        

        public Avion(string marca, string color, string modelo, uint anhoFabricacion, int turbinas,int numeroLlantas, double precioVenta) 
            : base(marca, color, modelo, anhoFabricacion, numeroLlantas, precioVenta)
        {
            Turbinas = turbinas;
        }

        public override double Acelerar()
        {
            Velocidad += 200;
            return Velocidad;
        }
    }
}
