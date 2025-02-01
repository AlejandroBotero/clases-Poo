using Clase03.Operaciones.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Operaciones
{
    public class Multiplicacion : IOperacion
    {
        public TipoOperacion TipoOperacion => TipoOperacion.Mutiplicacion;
        public int Ejecutar(int a, int b)
        {
            Console.WriteLine($"Multiplicacion : {a} * {b}");
            return a * b;
        }
    }
}
