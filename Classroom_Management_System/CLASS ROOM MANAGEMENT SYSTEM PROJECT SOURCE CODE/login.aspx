<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">Classroom</div>
    <center> 
    <h3>Login</h3>
    <table>
     <tr>
     <td>Select Type</td>
     <td> 
         <asp:DropDownList ID="ddlType" runat="server"  Width="200px">
             <asp:ListItem Value="f">Faculty</asp:ListItem>
             <asp:ListItem Value="s">Student</asp:ListItem>
         </asp:DropDownList>
     </td>
     </tr>
     <tr>
     <td>Login Id : </td>
     <td> 
         <asp:TextBox ID="txtLoginId" runat="server" Width="200px"></asp:TextBox>
         <asp:RequiredFieldValidator
             ID="RequiredFieldValidator1" runat="server" 
              ControlToValidate ="txtLoginId"  Display = "Dynamic" 
             ErrorMessage="Login Id Is Missing!">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
          ControlToValidate = "txtLoginId"
           ValidationExpression="^[0-9]+$"
          Display = "Dynamic"
          runat="server" 
          ErrorMessage="Invalid Login Id. Login Id must be a number!">*</asp:RegularExpressionValidator>             
        </td>


     </tr>
     <tr>
     <td>Password : </td>
     <td> 
         <asp:TextBox ID="txtPassword" TextMode ="Password"  Width="200px" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator
              ID="RequiredFieldValidator2" runat="server" 
             ControlToValidate ="txtPassword"  Display = "Dynamic" 
             ErrorMessage="Password Is Missing!">*</asp:RequiredFieldValidator></td>         
         
      </td>

     </tr>
    </table>
    <p />
        <asp:Button ID="btnLogin" runat="server" Text="Login" 
            onclick="btnLogin_Click" />
        <p />
            &nbsp;<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <p>
        <asp:Label ID="lblMsg" runat="server" Text="" EnableViewState ="false"></asp:Label>
    </center>
    </form>
</body>
</html>
