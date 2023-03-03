using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanasProyectoFaltas.Modelo
{
    public class guardias
    {
        public int Id { get; set; }
        public int Prof_Falta { get; set; }
        public int? Prof_hace_guardia { get; set; }
        public char Estado { get; set; }
        public DateTime Fecha { get; set; }
        public int Horario { get; set; }
        public int DiaSemana { get; set; }
        public int Hora { get; set; }
        public int? Aviso { get; set; }
        public string Grupo { get; set; }
        public string Aula { get; set; }
        public string Observaciones { get; set; }

       
    }
}
