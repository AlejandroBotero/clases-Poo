using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Poo.MedioTransporte;

namespace _02_Poo.TipoMedioTranspote
{
    public class TipoVehiculo
    {
        public List<Vehiculo> Vehiculos { get; private set; } = [];

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }

        public void MostrarVehiculos()
        {

        }
    }
}
