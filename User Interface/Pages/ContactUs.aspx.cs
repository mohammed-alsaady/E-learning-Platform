using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Pages_ContactUs : System.Web.UI.Page
{
    Contact contact = null;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Send_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            contact =new Contact ();
            Contacts cn = new Contacts();
            cn.ContactEmail = txt_Email.Text;
            cn.ContactBody = txt_Body.Text;
            cn.ContactTitle = txt_title.Text;
            if (contact.NewContact(cn) == true)
            {
                lbl_Msg.Text = "your message had be sent , we will send email about your problim , thankx ";
            }
        }
        catch (Exception ex)
        {
            lbl_Msg.Text = ex.Message;
        }

    }
}