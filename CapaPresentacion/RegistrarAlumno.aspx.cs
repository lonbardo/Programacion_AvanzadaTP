using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class RegistrarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                GetDatos();
        }

        private void GetDatos()
        {
            List<Alumno> coleccion = AlumnoCapaLogica.GetAlumno();
            foreach (var item in coleccion)
            {
                lblDatos.Text += "Nombre: " + item.Nombre + " <br/>Apellido: "
                    + item.Apellido + " <br/>DNI : " + item.DNI + "<hr/>";
            }
        }
    }
}