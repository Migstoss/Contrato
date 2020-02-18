using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using IronPdf;

namespace Contrato
{
  public partial class Contrato : System.Web.UI.Page
  {   
    protected void Page_Load(object sender, EventArgs e)
    {
      SqlConnection conn = new SqlConnection(@"Data Source=190.145.65.244;Initial Catalog=CTD_DMS;Persist Security Info=True;User ID=UsoExclusivoCTD;Password=C7d5452014");
      SqlCommand query = new SqlCommand(@"EXECUTE spn_contrato 98531705, 62100", conn);
      conn.Open();      

      SqlDataReader dr = query.ExecuteReader();
      if(dr.Read())
      {
        TextBox1.Text = (dr["descripcion_contrato"].ToString());
      }
      conn.Close();
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
        Response.Redirect("redirect.aspx");
      }
    }

    protected void btnimprimir_Click(object sender, EventArgs e)
    {
      // Render any HTML fragment or document to HTML
      var Renderer = new IronPdf.HtmlToPdf();
      var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
      var OutputPath = "HtmlToPDF.pdf";
      PDF.SaveAs(OutputPath);
      // This neat trick opens our PDF file so we can see the result in our default PDF viewer
      System.Diagnostics.Process.Start(OutputPath);
    }
  }
}