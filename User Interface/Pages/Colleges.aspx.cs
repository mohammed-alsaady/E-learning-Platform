using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Pages_Colleges : System.Web.UI.Page
{
    College colege = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["Id"] != null)
            {
                BindCollege(Convert.ToInt32(Request.QueryString["Id"]));
            }
        }

    }
    protected void BindCollege(int id)
    {
        colege = new College();
        Repeater2.DataSource = colege.GetCollegeDetails(id);
        Repeater2.DataBind();
    }
}