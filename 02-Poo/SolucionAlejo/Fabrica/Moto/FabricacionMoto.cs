using _02_Poo.SolucionAlejo.Fabrica.Avion.DataAvion;
using _02_Poo.SolucionAlejo.Fabrica.Contrato;
using _02_Poo.SolucionAlejo.Fabrica.Moto.DataMoto;
using _02_Poo.SolucionAlejo.Transversales;
using _02_Poo.SolucionAlejo.Utils;


namespace _02_Poo.SolucionAlejo.Fabrica.Moto
{
    public class FabricacionMoto : FabricaVehiculo
    {
        private readonly Rangos _rangos;
        private readonly FuncionesTransversales _funcionesTransversales;
        private readonly List<TipoMarcaMoto> tipoMarcaAvions;
        private readonly Dictionary<string, List<string>> _marcasYModelosMotos
            ;
        private const double PrecioMinimo = 1_000;
        private const double PrecioMaximo = 1_000_000;


        public FabricacionMoto(Rangos rangos, FuncionesTransversales funcionesTransversales)
        {
            _rangos = rangos;
            _funcionesTransversales = funcionesTransversales;
            tipoMarcaAvions = funcionesTransversales.CrearListaAtributoEnum<TipoMarcaMoto>();
            IDiccionarioMarca _diccionarioMarcaAviones = new DiccionarioMarcaMoto();
            _marcasYModelosMotos = _diccionarioMarcaAviones.ObtenerTodasMarcaAndModelo();
        }
    }
}
