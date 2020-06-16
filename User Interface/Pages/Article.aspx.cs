using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Pages_Article : System.Web.UI.Page
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
        DataList1.DataSource = article.GetAllArticleAccept();
        DataList1.DataBind();
    }
}