using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_layer;
namespace Business_Logic_Layer
{
   public class Course
    {
       Courses_Method coursemethod = null;
       public Course()
       {
           coursemethod = new Courses_Method();
       }
       public bool NewCourse(Courses courses)
       {
           return coursemethod.newcourse(courses);
       }
       public bool SentJoin(Courses courses)
       {
           return coursemethod.sentjoin(courses);
       }
       public List<Courses> GetAllCoursesNonAccept()
       {
           return coursemethod.getallcoursesnonaccept();
       }
       public bool AcceptCourse(Courses courses)
       {
           return coursemethod.acceptcourse(courses);
       }
       public bool NewCourseWeek(Courses courses)
       {
           return coursemethod.newcourseweek(courses);
       }
       public List<Courses> GetCourseForTeacher(Guid teacher)
       {
           return coursemethod.getcoursesforteacher(teacher);
       }
       public List<Courses> GetWeekForCourse(int courseid)
       {
           return coursemethod.getweekforcourse(courseid);
       }
       public bool NewCourseVideo(Courses courses)
       {
           return coursemethod.newcoursevideo(courses);
       }
       public bool NewCourseLecture(Courses courses)
       {
           return coursemethod.newcourselecture(courses);
       }
       public List<Courses> GetCoursesByField(int field)
       {
           return coursemethod.getcoursesbyfield(field);
       }
       public List<Courses> RequestToCourse(Guid teacher)
       {
           return coursemethod.requesttoCourse(teacher);
       }
       public bool AcceptJoinToCourse(Courses courses)
       {
           return coursemethod.acceptjoin(courses);
       }
       public List<Courses> GetCoursesForUser(string status, Guid userid)
       {
           return coursemethod.getcoursesforuser(status, userid);
       }
       public List<Courses> GetWeeksForCourse(int courseid)
       {
           return coursemethod.getweekforcourse(courseid);
       }
       public List<Courses> GetLecturesForWeek(int weekid)
       {
           return coursemethod.getlecturesforweek(weekid);
       }
       public List<Courses> GetVideoForWeek(int weekid)
       {
           return coursemethod.getvideosforweek(weekid);
       }
       public bool NewComment(Courses cs)
       { return coursemethod.newcomment(cs); }
       public List<Courses> GetComment(int courseid, int weekid)
       {
           return coursemethod.getcomment(weekid, courseid);
       }
       public List<Courses> GetTopFiveCourses()
       {
           return coursemethod.gettopfivecourses();
       }
    }
}
