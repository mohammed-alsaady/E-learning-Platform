using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Pages_ArticleDetails : System.Web.UI.Page
{
    Article article = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["Article"] != null)
            {
                BindArticle(Convert.ToInt32(Request.QueryString["Article"].ToString()));
            }
        }
       
    }
    protected void BindArticle(int id)
    {
        article = new Article();
        Repeater2.DataSource = article.GetArticleDetails(id);
        Repeater2.DataBind();
    }
}