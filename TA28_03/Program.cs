using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TA28_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tamaño del array:");
            int tamaño=int.Parse(Console.ReadLine());
            Password[] arrPass = new Password[tamaño];
            bool[] arrBool = new bool[tamaño];
            Console.WriteLine("Longitud del la contraseña para cada Objeto");
            int longitud=int.Parse(Console.ReadLine());
            for (int i = 0; i < arrPass.Length; i++)
            {
                arrPass[i] = new Password(longitud);
                arrBool[i] = arrPass[i].EsFuerte();
                Console.WriteLine(arrPass[i].Contraseña + ": " + arrBool[i]);
            }

            Console.ReadKey();
        }
    }
}
