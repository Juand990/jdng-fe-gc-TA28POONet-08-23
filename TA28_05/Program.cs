using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA28_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serie[] arrSerie = new Serie[5];
            Videojuegos[] arrVideojuegos = new Videojuegos[5];

            Serie s1 = new Serie("uno","uno");
            arrSerie[0]= s1;
            s1 = new Serie("dos", "dos");
            arrSerie[1] = s1;
            s1 = new Serie("tres", 3,"accion","tres");
            arrSerie[2] = s1;
            s1 = new Serie("cuatro", 4, "humor", "cuatro");
            arrSerie[3] = s1;
            s1 = new Serie("cinco", 5, "drama", "cinco");
            arrSerie[4] = s1;
            Videojuegos v1 = new Videojuegos("seis",25);
            arrVideojuegos[0] = v1;
            v1 = new Videojuegos("siete", 25);
            arrVideojuegos[1] = v1;
            v1 = new Videojuegos("ocho", 50);
            arrVideojuegos[2] = v1;
            v1 = new Videojuegos("nueve", 30,"fps", "nueve");
            arrVideojuegos[3] = v1;
            v1 = new Videojuegos("diez", 999, "simulacion", "diez");
            arrVideojuegos[4] = v1;

            arrSerie[1].Entregar();
            arrSerie[3].Entregar();
            arrVideojuegos[0].Entregar();
            arrVideojuegos[2].Entregar();
            arrVideojuegos[4].Entregar();
            int serEnt = 0;
            int vidEnt = 0;
            for (int i = 0; i < arrSerie.Length; i++)
            {
                if (arrSerie[i].IsEntregado())
                {
                    serEnt++;
                }                
            }
            Console.WriteLine("Series entregadas: "+serEnt);
            for (int i = 0; i < arrVideojuegos.Length; i++)
            {
                if (arrVideojuegos[i].IsEntregado())
                {
                    vidEnt++;
                }
            }
            Console.WriteLine("Videojuegos entregados: " + vidEnt);

            Serie ss1 = null;
            for (int i = 0; i < arrSerie.Length; i++)
            {
                if (i == arrSerie.Length - 1)
                {
                    if (arrSerie[i].NumTemporada.CompareTo(arrSerie[0].NumTemporada) == 1)
                    {
                        ss1 = arrSerie[i];
                    }
                }
                else
                {
                    if (arrSerie[i].NumTemporada.CompareTo(arrSerie[i + 1].NumTemporada) == -1)
                    {
                        ss1 = arrSerie[i];
                    }
                }
                
            }
            Console.WriteLine("---------------------");
            ss1.ToString();
            Console.WriteLine("---------------------");
            Videojuegos vd1 = null;

            for (int i = 0; i < arrVideojuegos.Length; i++)
            {
                if (i== arrVideojuegos.Length-1)
                {
                    if (arrVideojuegos[i].HorasEstimadas.CompareTo(arrVideojuegos[0].HorasEstimadas) == 1)
                    {
                        vd1 = arrVideojuegos[i];
                    }
                }
                else
                {
                    if (arrVideojuegos[i].HorasEstimadas.CompareTo(arrVideojuegos[i + 1].HorasEstimadas) == -1)
                    {
                        vd1 = arrVideojuegos[i];
                    }
                }                
            }
            vd1.ToString();

            Console.ReadKey();            
        }
    }
}
