using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Poo.MedioTransporte;
using _02_Poo.SolucionAlejoB;

namespace _02_Poo.SolucionAlejoB
{
    public class VehiculoRandom
    {
        public Vehiculo Generate()
        {
            Random random = new Random();
            TiposVehiculos tiposVehiculos = new();

            var tipos = tiposVehiculos.TiposVehiculosDict;

            int randomTipoIndex = random.Next(tipos.Keys.Count);
            List<string> tiposString = new List<string>(tipos.Keys);

            string Tipo = tiposString[randomTipoIndex]; // first parameter

            var TipoDict = tipos[Tipo];

            int randomMarcaIndex = random.Next(TipoDict.Keys.Count);
            List<string> marcasString = new List<string>(TipoDict.Keys);

            string Marca = marcasString[randomMarcaIndex]; // second parameter

            var modelosList = TipoDict[Marca];

            int randomModeloIndex = random.Next(modelosList.Count);

            string Modelo = modelosList[randomModeloIndex]; // third parameter


            List<string> Colores = new List<string>() {
                "Red",
                "Green",
                "Blue",
                "White",
                "Yellow",
                "Black"
            };
            string Color = Colores[random.Next(Colores.Count)];

            uint Anho = (uint) random.Next(50)+1975;

            int Llantas = (random.Next(2)+1)*2;

            int Precio = (random.Next(10) + 1) * 1000;

            if (Tipo == "Avion")
            {
                int Turbinas = (random.Next(2)+1)*2;
                return new Avion(Marca, Color, Modelo, Anho, Turbinas, Llantas, Precio);
            }
            else if (Tipo == "Carro")
            {
                return new Carro(Marca, Color, Modelo, Anho, Llantas, Precio);
            }else if (Tipo == "Moto")
            {
                return new Moto(Marca, Color, Modelo, Anho, Llantas, Precio);
            }
            else
            {
                return new Bicicleta(Marca, Color, Modelo, Anho, Llantas, Precio);
            }

        }
    }
}
