using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA28_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta("aa");
            Cuenta c2 = new Cuenta("as",500);
            c1.Ingresar(200);
            c1.Retirar(300);
            c1.ToString();
            c2.Ingresar(200);
            c2.Retirar(300);
            c2.ToString();
            Console.ReadKey();
        }
    }
}
