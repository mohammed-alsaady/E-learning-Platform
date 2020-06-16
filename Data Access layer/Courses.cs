using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_layer
{
   public class Courses
    {
        int courseid;
        string coursetitle;
        DateTime courseopen;
        DateTime courseclose;
        string courseabout;
        int field;
        bool courseaccept;
        Guid supervisiory;

        int weekid;
        string weekno;
        string weektitle;
        string weekdetails;

        int lectureid;
        string lecturetitle;
        string lecturepath;

        Guid userid;
        string username;

        int joiid;
        bool joinaccept;
        DateTime joinsent;

        string statuscourse;

        int videoid;
        string videopath;
        string videotitle;

        int commentid;
        string commenttext;
        DateTime commentdate;

        string status;

        public int CourseId
        {
            get { return courseid; }
            set { courseid = value; }
        }
        public string CourseTitle
        {
            get { return coursetitle; }
            set { coursetitle = value; }
        }
        public DateTime CourseOpen
        {
            get { return courseopen; }
            set { courseopen = value; }
        }
        public DateTime CourseClose
        {
            get { return courseclose; }
            set { courseclose = value; }
        }

        public string CourseAbout
        {
            get { return courseabout; }
            set { courseabout = value; }
        }
        public bool CourseAccept
        {
            get { return courseaccept; }
            set { courseaccept = value; }
        }
        public int Field
        {
            get { return field; }
            set { field = value; }
        }

        public Guid Supervisory
        {
            get { return supervisiory; }
            set { supervisiory = value; }
        }

        public int WeekId
        {
            get { return weekid; }
            set { weekid = value; }
        }
        public string  WeekNo
        {
            get { return weekno; }
            set { weekno = value; }
        }
        public string WeekTitle
        {
            get { return weektitle; }
            set { weektitle = value; }
        }
        public string WeekDetails
        {
            get { return weekdetails; }
            set { weekdetails = value; }
        }
        public int LectureId
        {
            get { return lectureid; }
            set { lectureid = value; }
        }
        public string LectureTitle
        {
            get { return lecturetitle; }
            set { lecturetitle = value; }
        }
        public string LecturePath
        {
            get { return lecturepath; }
            set { lecturepath = value; }
        }
        public Guid UserId
        {
            get { return userid; }
            set { userid = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public int JoinId
        {
            get { return joiid; }
            set { joiid = value; }
        }
        public bool JoinAccept
        {
            get { return joinaccept; }
            set { joinaccept = value; }
        }
        public DateTime JoinSent
        {
            get { return joinsent; }
            set { joinsent = value; }
        }
        public string StatusCourse
        {
            get { return statuscourse; }
            set { statuscourse = value; }
        }
        public int VideoId
        {
            get { return videoid; }
            set { videoid = value; }
        }
        public string VideoPath
        {
            get { return videopath; }
            set { videopath = value; }
        }
        public string VideoTitle
        {
            get { return videotitle; }
            set { videotitle = value; }
        }
        public int CommentId
        {
            get { return commentid; }
            set { commentid = value; }
        }
        public string CommentText
        {
            get { return commenttext; }
            set { commenttext = value; }
        }
        public DateTime CommentDate
        {
            get { return commentdate; }
            set { commentdate = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
