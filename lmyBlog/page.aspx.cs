using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page : System.Web.UI.Page
{
    public string title = "";
    public string body = "";
    public string author = "";
    public string date = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        int pid = 0;
        pid = Convert.ToInt32(Request.Params["page"]);
        if (pid <= 0)
        {
            pid = 1;
        }
        using (SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = lmyBlog; Integrated Security = True"))
        {
            using (SqlCommand cmd = new SqlCommand("select * from page,account where pid=@pid and account.id=uid", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@pid", pid));
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    title = reader["title"].ToString();
                    body = reader["body"].ToString();
                    author = reader["username"].ToString();
                    date = reader["publicDate"].ToString();
                    Page.DataBind();
                }
            }
        }
    }
}