<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="joinnow.aspx.cs" Inherits="AEH_Infotech.joinnow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        h2{
            color:blue;
        }

    </style>
</head>
<body>
    <asp:HyperLink href="index.aspx" ID="HyperLink1" runat="server">Back</asp:HyperLink>
     <center>
    <form id="form1" runat="server">
       
        <div>
            <h2> NEW STUDENT DETAILS</h2>
            <div>
                <asp:TextBox ID="Textstdname" placeholder="Student Name" required="required" data-validation-required-message="Please Enter Correct Sutdent Name" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="Textpwd" placeholder="Password" required="required" data-validation-required-message="Please Enter Correct Password" runat="server"></asp:TextBox>
            </div>
                <br />
            <div>
                <asp:TextBox ID="Textcontact" placeholder="Mobile Number" required="required" data-validation-required-message="Please Enter Correct Mobile Number" runat="server"></asp:TextBox>
            </div>
                <br />
            <div>
                <asp:TextBox ID="Textage" placeholder="Age" required="required" data-validation-required-message="Please Enter Correct Age" runat="server"></asp:TextBox>
            </div>
             <br />
            <div>
                <asp:TextBox ID="Textdegree" placeholder="Degree" required="required" data-validation-required-message="Please Enter Correct Degree" runat="server"></asp:TextBox>
            </div>
             <br />
            <div>
                <asp:TextBox ID="Textpassout" placeholder="Pass Out" required="required" data-validation-required-message="Please Enter Correct Pass Out" runat="server"></asp:TextBox>
            </div>
             <br />
            <div>
                <asp:TextBox ID="Textcity" placeholder="City" required="required" data-validation-required-message="Please Enter Correct City" runat="server"></asp:TextBox>
            </div>
             <br />
            <div>
                <asp:Button ID="Btnsubmit" runat="server" Text="Submit" OnClick="Btnsubmit_Click" style="height: 30px;width: 100px; Font-Size :15px;background-color:green; color:white;"  />
            </div>

        </div>
    </form>
    </center>
</body>
</html>
