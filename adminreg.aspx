<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminreg.aspx.cs" Inherits="AEH_Infotech.adminreg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    #form1{
      
        margin-top:130px;
    }
    h2{
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
     <asp:HyperLink herf="loginaspx.aspx" style="color:red;" runat="server">Back</asp:HyperLink>
    <center>
    <form id="form1" runat="server">
        <div>
            <h2>Admin Register</h2>
            <div>
                <asp:TextBox ID="Textstaff" placeholder="Staff Id" required="required" data-validation-required-message="Please Enter Correct Staff_id" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="Textuname"  placeholder="Username" required="required" data-validation-required-message="Please Enter Correct Name"   runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="Textpwd"  placeholder="Password" required="required" data-validation-required-message="Please Enter Correct Password"  runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="Textmobile" placeholder="Mobile Number" required="required" data-validation-required-message="Please Enter Correct Mobile Number"  runat="server"></asp:TextBox>
            </div>
             <br />
            <div>
                <asp:TextBox ID="Textage" placeholder="Age"  required="required" data-validation-required-message="Please Enter Correct Age" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="Textcity" placeholder="City" required="required" data-validation-required-message="Please Enter Correct City" runat="server"></asp:TextBox>
               
            </div>
             <br />
            
            <div>
                <asp:Button ID="Button2" runat="server"  style="height: 30px;width: 100px; Font-Size :15px;background-color:green; color:white;" Text="Submit" OnClick="Button2_Click" />
                
            </div>

        </div>
    </form>
        </center>
</body>
</html>
