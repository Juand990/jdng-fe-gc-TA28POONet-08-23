using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA28_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce la Edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el Sexo:");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el Peso:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la Altura");
            int altura = int.Parse(Console.ReadLine());
            Persona p1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona p2 = new Persona(nombre, edad, sexo);
            Persona p3 = new Persona();
            p3.Nombre = nombre;
            p3.Edad = edad;
            p3.Sexo = sexo;
            p3.Peso = peso;
            p3.Altura = altura;
            Console.WriteLine("------------------");
            MsjImc(p1);
            MsjImc(p2);
            MsjImc(p3);
            Console.WriteLine("------------------");            
            p1.EsMayorEdad();
            p2.EsMayorEdad();
            p3.EsMayorEdad();
            Console.WriteLine("------------------");
            p1.toString();
            p2.toString();
            p3.toString();
            Console.WriteLine("------------------");
            Console.ReadKey();
        }

        private static void MsjImc(Persona p)
        {
            int imc = p.CalcularIMC();

            if (imc < 0)
            {
                Console.WriteLine("Peso IDEAL");
            }
            else
            {
                if (imc==0)
                {
                    Console.WriteLine("BAJO peso");
                }
                else
                {
                    Console.WriteLine("Peso ALTO");
                }
            }
        }
    }
}
