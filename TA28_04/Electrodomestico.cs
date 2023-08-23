namespace TA28_04
{
    internal class Electrodomestico
    {
        protected double precioBase = 100;
        protected string color = "blanco";
        protected char consEnergetico = 'F'; //A-F
        protected double peso = 5;

        public Electrodomestico()
        { }
        public Electrodomestico(double nPrecioBase, double nPeso)
        {
            this.precioBase = nPrecioBase;
            this.peso = nPeso;
        }
        public Electrodomestico(double nPrecioBase, string nColor, char nConsEner, double nPeso)
        {
            this.precioBase = nPrecioBase;
            this.color = nColor;
            this.consEnergetico = CompConsEnergetico(nConsEner);
            this.peso = nPeso;
        }
        public double PrecioBase { get => precioBase; }
        public string Color { get => color; }
        public char ConsEnergetico { get => consEnergetico; }
        public double Peso { get => peso; }
        public char CompConsEnergetico(char letra)
        {
            if (letra == 'A' |
                letra == 'B' |
                letra == 'C' |
                letra == 'D' |
                letra == 'E' | letra == 'F')
            {
                return letra;
            }
            else
            {
                return this.consEnergetico;
            }
        }
        public string CompColor(string color)
        {

            if (color.ToLower() == "blanco" |
                color.ToLower() == "negro" |
                color.ToLower() == "rojo" |
                color.ToLower() == "azul" | color.ToLower() == "gris")
            {
                return color;
            }
            else
            {
                return this.color;
            }
        }
        public virtual void Preciofinal()
        {
            if (this.consEnergetico == 'A')
            {
                this.precioBase = this.precioBase + 100;
            }
            else
            {
                if (this.consEnergetico == 'B')
                {
                    this.precioBase = this.precioBase + 80;
                }
                else
                {
                    if (this.consEnergetico == 'C')
                    {
                        this.precioBase = this.precioBase + 60;
                    }
                    else
                    {
                        if (this.consEnergetico == 'D')
                        {
                            this.precioBase = this.precioBase + 50;
                        }
                        else
                        {
                            if (this.consEnergetico == 'E')
                            {
                                this.precioBase = this.precioBase + 30;
                            }
                            else
                            {
                                this.precioBase = this.precioBase + 10;
                            }
                        }
                    }
                }
            }
            if (this.peso >= 0 && this.peso <= 19)
            {
                this.peso = this.peso + 10;
            }
            else
            {
                if (this.peso >= 20 && this.peso <= 49)
                {
                    this.peso = this.peso + 50;
                }
                else
                {
                    if (this.peso >= 50 && this.peso <= 79)
                    {
                        this.peso = this.peso + 80;
                    }
                    else
                    {
                        this.peso = this.peso + 100;
                    }
                }
            }

        }


    }
}