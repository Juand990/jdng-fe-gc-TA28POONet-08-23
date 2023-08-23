using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA28_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiantes> listEstudiantes = new List<Estudiantes>();
            Profesores pr1 = new Profesores("qqq", 45, "hombre", "matematicas");
            Estudiantes est1 = new Estudiantes("aa", 18, "hombre", 6);
            listEstudiantes.Add(est1);
            est1 = new Estudiantes("ss", 19, "hombre", 3);
            listEstudiantes.Add(est1);
            est1 = new Estudiantes("dd", 20, "mujer", 9);
            listEstudiantes.Add(est1);
            est1 = new Estudiantes("ff", 17, "hombre", 4);
            listEstudiantes.Add(est1);
            est1 = new Estudiantes("gg", 18, "mujer", 7);
            listEstudiantes.Add(est1);
            Aula p1 = new Aula(1, 5, "matematicas", pr1, listEstudiantes);
            bool hayClase = false;
            int estQueFaltan = 0;
            
            if (!pr1.noVienenHoy())
            {
                hayClase = true;
                if (hayClase)
                {
                    for (int i = 0; i < listEstudiantes.Count; i++)
                    {
                        if (listEstudiantes[i].noVienenHoy())
                        {
                            estQueFaltan++;
                        }
                    }
                    if ((p1.MaxEstudiantes / 2) + 1 <= estQueFaltan)
                    {
                        Console.WriteLine("Ha venido el profe, pero no han venido suficientes alumnos, NO HAY CLASE");
                    }
                    else
                    {
                        Console.WriteLine("Ha venido el profe y han venido suficientes alumnos, HAY CLASE");
                    }
                }
            }
            else
            {
                Console.WriteLine("No ha venido el profe, NO HAY CLASE");
            }
            int chicas = 0;
            int chicos = 0;
            for (int i = 0; i < listEstudiantes.Count; i++)
            {
                if (listEstudiantes[i].Sexo == "mujer")
                {
                    if (listEstudiantes[i].Nota >= 5)
                    {
                        chicas++;
                    }
                }
                else
                {
                    if (listEstudiantes[i].Nota >= 5)
                    {
                        chicos++;
                    }
                }
            }
            Console.WriteLine("Alumnas aprobadas: " + chicas);
            Console.WriteLine("Alumnos aprobados: " + chicos);


            Console.ReadKey();

        }
    }
}
