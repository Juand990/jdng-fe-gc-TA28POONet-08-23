using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA28_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Espectador[,] asientos = new Espectador[8, 8];
            Peliculas p1 = new Peliculas("pelicula1", 120, 18, "sss");
            Cine c1 = new Cine(p1, 10);
            Espectador e1 = null;
            List<Espectador> list = new List<Espectador>();

            string nombre = "qwertyuiopasdfghjklñzxcvbnm";
            int pos = 0;

            for (int i = 0; i < 30; i++)
            {
                pos = rnd.Next(0, nombre.Length - 1);
                e1 = new Espectador(nombre[pos].ToString(), rnd.Next(10, 50), rnd.Next(5, 50));
                if (e1.Dinero >= c1.Precio && e1.Edad >= p1.EdadMinima)
                {
                    list.Add(e1);
                }
            }
            for (int i = 0; i < list.Count;)
            {
                int fila = rnd.Next(0, 8);
                int columna = rnd.Next(0, 8);
                if (asientos[fila,columna]==null)
                {
                    asientos[fila, columna] = list[i];
                    i++;
                }
            }


            for (int fila = 0; fila < 8; fila++)
            {
                for (int columnas = 0; columnas < 8; columnas++)
                {
                    if (asientos[fila, columnas] != null)
                    {
                        //Console.Write("OCUPADO ");
                        Console.Write(asientos[fila, columnas].Nombre+" ");
                    }
                    else
                    {
                        Console.Write("VACIO ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
