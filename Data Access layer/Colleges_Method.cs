using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Data_Access_layer
{
    public class Colleges_Method
    {
        //-----------------New
        public bool newcollege(Colleges cg)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("@Name",cg.CollegeName),
               new SqlParameter("@Logo",cg.CollegeLogo),
               new SqlParameter("@Establish",cg.CollegeEstablish),
               new SqlParameter("@Location",cg.CollegeLocation),
               new SqlParameter("@WebSite",cg.CollegeWebSite),
               new SqlParameter("@About",cg.CollegeAbout),
               new SqlParameter("@Show" ,cg.CollegeShow)
           };
           
            return DBHelper.ExecuteNonQuery("sp_NewCollege", CommandType.StoredProcedure, Pararmeters);
        }
        public bool newdepartment(Colleges cg)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("@Name",cg.DepartmentName ),
              new SqlParameter("@About",cg.DepartmentAbout ),
                new SqlParameter("@College",cg.CollegeId )
           };
            return DBHelper.ExecuteNonQuery("sp_NewDepartment", CommandType.StoredProcedure, Pararmeters);
        }
        public bool newfield(Colleges cg)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("@Title",cg.FieldTitle ),
               new SqlParameter("@About",cg.FieldAbout ),
               new SqlParameter("@Department",cg.DepartmentId )
           };
            return DBHelper.ExecuteNonQuery("sp_NewField", CommandType.StoredProcedure, Pararmeters);
        }
        //-----------------Get
        public List<Colleges> getallcolleges()
        {
            List<Colleges> listcollege = null;
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllColleges", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    listcollege = new List<Colleges>();
                    foreach (DataRow row in table.Rows)
                    {
                        Colleges colleges = new Colleges();
                        colleges.CollegeId = Convert.ToInt32(row["College_Id"]);
                        colleges.CollegeName=row["College_Name"].ToString();
                        colleges.CollegeLogo=row["College_logo"].ToString();
                        colleges.CollegeEstablish = Convert.ToDateTime(row["College_Establish"]);
                        colleges.CollegeLocation=row["College_Location"].ToString();
                        colleges.CollegeWebSite=row["College_Website"].ToString();
                        colleges.DepartmentAbout = row["College_About"].ToString();
                        colleges.CollegeShow = Convert.ToBoolean(row["College_Show"]);
                        listcollege.Add(colleges);
                    }
                }
            }
            return listcollege;
        }
        public List<Colleges> getalldepartments()
        {
            List<Colleges> listcollege = null;
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllDepartments", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    listcollege = new List<Colleges>();
                    foreach (DataRow row in table.Rows)
                    {
                        Colleges colleges = new Colleges();
                        colleges.DepartmentId = Convert.ToInt32(row["Dept_Id"]);
                        colleges.DepartmentName = row["Dept_Name"].ToString();
                        colleges.DepartmentAbout = row["Dept_About"].ToString();
                        colleges.CollegeId = Convert.ToInt32(row["College_Id"]);
                        listcollege.Add(colleges);
                    }
                }
            }
            return listcollege;
        }
        public List<Colleges> getallfield()
        {
            List<Colleges> listcollege = null;
            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllField", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    listcollege = new List<Colleges>();
                    foreach (DataRow row in table.Rows)
                    {
                        Colleges colleges = new Colleges();
                        colleges.FieldID = Convert.ToInt32(row["Field_Id"]);
                       colleges.FieldTitle=row["Field_Title"].ToString();
                       colleges.FieldAbout = row["Field_About"].ToString();
                       colleges.DepartmentId = Convert.ToInt32(row["Dept_Id"]);
                        listcollege.Add(colleges);
                    }
                }
            }
            return listcollege;
        }
        public List<Colleges> getdepartmentbycollege(int college)
        {
            List<Colleges> ListRequest = null;
            SqlParameter[] parameters = new SqlParameter[]
		{
			new SqlParameter("@College",college )
		};
            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetDepartmentbyCollege", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    ListRequest = new List<Colleges>();
                    foreach (DataRow row in table.Rows)
                    {
                        Colleges colleges = new Colleges();
                        colleges.DepartmentId = Convert.ToInt32(row["Dept_Id"]);
                        colleges.DepartmentName = row["Dept_Name"].ToString();
                        colleges.DepartmentAbout = row["Dept_About"].ToString();
                        colleges.CollegeId =Convert.ToInt32( row["College_Id"]);
                        ListRequest.Add(colleges);
                    }
                }
            }
            return ListRequest;
        }
        public List<Colleges> getfieldbydepartment(int department)
        {
            List<Colleges> ListRequest = null;
            SqlParameter[] parameters = new SqlParameter[]
		{
			new SqlParameter("@Department",department )
		};
            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetFieldByDepartment", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    ListRequest = new List<Colleges>();
                    foreach (DataRow row in table.Rows)
                    {
                        Colleges colleges = new Colleges();
                        colleges.FieldID = Convert.ToInt32(row["Field_Id"]);
                        colleges.FieldTitle = row["Field_Title"].ToString();
                        colleges.FieldAbout = row["Field_About"].ToString();
                        colleges.DepartmentId = Convert.ToInt32(row["Dept_Id"]);
                        ListRequest.Add(colleges);
                    }
                }
            }
            return ListRequest;
        }
        public List<Colleges> getcollegedetails(int id)
        {
            List<Colleges> listcollege = null;
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("@Id",id )
           };
            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetCollegeDetails", CommandType.StoredProcedure, Pararmeters))
            {
                if (table.Rows.Count > 0)
                {
                    listcollege = new List<Colleges>();
                    foreach (DataRow row in table.Rows)
                    {
                        Colleges colleges = new Colleges();
                        colleges.CollegeId = Convert.ToInt32(row["College_Id"]);
                        colleges.CollegeName = row["College_Name"].ToString();
                        colleges.CollegeLogo = row["College_logo"].ToString();
                        colleges.CollegeEstablish = Convert.ToDateTime(row["College_Establish"]);
                        colleges.CollegeLocation = row["College_Location"].ToString();
                        colleges.CollegeWebSite = row["College_Website"].ToString();
                        colleges.CollegeAbout = row["College_About"].ToString();
                        colleges.CollegeShow = Convert.ToBoolean(row["College_Show"]);
                        listcollege.Add(colleges);
                    }
                }
            }
            return listcollege;
        }
        //-----------------Update
        public bool updatecollege(Colleges colleges)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("Id",colleges.CollegeId),
               new SqlParameter("@Name",colleges.CollegeName),
               new SqlParameter("@Logo",colleges.CollegeLogo),
               new SqlParameter("@Establish",colleges.CollegeEstablish),
               new SqlParameter("@Location",colleges.CollegeLocation),
               new SqlParameter("@WebSite",colleges.CollegeWebSite),
               new SqlParameter("@About",colleges.CollegeAbout),
               new SqlParameter("@Show" ,colleges.CollegeShow)
           };

            return DBHelper.ExecuteNonQuery("sp_UpdateCollege", CommandType.StoredProcedure, Pararmeters);
        }
        public bool updatedepartment(Colleges colleges)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("Id",colleges.DepartmentId),
               new SqlParameter("@Name",colleges.DepartmentName),
               new SqlParameter("@About",colleges.DepartmentAbout)
              
           };

            return DBHelper.ExecuteNonQuery("sp_UpdateDepartment", CommandType.StoredProcedure, Pararmeters);
        }
        public bool updatefield(Colleges colleges)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("Id",colleges.FieldID),
               new SqlParameter("@Title",colleges.FieldTitle),
               new SqlParameter("@About",colleges.FieldAbout)
              
           };

            return DBHelper.ExecuteNonQuery("sp_UpdateField", CommandType.StoredProcedure, Pararmeters);
        }
        //-----------------Delete
        public bool deletecollege(Colleges colleges)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("Id",colleges.CollegeId)
              
           };

            return DBHelper.ExecuteNonQuery("sp_DeleteCollege", CommandType.StoredProcedure, Pararmeters);
        }
        public bool deletedepartment(Colleges colleges)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("Id",colleges.DepartmentId)
           };

            return DBHelper.ExecuteNonQuery("sp_DeleteDepartment", CommandType.StoredProcedure, Pararmeters);
        }
        public bool deletefield(Colleges colleges)
        {
            SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("Id",colleges.FieldID)
           };

            return DBHelper.ExecuteNonQuery("sp_DeleteField", CommandType.StoredProcedure, Pararmeters);
        }

    }
}
