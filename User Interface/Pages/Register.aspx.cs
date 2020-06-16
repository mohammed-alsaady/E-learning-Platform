using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Microsoft.AspNet.Membership.OpenAuth;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.IO;

public partial class Pages_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
    }
    protected void RegisterUser_CreatedUser(object sender, EventArgs e)
    {
        MembershipUser mu = Membership.GetUser(this.RegisterUser.UserName, true);
        mu.IsApproved = false;
        Membership.UpdateUser(mu);

    }
    protected void RegisterUser_SendingMail(object sender, MailMessageEventArgs e)
    {

    }
    protected void SendActive(string Recieving, string username, string usrid)
    {
        string body = this.PopulateBody(username,
        "After Click link your account will active ",
        "http://localhost:4659/EmailPages/ActiveUser.aspx?Id=" + usrid,
        "Please dont reply on this email ");
        this.SendHtmlFormattedEmail(Recieving, "Active Account !", body);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void ContinueButton_Click(object sender, EventArgs e)
    {
        MembershipUser mu = Membership.GetUser(RegisterUser.UserName, true);
        string toemail = mu.Email;
        string username = mu.UserName;
        string userid = mu.ProviderUserKey.ToString();
        SendActive(toemail, username, userid);
    }
    private string PopulateBody(string userName, string title, string url, string description)
    {
        string body = string.Empty;
        using (StreamReader reader = new StreamReader(Server.MapPath(@"~/Files/Email/Activation.html")))
        {
            body = reader.ReadToEnd();
        }
        body = body.Replace("{UserName}", userName);
        body = body.Replace("{Title}", title);
        body = body.Replace("{Url}", url);
        body = body.Replace("{Description}", description);
        return body;
    }
    private void SendHtmlFormattedEmail(string recepientEmail, string subject, string body)
    {
        using (MailMessage mailMessage = new MailMessage())
        {
            mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["UserName"]);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;
            mailMessage.To.Add(new MailAddress(recepientEmail));
            SmtpClient smtp = new SmtpClient();
            smtp.Host = ConfigurationManager.AppSettings["Host"];
            smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
            System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
            NetworkCred.UserName = ConfigurationManager.AppSettings["UserName"];
            NetworkCred.Password = ConfigurationManager.AppSettings["Password"];
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
            smtp.Send(mailMessage);
        }
    }
    protected void Unnamed_Load(object sender, EventArgs e)
    {
        
    }
}