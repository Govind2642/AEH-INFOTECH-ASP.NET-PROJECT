<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginaspx.aspx.cs" Inherits="AEH_Infotech.loginaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #form1{
            width:300px;
            height:300px;
            margin-top:150px;
        }
        h1{
            text-align:center;
            padding:10px;
            color:blue;
           
        }
        HyperLink{
            text-decoration:none;
        }
    </style>
</head>
<body>
    <asp:HyperLink herf="index.aspx" style="color:red;" runat="server">Back</asp:HyperLink>
    <center>
    <form id="form1" runat="server">
        <div>
            <h1>Admin login</h1>
            <div>
                <asp:TextBox ID="Textuname" placeholder="Username" required="required" data-validation-required-message="Please Enter Correct Name" runat="server"></asp:TextBox>
            </div>
            <br />
             

            <div>
                <asp:TextBox ID="Textpwd"  placeholder="Password" required="required" data-validation-required-message="Please Enter Correct Password"  runat="server"></asp:TextBox>
            </div>
                <br />
               
            <div>
                <asp:Button ID="Btnlogin"  runat="server" Text="Login" OnClick="Btnlogin_Click" style="height: 30px;width: 100px; Font-Size :15px;background-color:green; color:white;"  />
            </div>
            <br />
            <asp:HyperLink  href="adminreg.aspx" ID="HyperLink1"  style="color:blue;" runat="server">Not a Member ? Signup</asp:HyperLink>
        </div>
    </form>
        </center>
</body>
</html>
