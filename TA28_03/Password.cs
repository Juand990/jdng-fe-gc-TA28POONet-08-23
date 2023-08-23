using System;
using System.Text.RegularExpressions;

namespace TA28_03
{
    internal class Password
    {
        private static Random rnd =new Random(); //aleatorios sin repeticion
        private int longitud = 8;
        private string contraseña;
        public Password()
        {    }
        public Password(int nLongitud)
        {
            this.longitud = nLongitud;
            this.contraseña = GenerarPass(this.Longitud);                        
        }        
        public int Longitud { get => longitud; set => longitud = value; }
        public string Contraseña { get => contraseña; }
        private string GenerarPass(int l)
        {            
            string pass = "";
            string numeros = "0123456789";
            int numLen = numeros.Length;
            string letras = "qwertyuiopasdfghjklñzxcvbnm";
            int letLen = letras.Length;
            string mayus = "QWERTYUIOPASDFGHJKLÑZXCVBNM";
            int mayusLen = mayus.Length;
            
            for (int i = 0; i < l; i++)
            {
                int r = rnd.Next(0, 2 + 1);
                if (r == 0) //numeros
                {
                    int pos = rnd.Next(0, numLen);
                    pass = pass + numeros[pos];
                }
                else //letras
                {
                    if (r == 1)
                    {
                        int pos = rnd.Next(0, letLen);
                        pass = pass + letras[pos];
                    }
                    else
                    {
                        int pos = rnd.Next(0, mayusLen);
                        pass = pass + mayus[pos];
                    }
                }
            }
            return pass;
        }
        public bool EsFuerte()
        {
            string numeros = "[0-9]";
            string letras = "[a-z]";
            string mayus = "[A-Z]";
            Regex n = new Regex(numeros);
            Regex l = new Regex(letras);
            Regex m = new Regex(mayus);

            MatchCollection nMatch = n.Matches(this.contraseña);
            MatchCollection lMatch = l.Matches(this.contraseña);
            MatchCollection mMatch = m.Matches(this.contraseña);
            if (mMatch.Count>=2)
            {
                if (lMatch.Count>=1)
                {
                    if (nMatch.Count>=5)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}