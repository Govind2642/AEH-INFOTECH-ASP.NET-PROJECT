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
   
    public partial class joinnow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
     

        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=aehinfotech;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_student", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@Student_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = Textstdname.Text;
            SqlParameter param2 = new SqlParameter("@Password", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = Textpwd.Text;
            SqlParameter param3 = new SqlParameter("@Contact_No", SqlDbType.VarChar);
            cmd.Parameters.Add(param3).Value = Textcontact.Text;
            SqlParameter param4 = new SqlParameter("@Age", SqlDbType.Int);
            cmd.Parameters.Add(param4).Value = Textage.Text;
            SqlParameter param5 = new SqlParameter("@Degree", SqlDbType.VarChar);
            cmd.Parameters.Add(param5).Value = Textdegree.Text;
            SqlParameter param6 = new SqlParameter("@Pass_out", SqlDbType.Int);
            cmd.Parameters.Add(param6).Value = Textpassout.Text;
            SqlParameter param7 = new SqlParameter("@City", SqlDbType.VarChar);
            cmd.Parameters.Add(param7).Value = Textcity.Text;

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                Response.Write("Registered Sucessfully");
            }
            else
            {
                Response.Write("Registration Failed");
            }
            con.Close();





        }
    }
}