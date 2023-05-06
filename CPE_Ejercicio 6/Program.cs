using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE_Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec1 = new Rectangulo("Rectangulo 1", 10, 20);
            Circulo cir1 = new Circulo("Circulo 1", 20);

            Console.WriteLine(rec1.ToString());
            Console.WriteLine(cir1.ToString());
            Console.ReadKey();
        }
    }
}
