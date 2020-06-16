using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Administration_CoursesSetting : System.Web.UI.Page
{
    Course course = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAllCourseNonAccept();
        }
    }
    protected void BindAllCourseNonAccept()
    {
        course = new Course();
        gv_AllCourse.DataSource = course.GetAllCoursesNonAccept();
        gv_AllCourse.DataBind();
    }
    protected void gv_AllCourse_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        course = new Course();
        Courses courses = new Courses();
        if (e.CommandName == "Accept")
        {
            courses.CourseId=Convert.ToInt32(e.CommandArgument);
            
            if (course.AcceptCourse(courses) == true)
            {
                lbl_Msg.Text = "Accept Course";
            }
            else
                lbl_Msg.Text = "there are wrong ...";

        }

    }
}