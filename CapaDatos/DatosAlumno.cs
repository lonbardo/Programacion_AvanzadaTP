using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{   
    //ESTE CLASE PRETENDE SER DONDE SE GENERARAN LOS METODOS
    public class DatosAlumno 
    {
        //INSTANCIAR LA BD
        BD_TPEntities modelobd = new BD_TPEntities();

        //-------METODOS
        public bool Guardar(Alumno dat)
        {
            modelobd.Alumnoes.Add(dat);
            modelobd.SaveChanges();
            return true;
        }

        //consutas de tipo LINQ que retorna una lista
        public List<Alumno> MostrarDatos()
        {
            var query = (from e in modelobd.Alumnoes
                         select e);
            return query.ToList();
        }
    }
}
