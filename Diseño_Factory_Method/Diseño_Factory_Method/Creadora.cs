using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Factory_Method
{
    //Esta clase sirve para crear objetos 
    class Creadora
    {
        public const int FORDMUSTANG = 200;
        public const int LAMBORGHINIAVENTADOR = 150;
        public static Vehiculo CreadoraVehiculo(int valor) 
        {
            switch (valor) 
            
            {
                case FORDMUSTANG:
                    return new FordMustang();
                    break;
                case LAMBORGHINIAVENTADOR:
                    return new LamborghiniAventador();
                    break;

                default:return null;
            }
        }
    }
}
