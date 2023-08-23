namespace TA28_04
{
    internal class Lavadora : Electrodomestico
    {
        private double carga = 5;

        public Lavadora() : base()
        { }
        public Lavadora(double nPrecioBase, double nPeso)
            : base(nPrecioBase, nPeso)
        {

        }
        public Lavadora(double nCarga)
            : base()
        {
            this.carga = nCarga;
        }
        public double Carga { get => carga; set => carga = value; }
        public override void Preciofinal()
        {
            base.Preciofinal();
            
            if (this.carga>30)
            {
                this.precioBase = this.precioBase + 50;
            }
        }

    }
}