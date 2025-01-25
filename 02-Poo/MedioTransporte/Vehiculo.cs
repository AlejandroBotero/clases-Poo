using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Poo.SolucionAlejo.Enums;

namespace _02_Poo.MedioTransporte
{
    public abstract class Vehiculo
    {
         
        public Vehiculo(string marca, string color, string modelo, uint anhoFabricacion, int numeroLlantas, double precioVenta)
        {
            Marca = marca;
            Color = color;
            Modelo = modelo;
            AnhoFabricacion = anhoFabricacion;
            NumeroLlantas = numeroLlantas;
            PrecioVenta = precioVenta;
        }

        public string Marca { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public uint AnhoFabricacion { get; set; }
        public double Velocidad { get; protected set; } = 0;
        public int NumeroLlantas { get; }
        public double PrecioVenta { get;}

        public override string ToString()
        {
            return $"Atributos del {this.GetType().Name}: {Marca}, {Color}, {Modelo}";
            //Reemplazar el carro
        }

        public abstract double Acelerar();
    }
}
