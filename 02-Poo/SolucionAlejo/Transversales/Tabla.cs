using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Poo.SolucionAlejo.Transversales
{
    public class Tabla
    {
        public void DibujarTabla()
        {
            var table = new ConsoleTable("one", "two", "three");
            table.AddRow(1, 2, 3)
            .AddRow("this line should be longer", "yes it is", "oh");

            table.Write();
            Console.WriteLine();
        }
    }
}
