using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class MasterPages_MainMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindTopCourses();
        }
    }
    protected void BindTopCourses()
    {
        Course cours = new Course();
        Repeater2.DataSource = cours.GetTopFiveCourses();
        Repeater2.DataBind();
    }
}
