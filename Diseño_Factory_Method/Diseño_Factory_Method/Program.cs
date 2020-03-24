using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //patron de diseño para crear objetos de clases que Heredan de una clase abstacta
            Vehiculo objvehiculo = Creadora.CreadoraVehiculo(Creadora.LAMBORGHINIAVENTADOR);
            Console.WriteLine("La Velocidad Del Vehiculo Es De "+objvehiculo.velocidad()+" KM/h");
           
            Console.ReadKey();
        }
    }
}
