using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase17
{
    class Prueba
    {
        public static void OpTest<T>(T s, T t) where T : class
        {
            System.Console.WriteLine(s == t);
        }

        public void OpTest2<T>(T s, T t) where T : class
        {
            System.Console.WriteLine(s == t);
        }
    }
}
