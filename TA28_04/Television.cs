namespace TA28_04
{
    internal class Television : Electrodomestico
    {
        private int resolucion = 20;
        private bool sintTdt = false;
        public Television()
        {

        }
        public Television(double nPrecioBase, double nPeso)
            : base(nPrecioBase, nPeso)
        {
        }
        public Television(int nResolucion, bool nSinTdt)
            : base()
        {
            this.resolucion = nResolucion;
            this.sintTdt = nSinTdt;
        }

        public int Resolucion { get => resolucion; }
        public bool SintTdt { get => sintTdt; }
        public override void Preciofinal()
        {
            base.Preciofinal();

            if (this.resolucion > 40)
            {
                this.precioBase = this.precioBase + (this.precioBase * 1.3);
            }
            if (this.sintTdt)
            {
                this.precioBase = this.precioBase + 50;
            }
        }

    }
}