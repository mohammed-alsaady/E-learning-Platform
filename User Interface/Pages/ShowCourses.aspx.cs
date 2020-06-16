using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Pages_ShowCourses : System.Web.UI.Page
{
    Course course = null;
    College college = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["Id"] != null)
            {
                BindDepartment(Convert.ToInt32(Request.QueryString["Id"].ToString()));
                if (ddl_Department.SelectedIndex > -1 )
                {
                    BindField(Convert.ToInt32(ddl_Department.SelectedValue.ToString()));
                    if (ddl_Field.SelectedIndex > -1)
                    {
                        BindCourses(Convert.ToInt32(ddl_Field.SelectedValue.ToString()));
                    }
                }
                
            }
        }
    }
     protected void BindDepartment(int collegeid)
    {
        college = new College();
        ddl_Department.DataSource = college.GetDepartmentByCollege(collegeid);
        ddl_Department.DataBind();
        ddl_Department.DataTextField = "DepartmentName";
        ddl_Department.DataValueField = "DepartmentId";
        ddl_Department.DataBind();
    }
     protected void BindField(int Depratment)
     {
         college = new College();
         ddl_Field.DataSource = college.GetFieldByDepartment(Depratment);
         ddl_Field.DataBind();
         ddl_Field.DataTextField = "FieldTitle";
         ddl_Field.DataValueField = "FieldID";
         ddl_Field.DataBind();
     }
     protected void BindCourses(int field)
     {
         college = new College();
         course =new Course ();
         Repeater2.DataSource = course.GetCoursesByField(field);
         Repeater2.DataBind();
     }
     protected void ddl_Department_SelectedIndexChanged(object sender, EventArgs e)
     {
         BindField(Convert.ToInt32( ddl_Department.SelectedValue.ToString()));
         if (ddl_Field.SelectedIndex > -1)
         {
             BindCourses(Convert.ToInt32(ddl_Field.SelectedValue.ToString()));
         }
     }
     protected void ddl_Field_SelectedIndexChanged(object sender, EventArgs e)
     {
         BindCourses(Convert.ToInt32(ddl_Field.SelectedValue.ToString()));
     }
     protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
     {
         course =new Course ();
         Courses courses = new Courses();
         string userId = Membership.GetUser().ProviderUserKey.ToString();
         courses.UserId = new Guid(userId);
         if (e.CommandName == "Join")
         {
             courses.CourseId =Convert.ToInt32( e.CommandArgument);
             if (course.SentJoin(courses) == true)
             {
             }
         }
     }
}