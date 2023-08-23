using System;

namespace TA28_06
{
    internal class Libro
    {
        private string isbn;
        private string titulo;
        private string autor;
        private int numPaginas;

        public Libro(string nIsbn, string nTitulo, string nAutor, int nNumP)
        {
            this.isbn = nIsbn;
            this.titulo = nTitulo;
            this.autor = nAutor;
            this.numPaginas = nNumP;
        }

        public string Isbn { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }
        public void ToString()
        {
            Console.WriteLine("El libro con ISBN "+ this.isbn + " creado por "+ this.autor+" tiene "+ this.numPaginas);
        }
    }
}