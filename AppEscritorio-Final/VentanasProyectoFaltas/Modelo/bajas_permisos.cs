using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanasProyectoFaltas.Modelo
{
    public enum TipoBajaEnum
    {
        B, P, O
    }
    public class bajas_permisos
    {
        public int BajaId { get; set; }
        public int ProfesorId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public TipoBajaEnum Tipo { get; set; }

     
    }
}
