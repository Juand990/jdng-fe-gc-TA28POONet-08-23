using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA28_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices r1 = new Raices(1,2,3);
            r1.GetDiscriminante();
            r1.TieneRaices();
            r1.TieneRaiz();
            r1.Calcular();
            r1.ObtenerRaices();
            r1.ObtenerRaiz();

            Console.ReadKey();
        }
    }
}
