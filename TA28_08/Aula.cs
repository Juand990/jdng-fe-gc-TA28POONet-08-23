using System.Collections.Generic;

namespace TA28_08
{
    internal class Aula
    {
        private int id;
        private int maxEstudiantes;
        private string destinada;
        private Profesores prof;
        private List<Estudiantes> lisEstud;

        public Aula(int nId, int nMaxEst, string nDestinada, Profesores nProf,List<Estudiantes> nList)
        {
            this.id = nId;
            this.maxEstudiantes = nMaxEst;
            this.destinada = nDestinada;
            this.prof = nProf; 
            this.lisEstud = nList;
        }

        public int Id { get => id; set => id = value; }
        public int MaxEstudiantes { get => maxEstudiantes; set => maxEstudiantes = value; }
        public string Destinada { get => destinada; set => destinada = value; }
        internal Profesores Prof { get => prof; set => prof = value; }
        internal List<Estudiantes> LisEstud { get => lisEstud; set => lisEstud = value; }
    }
}