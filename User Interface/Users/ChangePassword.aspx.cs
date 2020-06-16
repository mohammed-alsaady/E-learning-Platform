using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Users_ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ChangePassword_Click(object sender, EventArgs e)
    {
        try
        {

            MembershipUser usr = Membership.GetUser(User.Identity.Name);
            if (usr.ChangePassword(txt_Oldpassword.Text, txt_NewPassword.Text))
                lbl_Msg .Text = "Successful Changed password ...";
            else
                lbl_Msg.Text = "Password change failed. Please re-enter your values and try again.";
        }
        catch (Exception ex)
        {
            lbl_Msg.Text = ex.Message;
        }
    }
}