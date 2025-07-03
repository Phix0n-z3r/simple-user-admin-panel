using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prozeman
{
    public partial class Default : System.Web.UI.Page
    {
        static public string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtDeleteKarbarId.Text = "";
            txtKarbarId.Text = "";
            txtNam.Text = "";
            txtShomareTelefon.Text = "";
            txtUpdateKarbarId.Text = "";
            txtUpdateNam.Text = "";
            lblMessage.Text = "";
            txtUpdateShomareTelefon.Text = "";
        }


        protected void btnAddKarbar_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertKarbar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KarbarId", txtKarbarId.Text);
                    cmd.Parameters.AddWithValue("@Nam", txtNam.Text);
                    cmd.Parameters.AddWithValue("@ShomareTelefon", txtShomareTelefon.Text);
                    conn.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        lblMessage.Text = "کاربر با موفقیت اضافه شد!";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "افزودن کاربر انجام نشد.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "خطا: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }


        protected void btnGetKarbaran_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllKarbaran", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvKarbaran.DataSource = dt;
                gvKarbaran.DataBind();
            }

        }

        protected void btnUpdateKarbaran_Click(object sender, EventArgs e)
        {
            try
            {
              
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateKarbar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KarbarId", txtUpdateKarbarId.Text);
                    cmd.Parameters.AddWithValue("@Nam", txtUpdateNam.Text);
                    cmd.Parameters.AddWithValue("@ShomareTelefon", txtUpdateShomareTelefon.Text);
                    conn.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        lblMessage.Text = "کاربر با موفقیت ویرایش شد!";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "ویرایش کاربر انجام نشد.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "خطا: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnDeleteKarbaran_Click(object sender, EventArgs e)
        {
            try
            {
              
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteKarbar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KarbarId", txtDeleteKarbarId.Text);
                    conn.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        lblMessage.Text = "کاربر با موفقیت حذف شد!";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "حذف کاربر انجام نشد.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "خطا: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}

