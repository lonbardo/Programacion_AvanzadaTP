using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AlumnoCapaDatos 
    {
        public List<Alumno> GetAlumno()
        {
            using (BD_TPEntities bd = new BD_TPEntities())//se crea la instancia de nuestro contexto
            {
                return bd.Alumnoes.ToList();
            }
        }
    }
}
