using System;

namespace TA28_02
{
    internal class Persona
    {
        Random rnd=new Random();
        private string nombre = "";
        private int edad = 0;
        private string dni;
        private char sexo = 'H';
        private double peso = 0;
        private int altura = 0;
        public Persona()
        {}
        public Persona(string nNombre,int nEdad, char nSexo)
        {
            this.nombre = nNombre;
            this.edad = nEdad;
            this.sexo = nSexo;
        }
        public Persona(string nNombre, int nEdad, char nSexo,double nPeso, int nAltura)
        {
            this.nombre = nNombre;
            this.edad = nEdad;
            this.sexo = nSexo;
            this.peso = nPeso;
            this.altura = nAltura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni;}
        public char Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Altura { get => altura; set => altura = value; }

        public int CalcularIMC()
        {
            int pesoKg = (int)this.peso;
            int alt = (int)this.altura / 100;
            double imc = pesoKg / (Math.Pow(alt,2));
            if (imc<20)
            {
                return -1;
            }
            else
            {
                if (imc>=20 && imc <=25)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
        public bool EsMayorEdad()
        {
            if (this.edad>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void toString()
        {
            Console.WriteLine("Nombre: "+this.nombre);
            Console.WriteLine("Edad: "+this.edad);
            Console.WriteLine("DNI: "+this.dni);
            Console.WriteLine("Sexo: "+this.sexo);
            Console.WriteLine("Peso: "+this.peso);
            Console.WriteLine("Altura: "+this.altura);
        }
        public void GenerarDni()
        {
            string genDni = "";
            for (int i = 0; i < 8; i++)
            {
                genDni=genDni+ rnd.Next(0, 10);
            }
            
        }

    }
}
