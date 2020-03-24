using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoSingleton
{
   public class Singleton
    {

        private static Singleton objeto = null;
        public string msj = "";
        protected Singleton() 
        {
            msj = "Dawrin Marte Mendez (2018-5852)";
        }

        public static Singleton Objeto
        {
            get
            {
                if(objeto == null) 
                
                    objeto = new Singleton();

                    return objeto;
                
            }
        }
    }
}
