using System;

namespace TA28_05
{
    internal class Videojuegos:Entregable
    {
        private string titulo = "";
        private int horasEstimadas = 10;
        private bool entregado = false;
        private string genero = "";
        private string compañia = "";

        public Videojuegos()
        {
            
        }
        public Videojuegos(string nTitulo, int nHorasEstimadas)
        {
            this.titulo = nTitulo;
            this.horasEstimadas= nHorasEstimadas;
        }
        public Videojuegos(string nTitulo, int nHorasEstimadas,string nGenero,string nCompañia)
        {
            this.titulo = nTitulo;
            this.horasEstimadas = nHorasEstimadas;
            this.genero = nGenero;
            this.compañia = nCompañia;
        }
        public string Titulo { get => titulo; set => titulo = value; }
        public int HorasEstimadas { get => horasEstimadas; set => horasEstimadas = value; }
        public bool Entregado { get => entregado; set => entregado = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Compañia { get => compañia; set => compañia = value; }
        public void ToString()
        {
            Console.WriteLine("Titulo: " + this.titulo);
            Console.WriteLine("Num. Temporadas: " + this.horasEstimadas);
            Console.WriteLine("Entregado: " + this.entregado);
            Console.WriteLine("Genero: " + this.genero);
            Console.WriteLine("Creador: " + this.compañia);
        }
        public void Entregar()
        {
            this.entregado = true;
        }
        public void Devolver()
        {
            this.entregado = false;
        }

        public bool IsEntregado()
        {
            return this.entregado;
        }

        public int CompareTo(Object a)
        {
            return this.horasEstimadas.CompareTo(a);
        }
    }
}