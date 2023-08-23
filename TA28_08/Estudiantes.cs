using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace TA28_08
{
    internal class Estudiantes:Personal
    {
        private static Random rnd = new Random();

        private int nota;

        public Estudiantes(string nNombre, int nEdad, string nSexo,int nNota)
            :base( nNombre,  nEdad,  nSexo)
        {
            if (nNota>=0 && nNota <=10)
            {
                this.nota = nNota;
            }
            else
            {
                this.nota = 1;
            }            
        }
        public int Nota { get => nota; set => nota = value; }
        public bool noVienenHoy()
        {
            if (rnd.Next(0,100)<=50)
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