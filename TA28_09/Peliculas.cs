namespace TA28_09
{
    internal class Peliculas
    {
        private string titulo;
        private int duracion;
        private int edadMinima;
        private string director;

        public Peliculas(string nTitulo, int nDuracion, int nEdadMinima, string nDirector)
        {
            this.titulo = nTitulo;
            this.duracion = nDuracion;
            this.edadMinima = nEdadMinima; 
            this.director = nDirector;
        }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int EdadMinima { get => edadMinima; set => edadMinima = value; }
        public string Director { get => director; set => director = value; }

    }
}