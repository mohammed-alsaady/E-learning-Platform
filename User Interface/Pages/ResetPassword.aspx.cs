using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class Pages_ResetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["Id"] == null)
            {
                txt_NewPassword.Enabled = false;
                txt_ConfirmPassword.Enabled = false;
                btn_Save.Enabled = false;
            }
        }
    }
    protected void btn_Save_Click1(object sender, EventArgs e)
    {

        if (Request.QueryString["Id"] != null)
        {
            lbl_msg.Text = Request.QueryString["Id"].ToString();
            Guid userid = new Guid(Request.QueryString["Id"].ToString());
            MembershipUser mu = Membership.GetUser(userid);
            mu.ChangePassword(mu.ResetPassword(), txt_NewPassword.Text);
            lbl_msg.Text = "successful reset password ...";

        }
    }
}