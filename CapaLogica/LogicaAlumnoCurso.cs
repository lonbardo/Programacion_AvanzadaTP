using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LIBRERIA DE LA CAPA DE DATOS
using CapaDatos;

namespace CapaLogica
{
    public class LogicaAlumnoCurso
    {
        //instancia de DatosAlumnoCurso
        DatosAlumnoCurso metodos = new DatosAlumnoCurso();

        public bool Guardar(EntidadAlumnoCurso dat)
        {
            //instancia de tabla, tabla que contiene el modelo
            AlumnoCurso tablaAlumnoCurso = new AlumnoCurso();

            //VERIFICACION, comparacion de los registros que vinen de la capa presentancion
            tablaAlumnoCurso.Id_Alumno = dat.Id_Alumno;
            tablaAlumnoCurso.id_Curso = dat.id_Curso;
            tablaAlumnoCurso.Observaciones = dat.Observaciones;
            tablaAlumnoCurso.Profesor = dat.Profesor;
            tablaAlumnoCurso.Fecha = dat.Fecha;

            //retorna un valor de tipo AlumnoCurso, contenida por tablaAlumno 
            return metodos.Guardar(tablaAlumnoCurso);
        }

        public List<AlumnoCurso> MostrarDatos()
        {
            return metodos.MostrarDatos();
        }
    }
}
