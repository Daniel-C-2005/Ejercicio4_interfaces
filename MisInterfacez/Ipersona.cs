using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_interfaces.MisInterfacez
{
    interface Ipersona
    {
        String nombre { get;  }
        int edad { get; }
        void DecirMiNombre();
        void cumpliraños(); 

    }
}
