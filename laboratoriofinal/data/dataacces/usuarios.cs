    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratoriofinal.data.dataacces
{
    internal class usuarios
    {
        public int ID { get; set; }
        public string Nombreconsola { get; set; }
        public string compañia { get; set; }
        public DateTime Fechalanzamiento { get; set; }
        public int generacions { get; set; }
        public usuarios() { }

        public usuarios(int ID, string Nombreconsola, string compañia, DateTime Fechalanzamiento, int generacions)
        {
            ID = ID;
            Nombreconsola = Nombreconsola;
            compañia = compañia;
            Fechalanzamiento = Fechalanzamiento;
            generacions = generacions;

        }
        public int Obtenerfechasalida()
        {
            int fecha = DateTime.Now.Year - Fechalanzamiento.Year;
            if (DateTime.Now.DayOfYear < Fechalanzamiento.DayOfYear)
            {
                fecha--;
            }
            return fecha;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Nombreconsola: {Nombreconsola} {generacions}, fecha de nacimiento: {Fechalanzamiento.ToShortDateString()}";
        }
        }
    }
}
