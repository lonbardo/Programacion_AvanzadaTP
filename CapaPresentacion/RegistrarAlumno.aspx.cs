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
            //if (!Page.IsPostBack)
            //{ GetDatos(); }
           

        }

        public void verGrid()
        {
            using (BD_TPEntities objetoGrid = new BD_TPEntities())
            {
                //IQueryable<Alumno> qAlumno = from q in objetoGrid.Alumnoes select q;
                //List<Alumno> lista = qAlumno.ToList();
                //GridView1.DataSource = lista;
                //GridView1.DataBind();
                List<Alumno> lista = AlumnoCapaLogica.GetAlumno();
                GridView1.DataSource = lista;
                GridView1.DataBind();
            }
        }
        protected void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            verGrid();
            GridView1.Visible = true;

        }
        //----------------------------------ESTA ES UNA MANERA DE MOSTRAR LOS REGISTROS
        //private void GetDatos()
        //{
        //    List<Alumno> coleccion = AlumnoCapaLogica.GetAlumno();
        //    foreach (var item in coleccion)
        //    {
        //        lblDatos.Text += "Nombre: " + item.Nombre + " <br/>Apellido: "
        //            + item.Apellido + " <br/>DNI : " + item.DNI + "<hr/>";
        //    }
        //}


    }
}