
using _02_Poo.MedioTransporte;
using _02_Poo.SolucionAlejoB;

Init();

static void Init()
{
    VehiculoRandom vehiculoRandom = new();
    for (int i = 0; i < 10; i++)
    {
    Vehiculo Car = vehiculoRandom.Generate();
    Console.WriteLine(Car.ToString());
    }
}

//Init();
//static void Init()
//{
//    //Vehiculo avion = new Avion(marca :"Boing",
//    //    color: "blanco",
//    //    modelo :"747",
//    //    anhoFabricacion: 2025,
//    //    turbinas: 4,
//    //    numeroLlantas: 10,
//    //    precioVenta: 1_000_000);
//    //Vehiculo carro = new Carro("Mazda", "blanco", "CX-30", 2025, 4, 40_000);
//    //Vehiculo bicicleta = new Bicicleta("BMX", "blanco", "TD", 2025, 2, 1_000);

//    //TipoVehiculo tipoVehiculo = new TipoVehiculo();
//    //tipoVehiculo.AgregarVehiculo(avion);
//    //tipoVehiculo.AgregarVehiculo(carro);
//    //tipoVehiculo.AgregarVehiculo(bicicleta);

//    Vehiculo generateRandomVehiclebad()
//    {
//        Random rnd = new Random();  
//        int typeIndex = (int)Math.Floor(rnd.NextDouble() * 3);
//        int ColorIndex = (int)Math.Floor(rnd.NextDouble() * 3);
//        uint RandomAnho = (uint)Math.Floor(rnd.NextDouble() * 20 ) +2000;
//        int RandomLlantas = (int)Math.Floor(rnd.NextDouble() * 2) * 2 + 2;
//        int RandomPrecio = (int)Math.Floor(rnd.NextDouble() * 2000);
//        List<string> marcas;
//        string marcaRandom;
//        List<string> tipos = new List<string>() { "Avion", "Carro", "bicicleta" };
//        List<string> colores = new List<string> { "blanco", "rojo", "negro", "azul" };

//        string tipoRandom = tipos[typeIndex];
//        string colorRandom = colores[ColorIndex];
//        if (tipoRandom == tipos[0])
//        {
//            int RandomTurbinas = (int)Math.Floor(rnd.NextDouble() * 2) * 2 * 2;
//            marcas = new List<string> { "Boing", "Airbus" };
//            marcaRandom = marcas[(int)Math.Floor(rnd.NextDouble() * marcas.Count)];
//            if (marcaRandom == marcas[0])
//            {
//                List<string> modelos = new List<string>() { "747", "737", "767" };
//                int modeloIndex = (int)Math.Floor(rnd.NextDouble() * modelos.Count);
//                string modeloRandom = modelos[modeloIndex];
//                return new Avion(marcaRandom, colorRandom, modeloRandom, RandomAnho, RandomTurbinas, RandomLlantas, RandomPrecio);
//            }
//            else if (marcaRandom == marcas[1])
//            {
//                List<string> modelos = new List<string>() { "A220", "A230" };
//                int modeloIndex = (int)Math.Floor(rnd.NextDouble() * modelos.Count);
//                string modeloRandom = modelos[modeloIndex];
//                return new Avion(marcaRandom, colorRandom, modeloRandom, RandomAnho, RandomTurbinas, RandomLlantas, RandomPrecio);
//            }
//        }
//        else if (tipoRandom == tipos[1])
//        {
//            marcas = new List<string>() { "Ford", "Bmw", "Toyota" };
//            marcaRandom = marcas[(int)Math.Floor(rnd.NextDouble() * marcas.Count)];
//            if (marcaRandom == marcas[0])
//            {
//                List<string> modelos = new List<string>() { "747", "737", "767" };
//                int modeloIndex = (int)Math.Floor(rnd.NextDouble() * modelos.Count);
//                string modeloRandom = modelos[modeloIndex];
//                return new Carro(marcaRandom, colorRandom, modeloRandom, RandomAnho, RandomLlantas, RandomPrecio);
//            }
//            else if (marcaRandom == marcas[1])
//            {
//                List<string> modelos = new List<string>() { "A220", "A230" };
//                int modeloIndex = (int)Math.Floor(rnd.NextDouble() * modelos.Count);
//                string modeloRandom = modelos[modeloIndex];
//                return new Carro(marcaRandom, colorRandom, modeloRandom, RandomAnho, RandomLlantas, RandomPrecio);
//            }
//        }
//        else 
//        {
//            marcas = new List<string>() { "Specialized", "DW" };
//            marcaRandom = marcas[(int)Math.Floor(rnd.NextDouble() * marcas.Count)];
//            if (marcaRandom == marcas[0])
//            {
//                List<string> modelos = new List<string>() { "Stumpjumper", "Rockhopper" };
//                int modeloIndex = (int)Math.Floor(rnd.NextDouble() * modelos.Count);
//                string modeloRandom = modelos[modeloIndex];
//                return new Bicicleta(marcaRandom, colorRandom, modeloRandom, RandomAnho, RandomLlantas, RandomPrecio);
//            }
//            else if (marcaRandom == marcas[1])
//            {
//                List<string> modelos = new List<string>() { "A220", "A230" };
//                int modeloIndex = (int)Math.Floor(rnd.NextDouble() * modelos.Count);
//                string modeloRandom = modelos[modeloIndex];
//                return new Bicicleta(marcaRandom, colorRandom, modeloRandom, RandomAnho, RandomLlantas, RandomPrecio);
//            }


//        }
//        return null;
//    }

//    List<Vehiculo> vehiculos = new List<Vehiculo>();
//    List<List<Vehiculo>> vehiculosOrdenados = new List<List<Vehiculo>>();

//    for (int i = 0; i < 50; i++)
//    {
//        vehiculos.Add(generateRandomVehicle());
//    }

//    List<Vehiculo> aviones = new List<Vehiculo>();
//    List<Vehiculo> carros = new List<Vehiculo>();
//    List<Vehiculo> bicicletas = new List<Vehiculo>();

//    vehiculosOrdenados.Add(aviones);
//    vehiculosOrdenados.Add(carros);
//    vehiculosOrdenados.Add(bicicletas);

//    foreach (Vehiculo vehiculo in vehiculos)
//    {
//        if (vehiculo == null) { continue; }
//        if (vehiculo.GetType().Name == "Avion")
//        {
//            aviones.Add(vehiculo);
//        } else if (vehiculo.GetType().Name == "Carro")
//        {
//            carros.Add(vehiculo);
//        }
//        else
//        {
//            bicicletas.Add(vehiculo);
//        }
//    }
//    foreach (var list in vehiculosOrdenados)
//    {
//        foreach (var vehiculo in list)
//        {
//            Console.WriteLine(vehiculo.ToString());
//        }
//        Console.WriteLine();
//    }
//}
