using System;
using System.IO;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;

namespace Contrato
{
	public partial class Contrato : System.Web.UI.Page
	{
		string idContrato;
		protected void Page_Load(object sender, EventArgs e)
		{
			lblnit.Text = Convert.ToString(Request.QueryString["nit"]);
			lblusuario.Text = Convert.ToString(Request.QueryString["usuario"]);

			SqlConnection conn = new SqlConnection(@"Data Source=190.145.65.244;Initial Catalog=CTD_DMS;Persist Security Info=True;User ID=UsoExclusivoCTD;Password=C7d5452014");
			SqlCommand buscarContrato = new SqlCommand(@"EXECUTE spn_contrato " + lblnit.Text + @"", conn);
			conn.Open();

			SqlDataReader dr = buscarContrato.ExecuteReader();
			if (dr.Read())
			{
				TextBox1.Text = (dr["descripcion_contrato"].ToString());
				idContrato = (dr["id_ctd_contrato"].ToString());
				lbltcontrato.Text = idContrato;

			}
			conn.Close();
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		protected void btnContinuar_Click(object sender, EventArgs e)
		{
			try
			{
				if (!cbAceptar.Checked)
				{
					ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Debe aceptar los terminos')", true);
				}
				else
				{
					SqlConnection conn = new SqlConnection(@"Data Source=190.145.65.244;Initial Catalog=CTD_DMS;Persist Security Info=True;User ID=UsoExclusivoCTD;Password=C7d5452014");
					conn.Open();
					SqlCommand aceptarContrato = new SqlCommand(@"EXECUTE spn_contrato_firma " + lblnit.Text + "," + idContrato + "," + lblusuario.Text, conn);					
					SqlDataReader dr = aceptarContrato.ExecuteReader();
					conn.Close();					
				}
			}
			catch(Exception err)
			{
				throw new Exception(err.Message);
			}
		}

		protected void btnimprimir_Click(object sender, EventArgs e)
		{

		}
	}
}