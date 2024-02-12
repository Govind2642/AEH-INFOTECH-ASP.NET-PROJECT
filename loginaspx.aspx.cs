using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AEH_Infotech
{
    public partial class loginaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=aehinfotech;Integrated Security=True");

        public CommandType CommandType { get; private set; }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("tbl_student ", con);
            CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("Name", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = Textuname.Text;
            SqlParameter param2 = new SqlParameter("Password", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = Textpwd.Text;
            int i = cmd.ExecuteNonQuery();
                if (i > 0) { 

            Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Response.Redirect("enter correct Name and  password");
            }
            con.Close();
        }
    }
}