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
    public partial class fees : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=aehinfotech;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            // billtxt.ReadOnly = true;

            //  con.Open();
            // string qry = "select max(Bill_no) from  tbl_bill";
            // SqlCommand cmd = new SqlCommand(qry, con);
            // _ = cmd.ExecuteReader();
            //dr.Read();
            // int billno = Convert.ToInt32(dr[0]);
            // billno++;
            // billtxt.Text = billno.ToString();
            bill_no.ReadOnly = true;

            con.Open();
            string qry = "select max(Bill_no) from fees_tbl";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) // Check if there are rows returned
            {
                if (!dr.IsDBNull(0)) // Check if the value is not DBNull
                {
                    int billno = Convert.ToInt32(dr[0]) + 1;
                    bill_no.Text = billno.ToString();
                }
                else
                {
                    // If the result is DBNull, set the initial value
                    bill_no.Text = "1";
                }
            }
            else
            {
                // Handle the case where no rows were returned
                // This could happen if there is an issue with the query or connection
                // You may want to log or display an error message
            }

            dr.Close(); // Close the SqlDataReader
            con.Close();
        }

        

        protected void Insert_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_feesinsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@Bill_no", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = bill_no.Text;
            SqlParameter param2 = new SqlParameter("@Student_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = Textstdname.Text;
            SqlParameter param3 = new SqlParameter("@Mobile_no", SqlDbType.VarChar);
            cmd.Parameters.Add(param3).Value = Textcontact.Text;
            SqlParameter param4 = new SqlParameter("@Course_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(param4).Value = coursename.Text;
            SqlParameter param5 = new SqlParameter("@Month_duration", SqlDbType.VarChar);
            cmd.Parameters.Add(param5).Value = Textduration.Text;
            SqlParameter param6 = new SqlParameter("@Amount", SqlDbType.Int);
            cmd.Parameters.Add(param6).Value = Textamount.Text;
            SqlParameter param7 = new SqlParameter("@balance_Amount", SqlDbType.Int);
            cmd.Parameters.Add(param7).Value = Textbalnce.Text;
            SqlParameter param8 = new SqlParameter("@Date", SqlDbType.DateTime);
            cmd.Parameters.Add(param8).Value = Textdate.Text;

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Insert Successfull')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Insert Failed')", true);
            }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
          
            con.Close();


        }

        protected void Update_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fessupdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@Bill_no", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = bill_no.Text;
            SqlParameter param2 = new SqlParameter("@Student_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = Textstdname.Text;
            SqlParameter param3 = new SqlParameter("@Mobile_no", SqlDbType.VarChar);
            cmd.Parameters.Add(param3).Value = Textcontact.Text;
            SqlParameter param4 = new SqlParameter("@Course_Name", SqlDbType.VarChar);
            cmd.Parameters.Add(param4).Value = coursename.Text;
            SqlParameter param5 = new SqlParameter("@Month_duration", SqlDbType.VarChar);
            cmd.Parameters.Add(param5).Value = Textduration.Text;
            SqlParameter param6 = new SqlParameter("@Amount", SqlDbType.Int);
            cmd.Parameters.Add(param6).Value = Textamount.Text;
            SqlParameter param7 = new SqlParameter("@balance_Amount", SqlDbType.Int);
            cmd.Parameters.Add(param7).Value = Textbalnce.Text;
            SqlParameter param8 = new SqlParameter("@Date", SqlDbType.DateTime);
            cmd.Parameters.Add(param8).Value = Textdate.Text;

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Update Successfull')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Update Failed')", true);
            }
        }
             catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            con.Close();
           

        }

        protected void view_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_feesview", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_deletefees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@Bill_no", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = bill_no.Text;
            int i = cmd.ExecuteNonQuery();
            if (1 > 0) {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('delete successfully')", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('delete Faild')", true);
            }
        }
         catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
    con.Close();
        
     
        }

        protected void Butget_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_feesget", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mobile_no", Textcontact.Text);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read()) {
                        bill_no.Text = r["Bill_no"].ToString();
                        Textstdname.Text = r["Student_Name"].ToString();
                   
                    coursename.Text = r["Course_Name"].ToString();
                    Textduration.Text = r["Month_duration"].ToString();
                    Textamount.Text = r["Amount"].ToString();
                    Textbalnce.Text = r["balance_Amount"].ToString();
                    Textdate.Text = r["Date"].ToString();
                    }
                    else
                    {
                        Response.Write("No data found for the provided Mobile number.");
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            con.Close();

        }
    }
}