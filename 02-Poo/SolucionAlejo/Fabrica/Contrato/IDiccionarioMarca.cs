using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Fabrica.Contrato
{
    public interface IDiccionarioMarca
    {
        public Dictionary<string, List<string>> ObtenerTodasMarcaAndModelo();
    }
}
