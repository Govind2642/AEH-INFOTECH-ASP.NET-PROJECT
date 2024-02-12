using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace AEH_Infotech
{
    public partial class joinedit : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=aehinfotech;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      

        protected void Btnview_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_stdview", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }

        protected void Btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_updatestd", con);
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

        protected void Btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_stddelete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@Contact_No", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = Textcontact.Text;
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                Response.Write("Delete Successfully");
            }
            else
            {
                Response.Write("Delete Failed");
            }
            con.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Btnget_Click(object sender, EventArgs e)
        {
          
        }

        protected void Buttonget_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("sp_getstd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Contact_No", Textcontact.Text);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        Textstdname.Text = r["Student_Name"].ToString();
                        Textpwd.Text = r["Password"].ToString();
                        Textage.Text = r["Age"].ToString();
                        Textdegree.Text = r["Degree"].ToString();
                        Textpassout.Text = r["Pass_out"].ToString();
                        Textcity.Text = r["City"].ToString();
                    }
                    else
                    {
                        Response.Write("No data found for the provided Mobile number.");
                    }


                }
            }
            catch (SqlException sqlEx)
            {
                Response.Write("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            con.Close();
        }
    }
}