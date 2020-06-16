using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Teachers_AllCourses : System.Web.UI.Page
{
    Course course = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string userId = Membership.GetUser().ProviderUserKey.ToString();
            Guid teacher = new Guid(userId);
            RequestToCourse(teacher);
        }
    }
    protected void RequestToCourse(Guid teacher)
    {
        course = new Course();
        gv_allCourses.DataSource = course.RequestToCourse(teacher);
        gv_allCourses.DataBind();
    }

    protected void gv_allCourses_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        course = new Course();
        Courses courses = new Courses();
        if (e.CommandName == "Accept")
        {
            courses.JoinId = Convert.ToInt32(e.CommandArgument);
            course.AcceptJoinToCourse(courses);

        }
    }
}