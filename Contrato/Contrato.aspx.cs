using System;
using System.IO;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;

namespace Contrato
{
  public partial class Contrato : System.Web.UI.Page
  {    
    protected void Page_Load(object sender, EventArgs e)
    {
      SqlConnection conn = new SqlConnection(@"Data Source=190.145.65.244;Initial Catalog=CTD_DMS;Persist Security Info=True;User ID=UsoExclusivoCTD;Password=C7d5452014");
      SqlCommand buscarContrato = new SqlCommand(@"EXECUTE spn_contrato 98531705, 62100", conn);
      conn.Open();      

      SqlDataReader dr = buscarContrato.ExecuteReader();
      if(dr.Read())
      {
        TextBox1.Text = (dr["descripcion_contrato"].ToString());
      }
      conn.Close();
    }

    internal void CreatePdf(string dEST)
    {
      throw new NotImplementedException();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    protected void btnContinuar_Click(object sender, EventArgs e)
    {
      if (!cbAceptar.Checked)
      {
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe aceptar los terminos')", true);
      }
      else
      {
        SqlCommand aceptarContrato = new SqlCommand(@"exec spn_contrato_firma 98531705, 1, Administrador, 67100");
        Response.Redirect("redirect.aspx");
      }
    }

    protected void btnimprimir_Click(object sender, EventArgs e)
    {
      
    }
  }
}