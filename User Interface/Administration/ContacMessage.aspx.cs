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
    Contact contact = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridView();
        }
    }
    protected void BindGridView()
    {
        contact = new Contact();
        gv_allArticle.DataSource = contact.GetAllContacts();
        gv_allArticle.DataBind();
    }
   
}