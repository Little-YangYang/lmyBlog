using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_publicArticle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((!Session["token"].ToString().Equals(Application[Session["username"].ToString()].ToString())) && Convert.ToInt32(Application[Session["username"] + "_permission"]) <= 100)
        {
            Response.Write("<script>alert('本地token与服务器端token不一致，本地token:" + Session["token"] + "，远端token" + Application["token"] + "。</script>");
            Response.Redirect("../login.aspx");
        }

        string title = Request.Params["title"];
        string body = Request.Params["body"];
        int uid;

        using (SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = lmyBlog; Integrated Security = True"))
        {
            using (SqlCommand cmd = new SqlCommand("select id from account where username=@username", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@username", Session["username"].ToString()));

                conn.Open();
                uid = Convert.ToInt32(cmd.ExecuteScalar());  //Object转换成int
                conn.Close();
            }
        }


                using (SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = lmyBlog; Integrated Security = True"))
        {
            using (SqlCommand cmd = new SqlCommand("insert into page (title,body,uid) values (@title,@body,@uid)", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@title", title));
                cmd.Parameters.Add(new SqlParameter("@body", body));
                cmd.Parameters.Add(new SqlParameter("@uid", uid));

                conn.Open();
                int status = Convert.ToInt32(cmd.ExecuteNonQuery());  //Object转换成int
                conn.Close();
                if (status != 0)
                {
                    Response.Write("<script>alert('添加成功！')</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败！')</script>");
                }
            }
        }

        Response.Write(title + body);
    }
    
}