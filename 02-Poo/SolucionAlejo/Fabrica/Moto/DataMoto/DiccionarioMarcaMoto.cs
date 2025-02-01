using _02_Poo.SolucionAlejo.Fabrica.Avion.DataAvion;
using _02_Poo.SolucionAlejo.Fabrica.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Fabrica.Moto.DataMoto
{
    public class DiccionarioMarcaMoto : IDiccionarioMarca
    {
        public Dictionary<string, List<string>> ObtenerTodasMarcaAndModelo()
        => new()
            {
                {TipoMarcaMoto.Suzuki.ToString(), new List<string>(){"Avenis 125","DR150"} },
            };
    }
}
