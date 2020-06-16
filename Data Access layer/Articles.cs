using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_layer
{
   public class Articles
    {
        int articleid;
        string articletitle;
        string articledetails;
        DateTime articledatepublish;
        string articlephoto;
        Guid userid;
        string username;
        bool articleaccept;
        public int ArticleId
        {
            get { return articleid; }
            set { articleid = value; }
        }
        public string ArticleTitle
        {
            get { return articletitle; }
            set { articletitle = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string ArticleDetails
        {
            get { return articledetails; }
            set { articledetails = value; }
        }
        public DateTime ArticleDatePublish
        {
            get { return articledatepublish; }
            set { articledatepublish = value; }
        }
        public string ArticlePhoto
        {
            get { return articlephoto; }
            set { articlephoto = value; }
        }
        public Guid UserId
        {
            get { return userid; }
            set { userid = value; }
        }
        public bool ArticleAccept
        {
            get { return articleaccept; }
            set { articleaccept = value; }
        }
    }
}
