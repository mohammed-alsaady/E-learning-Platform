using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
using System.Web.Security;
public partial class Administration_UsersSetting : System.Web.UI.Page
{
    User user = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAllUsers();
            BindAllTeacher(lb_AllTeacher);
            BindAllTeacher(lb_AllTeachers);
            BindListboxAllUsers(lb_Allusers);
            BindAllAdmin(lb_AllAdministrators);
            BindAllAdmin(lb_AllAdministratorNew);
            BindListboxAllUsers(lb_AllUserAdmin);
        }
    }
    protected void btn_Users_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void BindAllUsers()
    {
        user = new User();
        gv_allUsers.DataSource = user.GetAllUsers();
        gv_allUsers.DataBind();
    }
    protected void BindListboxAllUsers(ListBox lb)
    {
        lb.DataSource = Membership.GetAllUsers();
        lb.DataBind();
    }
    protected void BindAllUserByName(string keyword)
    {
        user = new User();
        gv_RemoveUser.DataSource = user.GetAllUsersByUserName(keyword);
        gv_RemoveUser.DataBind();
    }
    protected void BindAllTeacher(ListBox lb)
    {
        lb.DataSource = Roles.GetUsersInRole("Teacher");
        lb.DataBind();
    }
    protected void BindAllAdmin(ListBox lb)
    {
        lb.DataSource = Roles.GetUsersInRole("Administrator ");
        lb.DataBind();
    }
    protected void btn_RemoveSearch_Click(object sender, EventArgs e)
    {
        BindAllUserByName(txt_RemoveSearch.Text);
    }

    protected void gv_RemoveUser_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Remove")
        {
            Guid userid = new Guid(e.CommandArgument.ToString());
            MembershipUser mu = Membership.GetUser(userid, true);
            Membership.DeleteUser(mu.UserName, true);
            BindAllUserByName(txt_RemoveSearch.Text);
        }
        else if (e.CommandName == "Block")
        {
            Guid userid = new Guid(e.CommandArgument.ToString());
            MembershipUser mu = Membership.GetUser(userid, true);
            mu.IsApproved = false;
            Membership.UpdateUser(mu);
        }
    }
    protected void btn_Teachers_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void btn_AddTeacher_Click(object sender, EventArgs e)
    {
        if (lb_Allusers.SelectedItem != null)
        {
            Roles.AddUserToRole(lb_Allusers.SelectedItem.Value, "Teacher");
            BindAllTeacher(lb_AllTeachers);
        }
    }
    protected void btn_removeteacher_Click(object sender, EventArgs e)
    {
        if (lb_AllTeachers.SelectedItem != null)
        {
            Roles.RemoveUserFromRole(lb_AllTeachers.SelectedItem.Value, "Teacher");
            BindAllTeacher(lb_AllTeachers);
        }
    }
    protected void btn_Administrator_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }
    protected void btn_AddAdmin_Click(object sender, EventArgs e)
    {
        if (lb_AllUserAdmin.SelectedItem != null)
        {
            Roles.AddUserToRole(lb_AllUserAdmin.SelectedItem.Value, "Administrator");
            BindAllAdmin(lb_AllAdministratorNew);
        }
    }
    protected void btn_removeAdmin_Click(object sender, EventArgs e)
    {
        if (lb_AllAdministratorNew.SelectedItem != null)
        {
            Roles.RemoveUserFromRole(lb_AllAdministratorNew.SelectedItem.Value, "Administrator");
            BindAllAdmin(lb_AllAdministratorNew);
        }
    }
}