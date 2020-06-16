using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_layer
{
    public class Users
    {
        Guid userid;
        string username;
        DateTime createdate;
        string email;
        DateTime lastlogin;
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
        public DateTime CreateDate
        {
            get { return createdate; }
            set { createdate = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime LastLogin
        {
            get { return lastlogin; }
            set { lastlogin = value; }
        }
    }
}
