using System;
using System.Data.SqlClient;
using System.Text;

public partial class blog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    /**
     * 获取博客数据
     * @return 所有博客数据拼接字符串
     **/
    public string getBlogs()
    {
        using (SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = lmyBlog; Integrated Security = True"))
        {
            using (SqlCommand cmd = new SqlCommand("select * from page", conn))
            {
                
                StringBuilder result = new StringBuilder();
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string htmlBefore = "" +
                    "<div class=\"demo-card-wide mdl-card mdl-shadow--6dp\" onclick=\"javascript: toPage("+reader[0]+");\"> " +
                    "<div class=\"mdl-card__title\">" +
                    "<h3 class=\"mdl-card__title-text\">";
                    string htmlMiddle = "" +
                        "</h3>" +
                        "</div>" +
                        "<div class=\"mdl-card__supporting-text\" id=\"Div1\">";
                    string htmlLast = "" +
                        "</div>" +
                        "</div>";
                    result.Append(htmlBefore);
                    result.Append(reader[1]);
                    result.Append(htmlMiddle);
                    result.Append(reader[2]);
                    result.Append(htmlLast);
                }
                conn.Close();
                return result.ToString();
            }
        }
    }
}