using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EntidadAlumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int ID_Alumno { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public decimal DNI { get; set; }
        public string Email { get; set; }
        
    }
}
