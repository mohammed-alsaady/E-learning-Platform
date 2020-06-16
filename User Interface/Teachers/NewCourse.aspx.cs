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
    College college = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindSubject();
        }
    }
    protected void BindSubject()
    {
        college=new College ();
        ddl_Subject.DataSource = college.GetAllField();
        ddl_Subject.DataBind();
        ddl_Subject.DataTextField = "FieldTitle";
        ddl_Subject.DataValueField = "FieldID";
        ddl_Subject.DataBind();
    }
    protected void btn_Save_Click(object sender, EventArgs e)
    {
        SaveCourse();
    }
    protected void SaveCourse()
    {
        try
        {
            Courses courses = new Courses();
            courses.CourseTitle = txt_CourseTitle.Text;
            courses.CourseOpen = Convert.ToDateTime(txt_open.Text);
            courses.CourseClose = Convert.ToDateTime(txt_Close.Text);
            courses.CourseAbout = txt_About.Text;
            courses.Field = Convert.ToInt32(ddl_Subject.SelectedValue);
            string userId = Membership.GetUser().ProviderUserKey.ToString();
            courses.Supervisory = new Guid(userId);
            course = new Course();
            
            if (course.NewCourse(courses) == true)
               lbl_Msg.Text = "Successful saved ...";
            txt_About.Text = string.Empty;
            txt_Close.Text = string.Empty;
            txt_CourseTitle.Text = string.Empty;
            txt_open.Text = string.Empty;
        }
        catch (Exception ex)
        { lbl_Msg.Text = ex.Message; }
    }
}