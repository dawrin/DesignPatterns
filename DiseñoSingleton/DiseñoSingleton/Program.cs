using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Singleton.Objeto.msj);
            Singleton.Objeto.msj = "Utilizando el patron de diseño Singleton";
            Console.WriteLine(Singleton.Objeto.msj);
            Console.ReadKey();
        }
    }
}
