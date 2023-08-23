using System;

namespace TA28_01
{
    internal class Cuenta
    {
        private string titular;
        private double cantidad;
        public Cuenta(string nTitular, double nCantidad)
        {
            this.Titular = nTitular;
            this.Cantidad = nCantidad;
        }
        public Cuenta(string nTitular)
        {
            this.Titular = nTitular;
        }
        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public void ToString ()
        {
            Console.WriteLine("Titular: "+this.titular);
            Console.WriteLine("Cantidad: " +this.cantidad);
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad = this.cantidad + cantidad;
            }           
        }
        public void Retirar(double cantidad)
        {
            this.cantidad = this.cantidad - cantidad;
            if (this.cantidad<0)
            {
                this.cantidad = 0;
            }
        }
    }
}