using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AEH_Infotech
{
    public partial class Staff : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=aehinfotech;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonget_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_staffget", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Trainee_Id", Traineeid.Text);
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                if (r.Read())
                {
                    Textstaff.Text = r["Staff_name"].ToString();
                    Textcontact.Text = r["Mobile_no"].ToString();
                    Textage.Text = r["Age"].ToString();
                    Textdegree.Text = r["Degree"].ToString();
                    Textpassout.Text = r["Trainee_Subject"].ToString();
                    Textcity.Text = r["City"].ToString();
                }
                else
                {
                    Response.Write("No data found for the provided Mobile number.");
                }

            }
        }

            protected void Btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_staffview", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
            SqlCommand cmd = new SqlCommand("sp_stafupdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@Trainee_Id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = Traineeid.Text;
            SqlParameter param2 = new SqlParameter("@Staff_name", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = Textstaff.Text;
            SqlParameter param3 = new SqlParameter("@Mobile_no", SqlDbType.VarChar);
            cmd.Parameters.Add(param3).Value = Textcontact.Text;
            SqlParameter param4 = new SqlParameter("@Age", SqlDbType.Int);
            cmd.Parameters.Add(param4).Value = Textage.Text;
            SqlParameter param5 = new SqlParameter("@Degree", SqlDbType.VarChar);
            cmd.Parameters.Add(param5).Value = Textdegree.Text;
            SqlParameter param6 = new SqlParameter("@Trainee_Subject", SqlDbType.VarChar);
            cmd.Parameters.Add(param6).Value = Textpassout.Text;
            SqlParameter param7 = new SqlParameter("@City", SqlDbType.VarChar);
            cmd.Parameters.Add(param7).Value = Textcity.Text;

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Update Successfull')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Update Failed')", true);
            }
            con.Close();

        }

        protected void Btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_staffdelete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@Trainee_Id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = Traineeid.Text;
            int i = cmd.ExecuteNonQuery();
           

            if (i > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Delete Successfull')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Delete Failed')", true);
            }
            con.Close();

        }

        protected void Btninsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_staffinsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@Trainee_Id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = Traineeid.Text;
            SqlParameter param2 = new SqlParameter("@Staff_name", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = Textstaff.Text;
            SqlParameter param3 = new SqlParameter("@Mobile_no", SqlDbType.VarChar);
            cmd.Parameters.Add(param3).Value = Textcontact.Text;
            SqlParameter param4 = new SqlParameter("@Age", SqlDbType.Int);
            cmd.Parameters.Add(param4).Value = Textage.Text;
            SqlParameter param5 = new SqlParameter("@Degree", SqlDbType.VarChar);
            cmd.Parameters.Add(param5).Value = Textdegree.Text;
            SqlParameter param6 = new SqlParameter("@Trainee_Subject", SqlDbType.VarChar);
            cmd.Parameters.Add(param6).Value = Textpassout.Text;
            SqlParameter param7 = new SqlParameter("@City", SqlDbType.VarChar);
            cmd.Parameters.Add(param7).Value = Textcity.Text;

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Insert Successfull')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Insert Failed')", true);
            }
            con.Close();

        }
    }
}