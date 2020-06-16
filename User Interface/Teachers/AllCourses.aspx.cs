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
            BindCourseForTeacher(teacher);
        }
    }
    protected void BindCourseForTeacher(Guid teacher)
    {
        course = new Course();
        gv_allCourses.DataSource = course.GetCourseForTeacher(teacher);
        gv_allCourses.DataBind();
    }

}