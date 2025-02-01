using Clase03.Operaciones.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Operaciones
{
    public class Division : IOperacion
    {
        public TipoOperacion TipoOperacion => TipoOperacion.Division;

        public int Ejecutar(int a, int b)
        {
            Console.WriteLine($"Dividir : {a} / {b}");
            if(b == 0)
                return 0;
            return a / b;
        }
    }
}
