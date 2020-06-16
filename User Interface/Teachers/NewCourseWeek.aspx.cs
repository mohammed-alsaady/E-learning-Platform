using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Teachers_NewCourse : System.Web.UI.Page
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

    protected void btn_Save_Click(object sender, EventArgs e)
    {
        SaveCourseWeek();
        txt_weekdetails.Text = string.Empty;
        txt_weekno.Text = string.Empty;
        txt_WeekTitle.Text = string.Empty;
    }
    protected void BindCourseForTeacher( Guid teacher)
    {
        course = new Course();
        ddl_Course.DataSource = course.GetCourseForTeacher(teacher);
        ddl_Course.DataBind();
        ddl_Course.DataTextField = "CourseTitle";
        ddl_Course.DataValueField = "CourseId";
        ddl_Course.DataBind();
    }
    protected void SaveCourseWeek()
    {
        try
        {
            Courses courses = new Courses();
            courses.WeekNo = txt_weekno.Text;
            courses.WeekTitle = txt_WeekTitle.Text;
            courses.CourseId = Convert.ToInt32(ddl_Course.SelectedValue);
            courses.WeekDetails = txt_weekdetails.Text;
            course = new Course();

            if (course.NewCourseWeek(courses) == true)
            {
                lbl_Msg.Text = "Successful saved ...";
               
            }
        }
        catch (Exception ex)
        { lbl_Msg.Text = ex.Message; }
    }
}