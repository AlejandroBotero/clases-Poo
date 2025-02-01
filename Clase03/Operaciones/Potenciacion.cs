using Clase03.Operaciones.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Operaciones
{
    public class Potenciacion : IOperacion
    {
        public TipoOperacion TipoOperacion => TipoOperacion.Potenciacion;

        public int Ejecutar(int a, int b)
        {
            Console.WriteLine($"Potenciacion : {a} ^ {b}");
            return (int)Math.Pow(a, b);
        }
    }
}
