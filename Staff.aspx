﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="AEH_Infotech.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <asp:HyperLink ID="HyperLink1" href="Dashboard.aspx" runat="server">Back</asp:HyperLink>
    <center>
    <form id="form1" runat="server">
        
             <div>
     <h2> NEW STAFF DETAILS</h2>
                 <div>
                       &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp;<asp:TextBox ID="Traineeid" placeholder="Trainee Id"  runat="server"></asp:TextBox>  &nbsp <asp:Button ID="Buttonget" runat="server" Text="Get" OnClick="Buttonget_Click" />
                 </div>
                 <br />
     <div>
         <asp:TextBox ID="Textstaff" placeholder="Staff Name" runat="server"></asp:TextBox>
     </div>
     <br />
    
     <div>
          <asp:TextBox ID="Textcontact" placeholder="Mobile Number" runat="server"></asp:TextBox>  
     </div>
         <br />
     <div>
         <asp:TextBox ID="Textage" placeholder="Age" runat="server"></asp:TextBox>
     </div>
      <br />
     <div>
         <asp:TextBox ID="Textdegree" placeholder="Degree"  runat="server"></asp:TextBox>
     </div>
      <br />
     <div>
         <asp:TextBox ID="Textpassout" placeholder="Trainee Subject"  runat="server"></asp:TextBox>
     </div>
      <br />
     <div>
         <asp:TextBox ID="Textcity" placeholder="City"  runat="server"></asp:TextBox>
     </div>
      <br />
                 <div>
                     <asp:Button ID="Btninsert" runat="server" Width="100" Height="30px" ForeColor="White" BackColor="#FF0080" Text="Insert" OnClick="Btninsert_Click" /> <asp:Button ID="Btnview" runat="server" Text="View"  Width="100" Height="30px" ForeColor="White" BackColor="green" OnClick="Btnview_Click" />    <asp:Button ID="Btnupdate" Width="100" Height="30px" ForeColor="White" BackColor="Blue" runat="server" Text="Update" OnClick="Btnupdate_Click" />     <asp:Button ID="Btndelete" runat="server"  Width="100" Height="30px" ForeColor="White" BackColor="red" Text="Delete" OnClick="Btndelete_Click" />
               
                 </div>
                 <br />
                 <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
        </center>
</body>
</html>


