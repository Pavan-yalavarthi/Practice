<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignment1_Asp.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asp Validator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Insert Your Details :</h3>
                Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                &nbsp;&nbsp;  
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"  ErrorMessage="Name is required."  ForeColor="Red"></asp:RequiredFieldValidator>  
             <br />
            <br />
            
                Family Name :  
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
                &nbsp;  
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator2"  runat="server"  ControlToValidate="TextBox2"  ErrorMessage="Family Name is required."  ForeColor="Red"></asp:RequiredFieldValidator>  
                <asp:CompareValidator  ID="CompareValidator1"  runat="server"  ControlToValidate="TextBox2"  ControlToCompare="TextBox1"  ErrorMessage="Family Name is different from Name."  ForeColor="Red"  Operator="NotEqual"></asp:CompareValidator>  
              <br />
            <br />
                Address :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
                &nbsp;  
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator3"  runat="server"  ControlToValidate="TextBox3"  ErrorMessage="Address is required."  ForeColor="Red"></asp:RequiredFieldValidator>  
                <asp:RegularExpressionValidator  ID="RegularExpressionValidator1"  runat="server"  ControlToValidate="TextBox3"  ValidationExpression=".{2,}"  ErrorMessage="Address  have at least 2 characters."  ForeColor="Red"></asp:RegularExpressionValidator>  
             
                     <br />
             <br />
                City :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
                &nbsp;  
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator4"  runat="server"  ControlToValidate="TextBox4"  ErrorMessage="City is required."  ForeColor="Red"></asp:RequiredFieldValidator>  
                <asp:RegularExpressionValidator  ID="RegularExpressionValidator2"  runat="server"  ControlToValidate="TextBox4"  ValidationExpression=".{2,}"  ErrorMessage="City having atleast 2 characters."  ForeColor="Red"></asp:RegularExpressionValidator>  
               <br />
             <br />
                Zip Code :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>  
                &nbsp;  
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator5"  runat="server"  ControlToValidate="TextBox5"  ErrorMessage="Zip Code is Required."  ForeColor="Red"></asp:RequiredFieldValidator>  
                <asp:RegularExpressionValidator  ID="RegularExpressionValidator3"  runat="server"  ControlToValidate="TextBox5"  ValidationExpression="^\d{5}$"  ErrorMessage="Zip Code Format 5(xxxxx)."  ForeColor="Red"></asp:RegularExpressionValidator>  
             <br />
             <br />
                Phone :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>  
                &nbsp;  
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator6"  runat="server"  ControlToValidate="TextBox6"  ErrorMessage="Phone No Required."  ForeColor="Red"></asp:RequiredFieldValidator>  
                <asp:RegularExpressionValidator  ID="RegularExpressionValidator4"  runat="server"  ControlToValidate="TextBox6"  ValidationExpression="^\d{2}-\d{10}$|^\d{3}-\d{7}$"  ErrorMessage="Phone Number Format (XX-xxxxxxxxxx or XXX-xxxxxxx)."  ForeColor="Red"></asp:RegularExpressionValidator>  
             <br />
             <br />
                Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>  
                &nbsp;  
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator7"  runat="server"  ControlToValidate="TextBox7"  ErrorMessage="Email is required."  ForeColor="Red"></asp:RequiredFieldValidator>  
                <asp:RegularExpressionValidator  ID="RegularExpressionValidator5"  runat="server"  ControlToValidate="TextBox7"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ValidationExpressionOptions="IgnoreCase"  ErrorMessage="Enter  valid email address."  ForeColor="Red"></asp:RegularExpressionValidator>  
               <br />
            <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:Button ID="Button" runat="server" OnClick="Button_Click" Text="Check" />  
            
        </div>
    </form>
</body>
</html>
