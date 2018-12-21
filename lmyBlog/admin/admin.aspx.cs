using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["token"].ToString().Equals(Application[Session["username"].ToString()].ToString()))
        {
            Response.Write("<script>alert('本地token与服务器端token不一致，本地token:" + Session["token"] + "，远端token" + Application["token"] + "。</script>");
            Response.Redirect("../login.aspx");
        }
    }
}