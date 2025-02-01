using Clase03.Operaciones;
using Clase03.Operaciones.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    public class Calculadora
    {
        private readonly IEnumerable<IOperacion> _operaciones;

        public Calculadora()
        {
            _operaciones = new List<IOperacion>()
            {
                new Division(),
                new Multiplicacion(),
                new Resta(),
                new Suma(),
                new Potenciacion(),
            };
        }

        public int EjecutarOperacion(TipoOperacion tipoOperacion, int a, int b)
        {
            IOperacion operacion = _operaciones.First(x => x.TipoOperacion == tipoOperacion);
            return operacion.Ejecutar(a, b);

        }
    }
}
