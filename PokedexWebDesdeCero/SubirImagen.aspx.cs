using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI.HtmlControls;

namespace PokedexWebDesdeCero
{
    public partial class SubirImagen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (File.Exists(WebConfigurationManager.AppSettings["ImageFolder"] + fileImagen.PostedFile.FileName)){
                File.Delete(WebConfigurationManager.AppSettings["ImageFolder"] + fileImagen.PostedFile.FileName);
            }
            fileImagen.PostedFile.SaveAs(WebConfigurationManager.AppSettings["ImageFolder"] + "renombrado.jpg");
            lblMensaje.Text = Path.GetExtension(WebConfigurationManager.AppSettings["ImageFolder"] + "renombrado.jpg");

            
                
        }
    }
}