<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fees.aspx.cs" Inherits="AEH_Infotech.fees" %>

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
<h2> FEES DETAILS</h2>
            <div>
                 <asp:TextBox ID="bill_no" placeholder="Bill No" runat="server"></asp:TextBox> 
            </div>
            <br />
<div>
    <asp:TextBox ID="Textstdname" placeholder="Student Name" runat="server"></asp:TextBox>
</div>
<br />
    
<div>
      &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp; <asp:TextBox ID="Textcontact" placeholder="Mobile Number" runat="server"></asp:TextBox>  &nbsp; <asp:Button ID="Butget" runat="server" Text="Get" OnClick="Butget_Click" />
</div>
    <br />
<div>
    <asp:TextBox ID="coursename" placeholder="Course Name" runat="server"></asp:TextBox>
</div>
 <br />
<div>
    <asp:TextBox ID="Textduration" placeholder="Duration"  runat="server"></asp:TextBox>
</div>
 <br />
<div>
    <asp:TextBox ID="Textamount" placeholder="Amount"  runat="server"></asp:TextBox>
</div>
 <br />
<div>
    <asp:TextBox ID="Textbalnce" placeholder="Balance Amount"  runat="server"></asp:TextBox>
</div>
 <br />
                        <div>
    <asp:TextBox ID="Textdate" placeholder="Date"  runat="server"></asp:TextBox>
</div>
 <br />
            <div>
                <asp:Button ID="Insert" runat="server" Text="Insert" Width="100" Height="30px" ForeColor="White" BackColor="#FF0080"  OnClick="Insert_Click" />
                <asp:Button ID="Update" Width="100" Height="30px" ForeColor="White" BackColor="Green" runat="server" Text="Update" OnClick="Update_Click" />
                <asp:Button ID="view" Width="100" Height="30px" ForeColor="White" BackColor="blue" runat="server" Text="View" OnClick="view_Click" />
                <asp:Button ID="Button1" Width="100" Height="30px" ForeColor="White" BackColor="Red" runat="server" Text="Delete" OnClick="Button1_Click" />
            </div>
                        <br />
                        <div>
                            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

                        </div>
        </div>
    </form>
        </center>
</body>
</html>
