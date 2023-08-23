using System;
using System.Runtime.CompilerServices;

namespace TA28_05
{
    internal class Serie : Entregable
    {
        private string titulo = "";
        private int numTemporada = 3;
        private bool entregado = false;
        private string genero = "";
        private string creador = "";

        public Serie()
        {

        }
        public Serie(string nTitulo, string nCreador)
        {
            this.titulo = nTitulo;
            this.creador = nCreador;
        }
        public Serie(string nTitulo, int nNumtemp, string nGenero, string nCreador)
        {
            this.titulo = nTitulo;
            this.numTemporada = nNumtemp;
            this.genero = nGenero;
            this.creador = nCreador;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int NumTemporada { get => numTemporada; set => numTemporada = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }

        public void ToString()
        {
            Console.WriteLine("Titulo: " + this.titulo);
            Console.WriteLine("Num. Temporadas: " + this.numTemporada);
            Console.WriteLine("Entregado: " + this.entregado);
            Console.WriteLine("Genero: " + this.genero);
            Console.WriteLine("Creador: " + this.creador);
        }

        public void Entregar()
        {
            this.entregado = true;
        }

        public void Devolver()
        {
            this.entregado = false;
        }

        public bool IsEntregado() {
            return this.entregado;
        }

        public int CompareTo(Object a) {
            return this.numTemporada.CompareTo(a);
        }
    }
}