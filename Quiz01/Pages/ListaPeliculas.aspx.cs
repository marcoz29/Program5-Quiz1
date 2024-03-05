using Quiz01.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz01.Pages
{
    public partial class ListaPeliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
                //Se implementa using para asegurarse que el objeto que se esta creando
                //sea destruido automaticamente una vez salimos del bloque de codigo
                //using
                using (PV_Quiz01Entities db = new PV_Quiz01Entities())
                {
                    //Usamos el procedimiento almacenado para cargar una lista que se
                    //mostrara en el gridview de la pagina
                    var Lista = db.spConsultarTodasLasPeliculas().ToList();

                    GvListarPeliculas.DataSource = Lista;
                    GvListarPeliculas.DataBind();
                }
            }
            catch (Exception)
			{

				
			}
        }
    }
}