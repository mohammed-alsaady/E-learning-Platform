using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Data_Access_layer
{
   public class Contact_Method
    {
       public bool newcontact(Contacts cn)
       {
           SqlParameter[] Parameters = new SqlParameter[]
          {
              new SqlParameter("@Title",cn.ContactTitle),
              new SqlParameter("@Email",cn.ContactEmail),
              new SqlParameter("@Body",cn.ContactBody)
          };
           return DBHelper.ExecuteNonQuery("sp_NewContact", CommandType.StoredProcedure, Parameters);
       }
       public List<Contacts> GetAllContacts()
       {
           List<Contacts> ListContact = null;
           using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllContact", CommandType.StoredProcedure))
           {
               if (table.Rows.Count > 0)
               {
                   ListContact = new List<Contacts>();
                   foreach (DataRow row in table.Rows)
                   {
                       Contacts cn = new Contacts();
                      cn.ContactId  =Convert.ToInt32( row["Contact_Id"]);
                       cn.ContactEmail=row["Contact_Email"].ToString();
                       cn.ContactDate = Convert.ToDateTime(row["Contact_Date"]);
                       cn.ContactTitle = row["Contact_Title"].ToString();
                       cn.ContactBody = row["Contact_Body"].ToString();
                       ListContact.Add(cn);
                   }
               }
           }
           return ListContact;
       }
    }
}
