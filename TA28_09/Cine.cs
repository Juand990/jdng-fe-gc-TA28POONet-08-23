namespace TA28_09
{
    internal class Cine
    {
        private Peliculas pelicula;
        private double precio;

        public Cine(Peliculas nPeli, double nPrecio)
        {
            this.Pelicula = nPeli;
            this.precio = nPrecio;
        }

        public double Precio { get => precio; set => precio = value; }
        internal Peliculas Pelicula { get => pelicula; set => pelicula = value; }
    }
}