using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class AlumnoCapaLogica
    {
        public static List<Alumno> GetAlumno()
        {
            AlumnoCapaDatos objAlumno = new AlumnoCapaDatos();
            return objAlumno.GetAlumno();
        }
    }
}
