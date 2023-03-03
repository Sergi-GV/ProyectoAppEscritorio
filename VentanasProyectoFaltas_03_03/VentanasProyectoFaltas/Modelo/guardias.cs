using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanasProyectoFaltas.Modelo
{
    public enum EstadoGuardiaEnum
    {
        P, C, A
    }
    public class guardias
    {
        public int Id { get; set; }
        public int ProfFaltaId { get; set; }
        public int? ProfGuardiaId { get; set; }
        public EstadoGuardiaEnum Estado { get; set; }
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
