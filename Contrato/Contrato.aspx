<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrato.aspx.cs" Inherits="Contrato.Contrato" %>

<!DOCTYPE html>

<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">

<style>
  table{
    margin: auto; 
    width: 68% !important;
    margin: 0px auto;
    float: none;
  }
  #cbAceptar{
    position: relative;
    top: -2px;
  }
  #TextBox1{
    width: 100%;
    height: 500px;
    margin-top:
    inherit;
  }
  #divCB{
    align-content: center;
    text-align: center;
    margin-top: 15px;
  }
  #classBtn{
    margin-top: 15px;
  }
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>    
  <title></title>
</head>
<body>
  <form id="form1" runat="server" style="margin-top:10%">
		<asp:Label ID="lblnit" runat="server" Text="Label" Visible="false"></asp:Label>
    <asp:Label ID="lblusuario" runat="server" Text="Label" Visible="false"></asp:Label>
    <asp:Label ID="lbltcontrato" runat="server" Text="Label" Visible="false"></asp:Label>
		<table border="0">
			<tr>        
			  <td>          
				  <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" SkinID="disabled" ReadOnly="True" TextMode="MultiLine" BorderStyle="Ridge" ValidateRequestMode="Disabled"></asp:TextBox>
			  </td>
			</tr>
      <tr>
			  <td><div class="col" id="divCB"><asp:CheckBox ID="cbAceptar" CssClass="col checkbox" runat="server" Text="Aceptar Terminos"/></div></td>
			</tr>
      <tr>
			  <td>
          <div class="col text-center" id="classBtn">
            <asp:Button ID="btnContinuar" Text="Continuar" runat="server" OnClick="btnContinuar_Click" />
            <asp:Button ID="btnimprimir" Text="Imprimir" runat="server" OnClick="btnimprimir_Click" />
			    </div>
			  </td>        
			</tr>
		</table>
  </form>
</body>
</html>

<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>