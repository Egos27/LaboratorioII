using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase17
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseGeneric<int> clase1 = new CaseGeneric<int>();
            
            List<int> listaInt1 = new List<int>();
            //copio la lista de entero en lista copiada
            List<int> listaIntCopiada  = clase1.CopiarLita(listaInt1);
            
            CaseGeneric<Prueba> clase2 = new CaseGeneric<Prueba>();

            List<Prueba> ListaPrueba = new List<Prueba>();
            //copio la lista de Prueba en lista copiada
            List<Prueba> listacopiada = clase2.CopiarLita(ListaPrueba);

            Prueba p = new Prueba();
            p.OpTest2<string>("hola", "chau");
            Prueba.OpTest<Prueba>(p, p);
            

            Console.ReadKey();
        }
    }
}
