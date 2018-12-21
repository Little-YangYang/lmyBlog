using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void loginAdmin(object sender, EventArgs e)
    {
        string user = Request.Form["username"].ToString();
        string password = Request.Form["password"].ToString();
        if (user == "" || password == "")
        {
            Response.Write("<script>alert('用户名或密码不能为空！')</script>");
            return;
        }

        using (SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = lmyBlog; Integrated Security = True"))
        {
            using (SqlCommand cmd = new SqlCommand("select permission from account where username=@username and password=@password", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@username",user));
                cmd.Parameters.Add(new SqlParameter("@password", password));

                conn.Open();
                int permission = Convert.ToInt32(cmd.ExecuteScalar());  //Object转换成int
                conn.Close();
                if (permission > 100)
                {
                    Guid token;
                    token = Guid.NewGuid();
                    Application[user] = token.ToString();
                    Session["username"] = user;
                    Session["loginTime"] = DateTime.Now;
                    Session["token"] = token.ToString();
                    Response.Write("<script>console.log('登录成功,在线token是"+Application[user]+",token是"+token.ToString()+"，Session的token是"+Session["token"]+"')</script>");
                    
                    Response.Redirect("./admin/admin.aspx");
                }
                else
                {
                    Response.Write("<script>alert('登录失败')</script>");
                }
            }
        }

    }
}