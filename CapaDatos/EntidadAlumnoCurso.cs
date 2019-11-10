using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EntidadAlumnoCurso
    {
        public int Id_Alumno { get; set; }
        public int id_Curso { get; set; }
        public string Observaciones { get; set; }
        public string Profesor { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}
