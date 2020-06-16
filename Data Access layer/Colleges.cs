using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_layer
{
    public class Colleges
    { 
        #region Colleges
       int collegeid;
       string collegename;
       string collegelogo;
       DateTime collegeestablish;
       string collegelocation;
       string collegewebsite;
       string collegeabout;
       bool collegeshow;
       public int CollegeId
       {
           get { return collegeid; }
           set { collegeid = value; }
       }
       public string CollegeName
       {
           get { return collegename; }
           set { collegename = value; }
       }
       public string CollegeLogo
       {
           get { return collegelogo; }
           set { collegelogo = value; }
       }
       public DateTime  CollegeEstablish
       {
           get { return collegeestablish; }
           set { collegeestablish = value; }
       }
       public string CollegeLocation
       {
           get { return collegelocation; }
           set { collegelocation= value; }
       }
       public string CollegeWebSite
       {
           get { return collegewebsite; }
           set { collegewebsite = value; }
       }
       public string CollegeAbout
       {
           get { return collegeabout; }
           set { collegeabout = value; }
       }
       public bool CollegeShow
       {
           get { return collegeshow; }
           set { collegeshow = value; }
       }
       #endregion
       #region Department
       int departmentid;
       string departmentname;
       string departmentabout;
       public int DepartmentId
       {
           get { return departmentid; }
           set { departmentid = value; }
       }
       public string DepartmentName
       {
           get { return departmentname; }
           set { departmentname = value; }
       }
       public string DepartmentAbout
       {
           get { return departmentabout; }
           set { departmentabout = value; }
       }
       #endregion
        #region Field
       int fieldid;
       string fieldtitle;
       string fieldabout;
       public int FieldID
       {
           get { return fieldid; }
           set { fieldid = value; }
       }
       public string FieldTitle
       {
           get { return fieldtitle; }
           set { fieldtitle = value; }
       }
       public string FieldAbout
       {
           get { return fieldabout; }
           set { fieldabout = value; }
       }
        #endregion
    }
}
