using Ejercicio4_interfaces.MisInterfacez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_interfaces.MisClases
{
    class Persona : Ipersona
    {
        public string nombre { get; }
        public int edad { get ;  }

        public void cumpliraños()
        {
           
        }
        Persona (string nombre, int edad, int cont)
        {
            this.nombre = "Daniel";
           this. edad = 0;
            this.cont = 1;
        }
        public void DecirMiNombre()
        {
            Console.WriteLine("Hola, un gusto, saludar {0}", nombre);   
        }
    }
}
