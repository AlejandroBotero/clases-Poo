using _02_Poo.MedioTransporte;
using _02_Poo.SolucionAlejo.Fabrica.Avion.DataAvion;
using _02_Poo.SolucionAlejo.Transversales;
using _02_Poo.SolucionAlejo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Fabrica.Avion;

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
    private const double PrecioMinimo = 1_000_000;
    private const double PrecioMaximo = 40_000_000;
    private List<int> ObtenerRangosTurbinas() => [2, 3, 4, 6];

    public FabricacionAvion(Rangos rangos, FuncionesTransversales funcionesTransversales)
    {
        _rangos = rangos;
        _funcionesTransversales = funcionesTransversales;
        tipoMarcaAvions = funcionesTransversales.CrearListaAtributoEnum<TipoMarcaAvion>();
        DiccionarioMarcaAviones _diccionarioMarcaAviones = new();
        _marcasYModelosAviones = _diccionarioMarcaAviones.ObtenerTodasMarcaAndModelo();
    }

    //Tarea : Este método podría ser abstracto
    public Vehiculo CrearVehiculo()
    {
        string marca = _funcionesTransversales.ObtenerAtributo(tipoMarcaAvions).ToString();
        List<string> modelos = _marcasYModelosAviones[marca];
        string modelo = _funcionesTransversales.ObtenerAtributo(modelos);
        string color = _funcionesTransversales.ObtenerColores(_rangos.ObtenerColores()).ToString();
        TipoAvion tipoAvion = new(marca, modelo);
        double precio = ObtenerPrecio(tipoAvion);
        MedioTransporte.Avion avion = new(tipoAvion.Marca, color,modelo,2005,4,32, precio);
        return avion;
    }

    private double ObtenerPrecio(TipoAvion tipoAvion)
    {
        if (TipoMarcaAvion.Boeing.Equals(tipoAvion.Marca))
            return _funcionesTransversales.ObtenerDoubleAleatoriamente(PrecioMaximo + PrecioMinimo);
        return _funcionesTransversales.ObtenerDoubleAleatoriamente(PrecioMaximo);
    }

    //private TipoAvion ObtenerMarcaAndModelo()
    //{
    //    var 
    //}


}

