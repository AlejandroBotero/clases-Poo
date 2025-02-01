using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejoB
{
    public class TiposVehiculos
    {
        public static Dictionary<string, List<string>> MarcasAvion = new Dictionary<string, List<string>>
        {
            { "Boing", new List<string>{"747", "757", "787 Dreamliner" } },
            { "Airbus", new List<string> { "A220", "A320 Family" } }
        };

        public static Dictionary<string, List<string>> MarcasCarro = new Dictionary<string, List<string>>
        {
            { "Ford", new List<string>{ "Taurus", "Explorer", "F-150", "Mustang" } },
            { "Tesla", new List<string> { "S", "3", "X", "Y" } }
        };

        public static Dictionary<string, List<string>> MarcasBicicleta = new Dictionary<string, List<string>>
        {
            { "Gw", new List<string>{ "Alligator", "Flama", "Lynx" } },
            { "Specialized", new List<string> { "Stumpjumper", "Epic", "Enduro", "Rockhopper" } }
        };
        public static Dictionary<string, List<string>> MarcasMoto = new Dictionary<string, List<string>>
        {
            { "bajaj", new List<string>{ "boxerh", "pulsar", "discover" } },
            { "honda", new List<string> { "gn", "Epic", "Enduro", "Rockhopper" } }
        };


        public Dictionary<string ,Dictionary<string, List<string>>> TiposVehiculosDict = new Dictionary<string, Dictionary<string, List<string>>>
        {
            {"Avion", MarcasAvion },
            { "Carro", MarcasCarro },
            { "Bicicleta", MarcasBicicleta },
            {"Moto" , MarcasMoto }
        };

    }
}
