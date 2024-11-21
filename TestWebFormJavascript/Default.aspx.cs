using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebFormJavascript
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [WebMethod]
        public static Models.Result Enviar_Indicador_Novo(string Data, string Pilar)
        {

            Models.Result result = new Models.Result();

            result.Objects = new List<object>();

            for (int i = 0; i < 100000; i++)
            {
                result.Object = new { Nombre = $"Eduardo {i}", Edad = i };
                result.Objects.Add(result.Object);
            }



            return result;

        }


    }
}