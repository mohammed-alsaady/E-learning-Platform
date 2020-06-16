using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
public partial class Users_ShowProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        GetProfile();
        
    }
    public void GetProfile()
    {
        ProfileCommon pr = Profile.GetProfile(User.Identity.Name);
        lbl_UserName.Text = System.Web.HttpContext.Current.User.Identity.Name;
        lbl_Location.Text = " Address :" + pr.Location;
        lbl_Age.Text = GetAge().ToString() + "<span> years old</span>";
        photo.ImageUrl = pr.Photo;
        lbl_Education.Text = pr.Educational;
        hl_website.Text = pr.WebSite;
        hl_website.NavigateUrl = pr.WebSite;
        lbl_About.Text = pr.About;
    }
    public int GetAge()
    {
        // Save today's date.
        var today = DateTime.Today;
        // Calculate the age.
        DateTime birthdate = Profile.Birth;
        var age = today.Year - birthdate.Year;
        // Go back to the year the person was born in case of a leap year
        if (birthdate > today.AddYears(-age)) age--;
        return age;
    }
}