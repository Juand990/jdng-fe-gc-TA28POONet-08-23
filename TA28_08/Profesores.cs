using System;

namespace TA28_08
{
    internal class Profesores : Personal
    {
        private static Random rnd = new Random();
        private string materia;

        public Profesores(string nNombre, int nEdad, string nSexo, string nMateria)
            : base(nNombre, nEdad, nSexo)
        {
            if (nMateria.ToLower() == "matematicas" | nMateria.ToLower() == "filosofia" | nMateria.ToLower() == "fisica")
            {
                this.materia = nMateria;
            }
            else
            {
                this.materia = "";
            }
        }

        public string Materia { get => materia; set => materia = value; }
        public bool noVienenHoy()
        {
            if (rnd.Next(0, 100) <= 20)
            {
                return true; // no viene
            }
            else
            {
                return false;
            }

        }
    }
}