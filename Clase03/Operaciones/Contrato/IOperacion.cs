using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03.Operaciones.Contrato
{
    public interface IOperacion
    {
        public int Ejecutar(int a, int b);
        public TipoOperacion TipoOperacion { get; }
    }
}
