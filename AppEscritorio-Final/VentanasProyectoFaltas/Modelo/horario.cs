using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanasProyectoFaltas.Modelo
{
    public class horario
    {
        public int Id { get; set; }
        public int ProfesorId { get; set; }
        public int DiaSemana { get; set; }
        public int Hora { get; set; }
        public string Aula { get; set; }
        public string Grupo { get; set; }
        public string Materia { get; set; }
        public byte GeneraGuardia { get; set; }

      
    }
}
