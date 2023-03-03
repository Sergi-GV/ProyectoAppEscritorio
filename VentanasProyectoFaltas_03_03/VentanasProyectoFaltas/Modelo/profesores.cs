using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VentanasProyectoFaltas.Modelo
{
    public class profesores
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Ape1 { get; set; }
        public string Ape2 { get; set; }
        public string Tfno { get; set; }
        public byte Baja { get; set; }
        public byte Activo { get; set; }
        public string DeptCod { get; set; }
        public int? SustituyeId { get; set; }
        public string apikey { get; set; }


       
    }
}
