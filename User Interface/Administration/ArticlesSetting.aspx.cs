using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Administration_ArticlesSetting : System.Web.UI.Page
{
    Article article = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridView();
        }
    }
    protected void BindGridView()
    {
        article = new Article();
        gv_allArticle.DataSource = article.GetAllArticleNonAccept();
        gv_allArticle.DataBind();
    }
    protected void gv_allArticle_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        article = new Article();
        Articles articles = new Articles();
        if (e.CommandName == "Accept")
        {
            articles.ArticleId = Convert.ToInt32(e.CommandArgument);
            if (article.AcceptArticle(articles) == true)
            {
                lbl_Msg.Text = "";
            }
            else
                lbl_Msg.Text = "there are wrong ...";
           
        }
       
    }
}