using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LIBRERIA DE LA CAPA DE DATOS
using CapaDatos;

namespace CapaLogica
{
    public class LogicaAlumno
    {
        //instancia de DatosAlumnos
        DatosAlumno metodos = new DatosAlumno();

        public bool Guardar(EntidadAlumno dat)
        {
            //instancia de tabla universidad, tabla que contiene el modelo
            Alumno tablaAlumno = new Alumno();

            //VERIFICACION, comparacion de los registros que vinen de la capa presentancion
            tablaAlumno.ID_Alumno = dat.ID_Alumno;
            tablaAlumno.Nombre = dat.Nombre;
            tablaAlumno.Apellido = dat.Apellido;
            tablaAlumno.Direccion = dat.Direccion;
            tablaAlumno.Email = dat.Email;
            tablaAlumno.DNI = dat.DNI;
            tablaAlumno.Fecha_Nacimiento = dat.Fecha_Nacimiento;

            //retorna un valor de tipo Alumno, contenida por tablaAlumno 
            return metodos.Guardar(tablaAlumno);
        }

        public List<Alumno> MostrarDatos()
        {
            return metodos.MostrarDatos();
        }
    }
}
