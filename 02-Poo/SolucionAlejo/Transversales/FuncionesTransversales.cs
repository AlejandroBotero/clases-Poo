using _02_Poo.SolucionAlejo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Utils
{
    public class FuncionesTransversales
    {
        public int GetIndex(int count) 
        {
            Random rnd = new Random();
            int index = (int)Math.Floor(rnd.NextDouble() * (count-1));
            return index ;
        }

        public double ObtenerDoubleAleatoriamente(double rangoPrecio)
        {
            Random rnd = new Random();
            return Math.Floor(rnd.NextDouble() * rangoPrecio);

        }

        public string ObtenerMarca(List<string> marcas)
        {
            return marcas[GetIndex(marcas.Count)];
        }

        public TiposColores ObtenerColores(List<TiposColores> colores)
        {
            int index = GetIndex(colores.Count);
            return colores[index];
        }

        public string ObtenerModelo(List<string> modelos)
        {
            return modelos[GetIndex(modelos.Count)];
        }

        public uint ObtenerAnhoFabricacion(List<uint> anhoFabricacions)
        {
            return anhoFabricacions[GetIndex(anhoFabricacions.Count)];
        }

        //TODO: Acá veremos el ceonpto de interfaz en la próxima clase para acotar nuestro problema, segregación de interfaces
        //Cuarto principio Solid y así no violar el principio de responsabilidad única
        public int ObtenerTurbina(List<int> turbinas)
        {
            return turbinas[GetIndex(turbinas.Count)];
        }

        public int ObtenerNumeroLlantas(List<int> numerosLlantas)
        {
            return numerosLlantas[GetIndex(numerosLlantas.Count)];
        }

        public double ObtenerPrecioVenta(List<double> precioVentas)
        {
            return precioVentas[GetIndex(precioVentas.Count)];
        }
        //Este código se puede evidenciar que es repetitivo

        //se Podría utilizar una abstracción : Tarea revisar sobre genéricos

        public T ObtenerAtributo<T>(List<T> elemenst)
        {
            return elemenst[GetIndex(elemenst.Count)];
        }

        //Tarea: Mas adelante agregar validaciones para reglas de negocio y que el tipo T sea enum o utilizar un where
        //acá un ejemplo https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/where-generic-type-constraint
        //O este método pueda ser utilizado como método de extensión
        public List<T> CrearListaAtributoEnum<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }
    }
}
