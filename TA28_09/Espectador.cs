namespace TA28_09
{
    internal class Espectador
    {
        private string nombre;
        private int  edad;
        private double dinero;

        public Espectador(string nNombre, int nEdad, double nDinero)
        {
            this.nombre = nNombre;
            this.edad = nEdad;
            this.dinero = nDinero;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Dinero { get => dinero; set => dinero = value; }
    }
}