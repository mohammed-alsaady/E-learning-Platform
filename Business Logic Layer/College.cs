using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_layer;
namespace Business_Logic_Layer
{
   public class College
    {
       Colleges_Method colleges = null;
       public College()
       {
           colleges = new Colleges_Method();
       }
       //-------- New College ,Department , Field ------
       public bool NewCollege(Colleges cg)
       {
           return colleges.newcollege(cg);
       }
       public bool NewDepartment(Colleges cg)
       {
           return colleges.newdepartment(cg);
       }
       public bool NewField(Colleges cg)
       {
           return colleges.newfield(cg);
       }
       //------------------------------------------------
       //-------- Get All Colleges , Department , Field ---
       public List<Colleges> GetAllColleges()
       {
           return colleges.getallcolleges();  
       }
       public List<Colleges> GetDepartmentByCollege(int College)
       {
           return colleges.getdepartmentbycollege(College);
       }
       public List<Colleges> GetAllDepartments()
       {
           return colleges.getalldepartments();
       }
       public List<Colleges> GetAllField()
       {
           return colleges.getallfield();
       }
       public List<Colleges> GetFieldByDepartment(int department)
       {
           return colleges.getfieldbydepartment(department);
       }
       public List<Colleges> GetCollegeDetails(int id)
       {
           return colleges.getcollegedetails(id);
       }
       //-----------------------------------------------------
       //------ Update Colleges , Departments , Fields -------
       public bool UpdateCollege(Colleges college)
       {
           return colleges.updatecollege(college);
       }
       public bool UpdateDepartment(Colleges college)
       {
           return colleges.updatedepartment(college);
       }
       public bool UpdateField(Colleges college)
       {
           return colleges.updatefield(college);
       }
       //-----------Delete
       public bool DeleteCollege(Colleges college)
       {
           return colleges.deletecollege(college);
       }
       public bool DeleteDepartment(Colleges college)
       {
           return colleges.deletedepartment(college);
       }
       public bool DeleteField(Colleges college)
       {
           return colleges.deletefield(college);
       }

    }
}
