using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Data_Access_layer
{
   public  class Courses_Method
    {
       // New Course , Week ,Contents
       public bool newcourse(Courses courses)
       {
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@Title",courses.CourseTitle),
              new SqlParameter("@Open",courses.CourseOpen),
              new  SqlParameter("@Close",courses.CourseClose),
              new SqlParameter("@About",courses.CourseAbout),
              new SqlParameter("@Field",courses.Field),
              new SqlParameter("@Supervisory",courses.Supervisory)
           };
           return DBHelper.ExecuteNonQuery("sp_NewCourse", CommandType.StoredProcedure, Pararmeters);
       }
       public bool newcourseweek(Courses courses)
       {
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@WeekNo",courses.WeekNo),
              new SqlParameter("@WeekTitle",courses.WeekTitle),
              new  SqlParameter("@WeekDetails",courses.WeekDetails),
              new SqlParameter("@CourseId",courses.CourseId)
           };
           return DBHelper.ExecuteNonQuery("sp_NewCourseWeek", CommandType.StoredProcedure, Pararmeters);
       }
       public bool newcoursevideo(Courses courses)
       {
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@WeekId",courses.WeekId),
              new SqlParameter("@VideoTitle",courses.VideoTitle),
              new  SqlParameter("@VideoPath",courses.VideoPath)
           };
           return DBHelper.ExecuteNonQuery("sp_NewCourseVideo", CommandType.StoredProcedure, Pararmeters);
       }
       public bool newcourselecture(Courses courses)
       {
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@WeekId",courses.WeekId),
              new SqlParameter("@LectureTitle",courses.LectureTitle),
              new  SqlParameter("@LecturePath",courses.LecturePath)
           };
           return DBHelper.ExecuteNonQuery("sp_NewCourseLecture", CommandType.StoredProcedure, Pararmeters);
       }
       public bool newcomment(Courses cs)
       {
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("@CommentText",cs.CommentText),
               new SqlParameter("@UserId",cs.UserId),
               new SqlParameter("@WeekId",cs.WeekId)
           };
           return DBHelper.ExecuteNonQuery("sp_NewComment", CommandType.StoredProcedure, Pararmeters);
       }
       public bool sentjoin(Courses courses)
       {
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@UserId",courses.UserId),
              new SqlParameter("@CourseId",courses.CourseId)
           };
           return DBHelper.ExecuteNonQuery("sp_SentJoin", CommandType.StoredProcedure, Pararmeters);
       }
       //Accept course
       public bool acceptcourse(Courses courses)
       {
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("CourseId",courses.CourseId) 
           };
           return DBHelper.ExecuteNonQuery("sp_AcceptCourse", CommandType.StoredProcedure, Pararmeters);
       }
       public bool acceptjoin(Courses courses)
       {
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@JoinId",courses.JoinId)
           };
           return DBHelper.ExecuteNonQuery("sp_AcceptJoinToCourse", CommandType.StoredProcedure, Pararmeters);
       }
       // get  Courses , Weeks ,Contents
       public List<Courses> getallcoursesnonaccept()
       {
           List<Courses> ListRequest = null;
           using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllCourseNonAccept", CommandType.StoredProcedure))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses courses = new Courses();
                       courses.CourseId = Convert.ToInt32(row["Course_Id"]);
                       courses.CourseTitle = row["Course_Title"].ToString();
                       courses.UserName = row["UserName"].ToString();
                       ListRequest.Add(courses);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> getcoursesforteacher(Guid teacher)
       {
           List<Courses> ListRequest = null;
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@SuperVisory",teacher)
           };
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetCourseForTeacher", CommandType.StoredProcedure, Pararmeters))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses courses = new Courses();
                       courses.CourseId = Convert.ToInt32(row["Course_Id"]);
                       courses.CourseTitle = row["Course_Title"].ToString();
                       ListRequest.Add(courses);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> getcoursesbyfield(int field)
       {
           List<Courses> ListRequest = null;
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@Field",field)
           };
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetCoursesByField", CommandType.StoredProcedure, Pararmeters))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses courses = new Courses();
                       courses.CourseId = Convert.ToInt32(row["Course_Id"]);
                       courses.CourseTitle = row["Course_Title"].ToString();
                       courses.CourseOpen = Convert.ToDateTime(row["Course_Open"]);
                       courses.CourseClose = Convert.ToDateTime(row["Course_Close"]);
                       courses.CourseAbout = row["Course_About"].ToString();
                       courses.UserName = row["UserName"].ToString();
                       ListRequest.Add(courses);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> requesttoCourse(Guid teacher)
       {
           List<Courses> ListRequest = null;
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@SuperVisory",teacher)
           };
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_RequestToCourse", CommandType.StoredProcedure, Pararmeters))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses courses = new Courses();
                       courses.JoinSent = Convert.ToDateTime(row["Join_Sent"]);
                       courses.JoinId = Convert.ToInt32(row["Join_Id"]);
                       courses.JoinAccept = Convert.ToBoolean(row["Join_Accept"]);
                       courses.UserName = row["UserName"].ToString();
                       courses.CourseId = Convert.ToInt32(row["Course_Id"]);
                       courses.CourseTitle = row["Course_Title"].ToString();
                       ListRequest.Add(courses);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> getcoursesforuser(string status ,Guid userid)
       {
           List<Courses> ListRequest = null;
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
              new SqlParameter("@Status",status),
              new SqlParameter("@UserId",userid)
           };
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetCoursesForUser", CommandType.StoredProcedure, Pararmeters))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses courses = new Courses();
                       courses.CourseId = Convert.ToInt32(row["Course_Id"]);
                       courses.CourseTitle = row["Course_Title"].ToString();
                       courses.CourseOpen = Convert.ToDateTime(row["Course_Open"]);
                       courses.CourseClose = Convert.ToDateTime(row["Course_Close"]);
                       courses.CourseAbout = row["Course_About"].ToString();
                       courses.UserName = row["UserName"].ToString();
                       ListRequest.Add(courses);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> getweekforcourse(int courseid)
       {
           List<Courses> ListRequest = null;
           SqlParameter[] parameters = new SqlParameter[]
		{
			new SqlParameter("@CourseId",courseid )
		};
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetWeekForCourse", CommandType.StoredProcedure, parameters))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses cs = new Courses();
                       cs.CourseTitle = row["Course_Title"].ToString();
                       cs.WeekId = Convert.ToInt32(row["Week_Id"]);
                       cs.WeekNo = row["Week_No"].ToString();
                       cs.WeekTitle = row["Week_Title"].ToString();
                       cs.WeekDetails = row["Week_Details"].ToString();
                       ListRequest.Add(cs);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> getvideosforweek(int weekid)
       {
           List<Courses> ListRequest = null;
           SqlParameter[] parameters = new SqlParameter[]
		{
			new SqlParameter("@WeekId",weekid)
		};
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetVideoForWeek", CommandType.StoredProcedure, parameters))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses cs = new Courses();
                       cs.VideoTitle = row["Video_Title"].ToString();
                       cs.VideoPath = row["Video_Path"].ToString();
                       cs.VideoId = Convert.ToInt32(row["Video_Id"]);
                       cs.WeekId = Convert.ToInt32(row["Week_Id"]);
                       ListRequest.Add(cs);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> getlecturesforweek(int weekid)
       {
           List<Courses> ListRequest = null;
           SqlParameter[] parameters = new SqlParameter[]
		{
			new SqlParameter("@WeekId",weekid)
		};
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetFilesForWeek", CommandType.StoredProcedure, parameters))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses cs = new Courses();
                       cs.LectureTitle = row["Lecture_Title"].ToString();
                       cs.LecturePath = row["Lecture_Path"].ToString();
                       ListRequest.Add(cs);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> getcomment(int weekid, int courseid)
       {
           List<Courses> ListRequest = null;
           SqlParameter[] parameters = new SqlParameter[]
		{
			new SqlParameter("@WeekId",weekid),
            new SqlParameter("@CourseId",courseid)
		};
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetComment", CommandType.StoredProcedure, parameters))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses cs = new Courses();
                       cs.UserName = row["UserName"].ToString();
                       cs.CommentText = row["Comment_Text"].ToString();
                       cs.CommentDate = Convert.ToDateTime(row["Comment_Date"]);
                       cs.UserId = (Guid)row["UserId"];
                       ListRequest.Add(cs);
                   }
               }
           }
           return ListRequest;
       }
       public List<Courses> gettopfivecourses()
       {
           List<Courses> ListRequest = null;
           using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetTopFiveCourses", CommandType.StoredProcedure))
           {
               if (table.Rows.Count > 0)
               {
                   ListRequest = new List<Courses>();
                   foreach (DataRow row in table.Rows)
                   {
                       Courses courses = new Courses();
                       courses.CourseId = Convert.ToInt32(row["Course_Id"]);
                       courses.CourseTitle = row["Course_Title"].ToString();
                       ListRequest.Add(courses);
                   }
               }
           }
           return ListRequest;
       }

    }
}
