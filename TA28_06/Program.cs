using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA28_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro l1 = new Libro("0123","AAAA","SSSS",123);
            Libro l2 = new Libro("4567", "ZZZZ", "VVVV", 323);
            l1.ToString();
            l2.ToString();

            Libro maspaginas=null;

            if (l1.NumPaginas>l2.NumPaginas)
            {
                maspaginas = l1;
            }
            else
            {
                maspaginas = l2;
            }
            Console.WriteLine("Tiene mas paginas: "+ maspaginas.Titulo);


            Console.ReadKey();
        }                
    }
}
