using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.IO;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Teachers_NewCourse : System.Web.UI.Page
{
    Course course = null;
    College college = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string userId = Membership.GetUser().ProviderUserKey.ToString();
            Guid teacher = new Guid(userId);
            BindCourseForTeacher(teacher);
            BindWeek();
        }
    }
  protected void SaveLecture()
    {
        try
        {
            Courses courses = new Courses();
            string file;
            courses.LectureTitle = txt_title.Text;
            if (fu_Lecture.HasFile)
            {
                string extension = Path.GetExtension(fu_Lecture.FileName);
                file = "~/Files/Course/Lectures/" + DateTime.Now.Ticks.ToString() + extension;
                fu_Lecture.SaveAs(Server.MapPath( file));
                courses.LecturePath = file;
            }
            courses.WeekId = Convert.ToInt32(ddl_Week.SelectedValue);
          
            course = new Course();
            
            if (course.NewCourseLecture(courses)== true)
               lbl_Msg.Text = "Successful saved ...";
        }
        catch (Exception ex)
        { lbl_Msg.Text = ex.Message; }
    }
    protected void btn_Save_Click(object sender, EventArgs e)
    {
        SaveLecture();
    }
    protected void BindCourseForTeacher(Guid teacher)
    {
        course = new Course();
        ddl_Course.DataSource = course.GetCourseForTeacher(teacher);
        ddl_Course.DataBind();
        ddl_Course.DataTextField = "CourseTitle";
        ddl_Course.DataValueField = "CourseId";
        ddl_Course.DataBind();
    }
    protected void BindWeek()
    {
        course = new Course();
        ddl_Week.DataSource = course.GetWeekForCourse(Convert.ToInt32( ddl_Course.SelectedValue));
        ddl_Week.DataBind();
        ddl_Week.DataTextField = "WeekTitle";
        ddl_Week.DataValueField = "WeekId";
        ddl_Week.DataBind();
    }
    protected void ddl_Course_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindWeek();
    }
}