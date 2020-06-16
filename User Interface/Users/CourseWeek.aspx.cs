using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Users_CourseWeek : System.Web.UI.Page
{
    Course course =null ;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["Course"] != null)
            {
                int courseid = Convert.ToInt32(Request.QueryString["Course"]);
                DataBindRepeater(courseid);
                Session["CourseWeek"] = courseid;
            }
            else { }
        }
    }
    protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    public void DataBindRepeater(int courseid)
    {
        course = new Course();
        Repeater2.DataSource = course.GetWeekForCourse(courseid);
        Repeater2.DataBind();
    }
    protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        course = new Course();
        Repeater r_files = (Repeater)e.Item.FindControl("r_files");
        Repeater r_Video = (Repeater)e.Item.FindControl("r_Video");
        HiddenField hf = (HiddenField)e.Item.FindControl("week");
        int weekid = Convert.ToInt32(hf.Value);
        r_Video.DataSource = course.GetVideoForWeek(weekid);
        r_files.DataSource = course.GetLecturesForWeek(weekid);
        r_Video.DataBind();
        r_files.DataBind();
    }
    protected void lb_files_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "Download")
        {
            try
            {
                string filename = e.CommandArgument.ToString();
                Response.ContentType = "application/pdf";
                Response.AddHeader("Content-Disposition", "attachment;filename=" + Convert.ToDateTime(DateTime.Now) + ".pdf");
                Response.TransmitFile(Server.MapPath(filename));
                Response.End();
            }
            catch (Exception ex)
            {
                lbl_Test.Text = e.CommandArgument.ToString();
            }
        }
    }
}