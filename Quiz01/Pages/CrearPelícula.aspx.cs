using Quiz01.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz01.Pages
{
    public partial class CrearPelícula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Se va a almacenar variables locales los valores
            //digitados en la pagina.
            string nombre = TxtNombre.Text.Trim();
            int anhoEstreno =int.Parse(TxtAnhoEstreno.Text.Trim());
            string genero = TxtGenero.Text.Trim();
            DateTime fechaCreacion = DateTime.Now;

            try
            {
                using (PV_Quiz01Entities db = new PV_Quiz01Entities())
                {
                    db.spCrearPelicula(nombre, anhoEstreno, genero, fechaCreacion);
                }
            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("~/Pages/Resultado.aspx");
        }
    }
}