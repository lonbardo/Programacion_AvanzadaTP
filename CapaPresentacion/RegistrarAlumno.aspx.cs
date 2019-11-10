using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//LLAMAMOS A LAS LIBRERIAS 
using CapaLogica;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class RegistrarAlumno : System.Web.UI.Page
    {
        //instancia para llamar cualquiera de los metodos creados en la capa de logica
        LogicaAlumno metodosAlumno = new LogicaAlumno();
        //instancia que contiene los atributos de la tabla alumno
        EntidadAlumno entidadAlumno = new EntidadAlumno();

        //metodo
        public void Guardar()
        {
               //captura los valores de los txtbox
                entidadAlumno.Nombre = txtNombre.Text;
                entidadAlumno.Apellido = txtApellido.Text;
                entidadAlumno.DNI = Convert.ToInt32(txtDNI.Text);
                entidadAlumno.Direccion = txtDireccion.Text;
                entidadAlumno.Email = txtDireccion.Text;
                entidadAlumno.Fecha_Nacimiento = Convert.ToDateTime(txtFechaNac.Text); ;

                metodosAlumno.Guardar(entidadAlumno);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            llenarGrid();
            lblAlerta.Text = "Registro guardado.";
            lblAlerta.Visible = true;
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");//deberia limpiar los txtbox pero no lo hace
        }

        //GRID
        private void llenarGrid()
        {
            var datos = metodosAlumno.MostrarDatos();
            GridView1.DataSource = datos;
            GridView1.DataBind();
        }

        protected void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            llenarGrid();
            GridView1.Visible = true;

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{ GetDatos(); }
        }
             
    }
}