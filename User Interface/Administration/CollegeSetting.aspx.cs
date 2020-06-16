using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Data_Access_layer;
using Business_Logic_Layer;
public partial class Administration_CollegeSetting : System.Web.UI.Page
{
    College college = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCollege(ddl_NewDepartmentCollege);
            BindCollege(ddl_NewFieldCollege);
            BindCollege(ddl_ModifyField);
            BindCollege(ddl_ModifyCollege);
            BindAllDepartment(ddl_ModufyDepartment);
            BindAllField(ddl_ModifyField);
            BindCollege(ddl_DeleteCollege);
            BindAllDepartment(ddl_DeleteDept);
            BindAllField(ddl_DeleteField);
            MultiView1.ActiveViewIndex = 0;
            
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }

    protected void btn_NewCollegeSave_Click(object sender, EventArgs e)
    {
        SaveCollege();
        txt_NewCollegeWebsite.Text = string.Empty;
        txt_NewcollegeTitle.Text = string.Empty;
        txt_NewCollegeAddress.Text = string.Empty;
        txt_NewCollegeAbout.Text = string.Empty;
        ddl_NewDepartmentCollege.DataBind();
        ddl_NewFieldCollege.DataBind();
        ddl_NewFieldDepartment.DataBind();
        BindCollege(ddl_DeleteCollege);
        BindCollege(ddl_ModifyCollege);
    }
    protected void SaveCollege()
    {
        try
        {
            Colleges colleges = new Colleges();
            string Photo;
            if (fu_NewCollegeLogo.HasFile)
            {
                string extension = Path.GetExtension(fu_NewCollegeLogo.FileName);
                Photo = "~/Files/Colleges/" + DateTime.Now.Ticks.ToString() + extension;
                fu_NewCollegeLogo.SaveAs(Server.MapPath(Photo));
                colleges.CollegeLogo = Photo;
            }
            colleges.CollegeName = txt_NewcollegeTitle.Text;
            colleges.CollegeEstablish = Convert.ToDateTime(txt_NewCollegeEstablish.Text);
            colleges.CollegeLocation = txt_NewCollegeAddress.Text;
            colleges.CollegeAbout = txt_NewCollegeAbout.Text;
            colleges.CollegeWebSite = txt_NewCollegeWebsite.Text;
            colleges.CollegeShow = cb_NewCollegeShow.Checked;
            College college = new College();
            if (college.NewCollege (colleges) == true)
            {
               lbl_NewCollege.Text = "Successful saved ...";
            }
        }
        catch (Exception ex)
        { lbl_NewCollege.Text = ex.Message; }
    }
    protected void SaveDepartment()
    {
        try
        {
            Colleges colleges = new Colleges();
            colleges.DepartmentName = txt_NewDepartmentTitle.Text;
            colleges.DepartmentAbout = txt_NewDepartmentAbout.Text;
            colleges.CollegeId = Convert.ToInt32(ddl_NewDepartmentCollege.SelectedValue);
            college = new College();
            if (college.NewDepartment(colleges) == true)
            {
                lbl_NewDepartment.Text = "Successful saved New Department....";
            }
        }
        catch (Exception ex)
        {
            lbl_NewDepartment.Text = ex.Message;
        }
    }
    protected void SaveSubject()
    {
        try
        {
            Colleges colleges = new Colleges();
            colleges.FieldTitle = txt_NewFieldTitle.Text;
            colleges.FieldAbout = txt_NewFieldAbout.Text;
            colleges.DepartmentId = Convert.ToInt32(ddl_NewFieldDepartment.SelectedValue);
            college = new College();
            if (college.NewField(colleges) == true)
            {
                lbl_NewField.Text = "Successful saved New Department....";
               
            }
        }
        catch (Exception ex)
        {
            lbl_NewField.Text = ex.Message;
        }
    }
    protected void BindCollege(DropDownList ddl)
    {
        college = new College();
        ddl.DataSource = college.GetAllColleges();
        ddl.DataBind();
        ddl.DataTextField = "CollegeName";
        ddl.DataValueField = "CollegeId";
        ddl.DataBind();
    }
    protected void BindAllDepartment(DropDownList ddl)
    {
        college = new College();
        ddl.DataSource = college.GetAllDepartments();
        ddl.DataBind();
        ddl.DataTextField = "DepartmentName";
        ddl.DataValueField = "DepartmentId";
        ddl.DataBind();
    }
    protected void BindAllField(DropDownList ddl)
    {
        college = new College();
        ddl.DataSource = college.GetAllField();
        ddl.DataBind();
        ddl.DataTextField = "FieldTitle";
        ddl.DataValueField = "FieldID";
        ddl.DataBind();
    }
    protected void BindDepartment(DropDownList ddl ,int collegeid)
    {
        college = new College();
        ddl.DataSource = college.GetDepartmentByCollege(collegeid);
        ddl.DataBind();
        ddl.DataTextField = "DepartmentName";
        ddl.DataValueField = "DepartmentId";
        ddl.DataBind();
    }
    protected void btn_NewDepartmentSave_Click(object sender, EventArgs e)
    {
        SaveDepartment();
        txt_NewDepartmentAbout.Text = string.Empty;
        txt_NewDepartmentTitle.Text = string.Empty;
        BindAllDepartment(ddl_DeleteDept);
        BindAllDepartment(ddl_ModufyDepartment);
       
    }
    protected void ddl_NewFieldCollege_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDepartment(ddl_NewFieldDepartment,Convert.ToInt32(ddl_NewFieldCollege.SelectedValue));
    }
    protected void btn_NewFieldSave_Click(object sender, EventArgs e)
    {
        SaveSubject();
        txt_NewFieldAbout.Text = string.Empty;
        txt_NewFieldTitle.Text = string.Empty;
        BindAllDepartment(ddl_NewDepartmentCollege);
    }
    protected void btn_UpdateCollege_Click(object sender, EventArgs e)
    {
        UpdateField();
        txt_ModifyFieldAbout.Text = string.Empty;
        txt_ModifyFieldTitle.Text = string.Empty;
    }
    protected void UpdateCollege()
    {
        try
        {
            string Photo;
            Colleges colleges = new Colleges();
            colleges.CollegeId =Convert.ToInt32( ddl_ModifyCollege.SelectedValue);
            colleges.CollegeName = txt_ModifyCollgeTitle.Text;
            colleges.CollegeEstablish = Convert.ToDateTime(txt_ModifyCollegeEstablish.Text);
            colleges.CollegeLocation = txt_ModifyCollgeAddress.Text;
            colleges.CollegeWebSite = txt_ModifyCollegeWebsite.Text;
            colleges.CollegeAbout = txt_ModifyCollegeAbout.Text;
            if (fu_ModifyCollegeLogo.HasFile)
            {
                string extension = Path.GetExtension(fu_ModifyCollegeLogo.FileName);
                Photo = "~/Files/Colleges/" + DateTime.Now.Ticks.ToString() + extension;
                fu_ModifyCollegeLogo.SaveAs(Server.MapPath(Photo));
                colleges.CollegeLogo = Photo;
            }
            colleges.CollegeShow = cb_Modify.Checked;
            college = new College();
            if (college.UpdateCollege(colleges) == true)
            {
                lbl_NewDepartment.Text = "Successful update New Department....";
            }
        }
        catch (Exception ex)
        {
            lbl_NewDepartment.Text = ex.Message;
        }
    }
    protected void UpdateDepartment()
    {
        try
        {
            Colleges colleges = new Colleges();
            colleges.DepartmentId = Convert.ToInt32(ddl_ModufyDepartment.SelectedValue);
            colleges.DepartmentName = txt_ModifyDeptTitle.Text;
            colleges.DepartmentAbout = txt_ModifyDeptAbout.Text;
            college = new College();
            if (college.UpdateDepartment(colleges) == true)
            {
                lbl_NewDepartment.Text = "Successful update New Department....";
            }
        }
        catch (Exception ex)
        {
            lbl_NewDepartment.Text = ex.Message;
        }
    }
    protected void UpdateField()
    {
        try
        {
            Colleges colleges = new Colleges();
            colleges.FieldID = Convert.ToInt32(ddl_ModifyField.SelectedValue);
            colleges.FieldTitle = txt_ModifyFieldTitle.Text;
            colleges.FieldAbout = txt_ModifyFieldAbout.Text;
            college = new College();
            if (college.UpdateField(colleges) == true)
            {
                lbl_ModifyField.Text = "Successful update New Field....";
            }
        }
        catch (Exception ex)
        {
            lbl_ModifyField.Text = ex.Message;
        }
    }
    protected void DeleteCollege()
    {
        try
        {
            Colleges colleges = new Colleges();
            colleges.CollegeId = Convert.ToInt32(ddl_DeleteCollege.SelectedValue);
            college = new College();
            if (college.DeleteCollege(colleges) == true)
            {
                lbl_ModifyField.Text = "Successful delete New college....";
            }
        }
        catch (Exception ex)
        {
            lbl_ModifyField.Text = ex.Message;
        }
    }
    protected void DeleteDepartment()
    {
        try
        {
            Colleges colleges = new Colleges();
            colleges.DepartmentId = Convert.ToInt32(ddl_DeleteDept.SelectedValue);
            college = new College();
            if (college.DeleteDepartment(colleges) == true)
            {
                lbl_ModifyField.Text = "Successful delete New Department....";
            }
        }
        catch (Exception ex)
        {
            lbl_ModifyField.Text = ex.Message;
        }
    }
    protected void DeleteField()
    {
        try
        {
            Colleges colleges = new Colleges();
            colleges.FieldID = Convert.ToInt32(ddl_DeleteField.SelectedValue);
            college = new College();
            if (college.DeleteField(colleges) == true)
            {
               lbl_DeleteField.Text  = "Successful delete New Subject....";
            }
        }
        catch (Exception ex)
        {
            lbl_DeleteField.Text = ex.Message;
        }
    }

    protected void ddl_ModifyCollege_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btn_ModifyCollege_Click(object sender, EventArgs e)
    {
        UpdateCollege();
        txt_ModifyCollegeAbout.Text = string.Empty;
        txt_ModifyCollegeWebsite.Text = string.Empty;
        txt_ModifyCollgeAddress.Text = string.Empty;
        txt_ModifyCollgeTitle.Text = string.Empty;
    }
    protected void btn_ModifyDepartment_Click(object sender, EventArgs e)
    {
        UpdateDepartment();
        txt_ModifyDeptAbout.Text = string.Empty;
        txt_ModifyDeptTitle.Text = string.Empty;
    }
    protected void btn_DeleteCollege_Click(object sender, EventArgs e)
    {
        DeleteCollege();
        BindCollege(ddl_DeleteCollege);
    }

    protected void btn_DeleteDept_Click(object sender, EventArgs e)
    {
        DeleteDepartment();
        BindAllDepartment(ddl_DeleteDept);
    }
    protected void btn_DeleteField_Click(object sender, EventArgs e)
    {
        DeleteField();
        BindAllField(ddl_DeleteField);
    }
}