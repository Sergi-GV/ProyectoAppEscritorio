using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanasProyectoFaltas.Modelo
{
    public class avisos_guardia
    {
        public int AvisoId { get; set; }
        public int ProfesorId { get; set; }
        public int Horario { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
        public bool Confirmado { get; set; }
        public bool Anulado { get; set; }
        public DateTime FechaGuardia { get; set; }
        public DateTime FechaHoraAviso { get; set; }

        
    }
}
