namespace TA28_08
{
    internal class Personal
    {
        protected string nombre;
        protected int edad;
        protected string sexo;

        public Personal(string nNombre, int nEdad,string nSexo)
        {
            this.nombre = nNombre;
            this.edad = nEdad;
            this.sexo = nSexo;  
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}