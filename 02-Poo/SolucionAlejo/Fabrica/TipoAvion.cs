using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Fabrica
{
    public class TipoAvion
    {
        public TipoAvion(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        
    }
}
