<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrato.aspx.cs" Inherits="Contrato.Contrato" %>

<!DOCTYPE html>

<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

<style>
  table{
    margin: auto; 
    width: 50% !important;
    margin: 0px auto;
    float: none;
  }
  #cbAceptar{
    position: relative;
    top: -2px;
  }
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>    
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
		<table border="0">
			<tr>        
			  <td><div class="col" style="width: 100%; height: 400px; overflow: scroll"><asp:GridView ID="GridView" CssClass="col" runat="server" AutoGenerateColumns="True" OnSelectedIndexChanged="GridView_SelectedIndexChanged"></asp:GridView></div></td>
			</tr>
      <tr>
			  <td><div class="col"><asp:CheckBox ID="cbAceptar" CssClass="col checkbox" runat="server" Text="Aceptar Terminos" /></div></td>
			</tr>
      <tr>
			  <td><div class="col text-center"><asp:Button ID="btnContinuar" CssClass="align" runat="server" Text="Continuar" OnClick="btnContinuar_Click" /></div></td>
			</tr>
		</table>
  </form>
</body>
</html>

<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>