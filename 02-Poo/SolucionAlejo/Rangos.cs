using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Poo.SolucionAlejo.Enums;

namespace _02_Poo.SolucionAlejo
{
    public class Rangos
    {
        public int[] RangossAnhos = [.. Enumerable.Range(1500, 2025)];
        public TiposColores[] RangoColores = (TiposColores[])Enum.GetValues(typeof(TiposColores));
        public TiposVehiculos[] RangoVehiculos = (TiposVehiculos[])Enum.GetValues(typeof(TiposVehiculos));



    }
}
