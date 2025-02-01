using Clase03.Operaciones.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Operaciones
{
    public class Resta : IOperacion
    {
        public TipoOperacion TipoOperacion => TipoOperacion.Resta;
        public int Ejecutar(int a, int b)
        {
            Console.WriteLine($"Resta : {a} - {b}");
            return a - b;
        }
    }
}
