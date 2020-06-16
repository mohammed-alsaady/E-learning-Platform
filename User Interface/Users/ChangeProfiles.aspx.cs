using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.IO;
public partial class Users_Profiles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void SaveProfile()
    {
        try
        {
            string Photo;
            if (fu_Picture.HasFile)
            {
                string extension = Path.GetExtension(fu_Picture.FileName);
                Photo = "~/Files/Users/Photos/" + DateTime.Now.Ticks.ToString() + extension;
                fu_Picture.SaveAs(Server.MapPath(Photo));
                Profile.Photo = Photo;
            }
            Profile.Location = txt_Address.Text;
            Profile.Educational = ddl_Educational.SelectedItem.Text;
            Profile.Birth = Convert.ToDateTime(txt_Birth.Text);
            Profile.WebSite = txt_Website.Text;
            Profile.About = txt_About.Text;
            lbl_Msg.Text = "Successful change profile ....";
        }
        catch (Exception ex)
        { lbl_Msg.Text = ex.Message; }


    }
    protected void btn_Changeprofile_Click(object sender, EventArgs e)
    {
        SaveProfile();
    }
}