using _02_Poo.MedioTransporte;
using _02_Poo.SolucionAlejo.Fabrica.Avion;
using _02_Poo.SolucionAlejo.Fabrica.DataAvion;
using _02_Poo.SolucionAlejo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Fabrica;

// TODO con patrones de diseño de estartegía se podría convivir este comportamiento con el  modelo con la base de datos
//Ir separando lógica de datos con el modelo de datos
//Ir separando lógica de aplicacion casos de uso con lógica de negocio o core del sistema
//Verificnado las operaciones más inmutables y la lógica menos cambiante
public class FabricacionAvion : FabricaVehiculo
{
    private readonly Rangos _rangos;
    private readonly FuncionesTransversales _funcionesTransversales;
    private readonly List<TipoMarcaAvion> tipoMarcaAvions;
    private readonly Dictionary<string, List<string>> _marcasYModelosAviones;
    private List<int> ObtenerRangosTurbinas() => [2, 3, 4, 6];

    public FabricacionAvion(Rangos rangos, FuncionesTransversales funcionesTransversales)
    {
        _rangos = rangos;
        _funcionesTransversales = funcionesTransversales;
        tipoMarcaAvions = funcionesTransversales.CrearListaAtributoEnum<TipoMarcaAvion>();
        DiccionarioMarcaAviones _diccionarioMarcaAviones = new();
        _marcasYModelosAviones = _diccionarioMarcaAviones.ObtenerTodasMarcaAndModelo();
    }




    //private TipoAvion ObtenerMarcaAndModelo()
    //{
    //    var 
    //}


}

