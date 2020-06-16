using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_layer
{
   public class Contacts
    {
       int contactid;
       string contactemail;
       DateTime contactdate;
       string contacttitle;
       string contactbody;
       public int ContactId
       {
           get { return contactid; }
           set { contactid = value; }
       }
       public string ContactEmail
       {
           get { return contactemail; }
           set { contactemail = value; }
       }
       public DateTime ContactDate
       {
           get { return contactdate; }
           set { contactdate = value; }
       }
       public string ContactTitle
       {
           get { return contacttitle; }
           set { contacttitle = value; }
       }
       public string ContactBody
       {
           get { return contactbody; }
           set { contactbody = value; }
       }
       
    }
}
