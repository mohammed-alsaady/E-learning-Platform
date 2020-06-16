using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Users_VideoWeek : System.Web.UI.Page
{
    Course C = null;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            if (Request.QueryString["WeekId"] != null)
            {
                int weekid = Convert.ToInt32(Request.QueryString["WeekId"].ToString());
                DataBindRepeater(weekid);
                int courseid = Convert.ToInt32(Session["CourseWeek"]);
                DataBindComment(weekid, courseid);
            }

        }
    }
    public void DataBindRepeater(int courseid)
    {
        C = new Course();
        R_Video.DataSource = C.GetVideoForWeek(courseid);
        R_Video.DataBind();
    }
    public void DataBindComment(int weekid, int courseid)
    {
        C = new Course();
        R_Comments.DataSource = C.GetComment(courseid, weekid);
        R_Comments.DataBind();
    }
    protected void btn_clear_Click(object sender, EventArgs e)
    {
        txt_Comment.Text = "";
    }
    protected void btn_Save_Click(object sender, EventArgs e)
    {
        Courses cs = new Courses();
        cs.CommentText = txt_Comment.Text;
        cs.WeekId = Convert.ToInt32(Request.QueryString["WeekId"].ToString());
        string id = Membership.GetUser().ProviderUserKey.ToString();
        Guid userid = new Guid(id);
        cs.UserId = userid;
        C = new Course();
        if (C.NewComment(cs) == true)
            lbl_Message.Text = "Successful ....";
    }
    protected void R_Comments_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField fh = (HiddenField)e.Item.FindControl("hf_userid");
        Label lbl = (Label)e.Item.FindControl("lbl_UserName");
        ProfileCommon pr = Profile.GetProfile(lbl.Text);
        Image img = (Image)e.Item.FindControl("img_User");
        img.ImageUrl = pr.Photo;
    }
}