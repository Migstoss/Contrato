using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Contrato
{
  public partial class Contrato : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conndb = new SqlConnection(@"Data Source=190.145.65.244;Initial Catalog=CTD_DMS;Persist Security Info=True;User ID=UsoExclusivoCTD;Password=C7d5452014");

        SqlCommand consulta = new SqlCommand(@"EXECUTE spn_contrato 98531705, 62100", conndb);
        SqlDataAdapter resultado = new SqlDataAdapter(consulta);
        DataTable datos = new DataTable();
        resultado.Fill(datos);
        GridView.DataSource = datos;
        GridView.DataBind();
    }

    protected void btnContinuar_Click(object sender, EventArgs e)
    {
      if (!cbAceptar.Checked)
      {
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe aceptar los terminos')", true);
      }
      else
      {
        Response.Redirect("redirect.aspx");
      }
    }

    protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}