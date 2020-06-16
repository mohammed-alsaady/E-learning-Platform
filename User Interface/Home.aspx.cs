using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Home : System.Web.UI.Page
{
    Article article = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindArticles();
        }
    }
    protected void BindArticles()
    {
        article = new Article();
        Rpt_Articles.DataSource = article.GetTopThreeArticle();
        Rpt_Articles.DataBind();
    }
}