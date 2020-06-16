using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Security;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Users_NewArticles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Save_Click(object sender, EventArgs e)
    {
        try
        {
            Articles Ac = new Articles();
            Ac.ArticleTitle = txt_Title.Text;
            Ac.ArticleDetails = txt_Details.Text;
            if (fu_Article.HasFile)
            {
                string ext = Path.GetExtension(fu_Article.FileName);
                string FileName = "~/Files/Articles/" + DateTime.Now.Ticks.ToString() + ext;
                fu_Article.SaveAs(Server.MapPath(FileName));
                Ac.ArticlePhoto = FileName;
                string userId = Membership.GetUser().ProviderUserKey.ToString();
                Ac.UserId = new Guid(userId);
                Article article = new Article();

                if (article.NewArticle(Ac) == true)
                    lbl_Message.Text = "Successful saved...";
            }
        }
        catch (Exception ex)
        {
            lbl_Message.Text = ex.Message;
        }
    }
}