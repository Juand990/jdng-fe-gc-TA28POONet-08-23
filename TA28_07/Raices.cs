using System;

namespace TA28_07
{
    internal class Raices
    {
        private int a;
        private int b;
        private int c;

        public Raices(int A, int B, int C)
        {
            this.a = A; this.b = B; this.c = C;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public void ObtenerRaices()
        {
            Console.WriteLine("Solucion 1: " + (-this.b + Math.Sqrt(((this.b ^ 2) - (4 * this.a * this.c)))));
            Console.WriteLine("Solucion 2: " + (-this.b - Math.Sqrt(((this.b ^ 2) - (4 * this.a * this.c)))));
        }
        public void ObtenerRaiz()
        {
            Console.WriteLine("Solucion 1: " + (-this.b + Math.Sqrt(((this.b ^ 2) - (4 * this.a * this.c)))));
        }
        public double GetDiscriminante()
        {
            return (this.b ^ 2) - 4 * this.a * this.c;
        }
        public bool TieneRaices()
        {
            if (GetDiscriminante() >=0)
            {
                return true;
            }
            else
            {
                return false;
            }                
        }
        public bool TieneRaiz()
        {
            if (GetDiscriminante() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Calcular()
        {
            if (GetDiscriminante() >= 0)
            {
                Console.WriteLine("Solucion 1: " + (-this.b + Math.Sqrt(((this.b ^ 2) - (4 * this.a * this.c)))));
                Console.WriteLine("Solucion 2: " + (-this.b - Math.Sqrt(((this.b ^ 2) - (4 * this.a * this.c)))));
            }
            if (GetDiscriminante() < 0)
            {
                Console.WriteLine("No tiene solucion");
            }
        }
    }
}