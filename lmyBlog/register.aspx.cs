using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void userRegister(object sender, EventArgs e)
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
            using (SqlCommand cmd = new SqlCommand("insert into account (username,password,permission) values (@username,@password,100)", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@username", user));
                cmd.Parameters.Add(new SqlParameter("@password", password));

                conn.Open();
                int status = Convert.ToInt32(cmd.ExecuteNonQuery());  //Object转换成int
                conn.Close();
                if (status!=0)
                {
                    Response.Write("<script>alert('注册成功！')</script>");
                }
                else
                {
                    Response.Write("<script>alert('注册失败！')</script>");
                }
            }
        }

    }
}