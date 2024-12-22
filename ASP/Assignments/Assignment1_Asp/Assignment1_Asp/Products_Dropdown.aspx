<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products_Dropdown.aspx.cs" Inherits="Assignment1_Asp.Products_Dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
             Product:
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
<asp:ListItem Value="0">select a product</asp:ListItem>
<asp:ListItem Value="1">Product 1</asp:ListItem>
<asp:ListItem Value="2">Product 2</asp:ListItem>
<asp:ListItem Value="3">Product 3</asp:ListItem>
</asp:DropDownList>
<p>
<asp:Image ID="Image1" runat="server" Height="200px" Width="200px" />
</p>
<asp:Button ID="Button" runat="server" Text="Show Price" OnClick="Button_Click" />
<p>
<asp:Label ID="Label1" runat="server" ForeColor="#00CC00" Text="Product Price"></asp:Label>
</p>
</form>
        
   
</body>
</html>
