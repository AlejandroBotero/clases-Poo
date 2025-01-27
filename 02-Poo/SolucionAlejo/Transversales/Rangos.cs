using _02_Poo.SolucionAlejo.Enums;
using _02_Poo.SolucionAlejo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Transversales
{
    public class Rangos
    {


        private const int AnhoMinimo = 1817;
        private readonly int AnhoActual;
        private readonly FuncionesTransversales _funcionesTransversales;

        public Rangos(FuncionesTransversales funcionesTransversales)
        {
            DateTime dateTime = DateTime.Now;
            AnhoActual = dateTime.Year;
            _funcionesTransversales = funcionesTransversales;
        }

        public List<TiposColores> ObtenerColores() => Enum.GetValues(typeof(TiposColores)).Cast<TiposColores>().ToList();

        //La acotacion de intervalos es responsabilidad de la fabricacion de carros
        public List<uint> ObtenerRangoAnhosFabricacion(int intervaloInicial,int intervaloFinal)
        {
            //Primera Bicicleta : 1817
            //Primer avion comercial 1951
            //PrimerMoto : 1869
            List<uint> rangosdeAnhos = new List<uint>();
            for (int i = AnhoMinimo; i <= AnhoActual; i++)
            {
                rangosdeAnhos.Add((uint)i);
            }

            return rangosdeAnhos;


        }
        //Con el ejercicio de alejo decirle agreguegue bicicletas que solo tienen capacidad de una llanta
        public List<int> ObtenerRangoLlantas()
        {
            return Enumerable.Range(2, 32).ToList();
        }

        //Luego obtener rango de precio en pesos Colombianos, con el paso consumir un servicio para consultar la TRM del mercado
        //Para hacer la conversión entre divisas
        public double ObtenerRangoPrecioDolares(double valorMaximoAleatorio)
        {
            return _funcionesTransversales.ObtenerDoubleAleatoriamente(valorMaximoAleatorio);
        }

        

        

        //Tarea: Una idea : La marca chevrolet tiene el modelo AVEO este lo descontinuaron en el 2014, como evitar que cuando se cree un carro no supere dicho rango
        //Luego se pueden crear solo aviones y bicicletas superiores al 2020, verficando así que algunos modelos no se pueden crear hasta la fecha
        //

        //Quiero obtener el precio de diferentes maneras para cuando sea un avion en específico digamos sea el precio US 1_000_000
        //Otras veces lo quiero entre 500 k y un 1.5 kk de dolares
        //Despues entre 40k y 100 k depende de la marca o algún otro atributo
    }
}
