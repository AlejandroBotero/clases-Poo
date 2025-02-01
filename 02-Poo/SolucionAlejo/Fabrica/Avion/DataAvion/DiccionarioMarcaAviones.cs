using _02_Poo.SolucionAlejo.Fabrica.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Fabrica.Avion.DataAvion
{
    public class DiccionarioMarcaAviones : IDiccionarioMarca
    {

        //ESto se hace acá para separar lógica del dominio de los datos
        //Más adelante toda esta lógica de datos se debe llevar a una base de datos SQl Server

        //Cuando pinte la data quiero ver algo como esto en la tabla: Airbus A320
        public Dictionary<string, List<string>> ObtenerTodasMarcaAndModelo()
            => new()
            {
                {TipoMarcaAvion.Airbus.ToString(), new List<string>(){"A320","A380", "A319"} },
                {TipoMarcaAvion.Boeing.ToString(), new List<string>(){"737","747", "777","787"} },
                {TipoMarcaAvion.Bombardier.ToString(), new List<string>(){"415","Challenger 300"} }
            };

    }
}
