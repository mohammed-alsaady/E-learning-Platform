using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Users_ActiveCourses : System.Web.UI.Page
{
    Course course = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string userId = Membership.GetUser().ProviderUserKey.ToString();
            Guid user = new Guid(userId);
            BindActiveCourse("Inactive", user);
        }

    }
    protected void BindActiveCourse(string Status, Guid userid)
    {
        course = new Course();
        Repeater2.DataSource = course.GetCoursesForUser(Status, userid);
        Repeater2.DataBind();
    }
}