using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase17
{
    public class MetodoGeneric 
    {

        public static List<T> CopiarLita<T>(List<T> miLista) 
        {
            List<T> nuevaLista=new List<T>();
            foreach(T item in miLista){
                nuevaLista.Add(item);
            }
            return nuevaLista;
        }

    }
}
