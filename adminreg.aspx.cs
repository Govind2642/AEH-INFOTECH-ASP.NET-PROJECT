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
    public partial class adminreg : System.Web.UI.Page
    {
       
        private object dr;
        protected void Page_Load(object sender, EventArgs e)
        {
        //    // billtxt.ReadOnly = true;

        //    //  con.Open();
        //    // string qry = "select max(Bill_no) from  tbl_bill";
        //    // SqlCommand cmd = new SqlCommand(qry, con);
        //    // _ = cmd.ExecuteReader();
        //    //dr.Read();
        //    // int billno = Convert.ToInt32(dr[0]);
        //    // billno++;
        //    // billtxt.Text = billno.ToString();
        //    Textstaff.ReadOnly = true;

        //    con.Open();
        //    string qry = "select max(Staff_id) from tbl_student";
        //    SqlCommand cmd = new SqlCommand(qry, con);
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    if (dr.Read()) // Check if there are rows returned
        //    {
        //        if (!dr.IsDBNull(0)) // Check if the value is not DBNull
        //        {
        //            int Staffid = Convert.ToInt32(dr[0]) + 1;
        //            Textstaff.Text = Staffid.ToString();
        //        }
        //        else
        //        {
        //            // If the result is DBNull, set the initial value
        //            Textstaff.Text = "1";
        //        }
        //    }
        //    else
        //    {
        //        // Handle the case where no rows were returned
        //        // This could happen if there is an issue with the query or connection
        //        // You may want to log or display an error message
        //    }

        //    dr.Close(); // Close the SqlDataReader
        //    con.Close();

        }



        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=aehinfotech;Integrated Security=True");

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_stdtb ", con);
                cmd. CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Staff_id", SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = Textstaff.Text;
                SqlParameter param2 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = Textuname.Text;
                SqlParameter param3 = new SqlParameter("@Password", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = Textpwd.Text;
                SqlParameter param4 = new SqlParameter("@Mobile_no", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = Textmobile.Text;
                SqlParameter param5 = new SqlParameter("@Age", SqlDbType.Int);
                cmd.Parameters.Add(param5).Value = Textage.Text;
                SqlParameter param6 = new SqlParameter("@City", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = Textcity.Text;
            int i = cmd.ExecuteNonQuery();
             if(i>=0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Submit Successfully')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Not Submit ')", true);
           }
            //Response.Write("success full");
                con.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }




    }
}
