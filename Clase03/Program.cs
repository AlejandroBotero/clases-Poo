// See https://aka.ms/new-console-template for more information
using Clase03;
using Clase03.Operaciones.Contrato;

Console.WriteLine("Hello, World!");
Init();

static void Init()
{
    Calculadora calculadora = new Calculadora();
    
    int a = 2;
    int b = 4;
    

    List<TipoOperacion> tipoOperacions = Enum.GetValues(typeof(TipoOperacion)).Cast<TipoOperacion>().ToList();

    foreach(TipoOperacion operacion in tipoOperacions)
    {
        int resultado = calculadora.EjecutarOperacion(operacion, a, b);
        Console.WriteLine("El resultado de la operacion es : {0}", resultado);
    }


}