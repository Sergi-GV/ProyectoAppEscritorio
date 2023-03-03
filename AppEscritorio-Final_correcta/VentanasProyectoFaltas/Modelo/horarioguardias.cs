using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanasProyectoFaltas.Modelo
{
    public class horarioguardias
    {
        public int Id { get; set; }
        public int ProfesorId { get; set; }
        public int DiaSemana { get; set; }
        public int HoraGuardia { get; set; }
        public int Realizadas { get; set; }

      
    }
}
