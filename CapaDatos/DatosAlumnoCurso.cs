using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosAlumnoCurso
    {
        //INSTANCIAR LA BD
        BD_TPEntities modelobd = new BD_TPEntities();

        //-------METODOS
        public bool Guardar(AlumnoCurso dat)
        {
            modelobd.AlumnoCursoes.Add(dat);
            modelobd.SaveChanges();
            return true;
        }

        //consutas de tipo LINQ que retorna una lista
        public List<AlumnoCurso> MostrarDatos()
        {
            var query = (from e in modelobd.AlumnoCursoes
                         select e);
            return query.ToList();
        }
    }
}
