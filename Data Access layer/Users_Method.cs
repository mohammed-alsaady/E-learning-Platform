using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Data_Access_layer
{
   public  class Users_Method
    {
       public List<Users> getallusers()
       {
           List<Users> listusers = null;
           using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllUsers", CommandType.StoredProcedure))
           {
               if (table.Rows.Count > 0)
               {
                   listusers = new List<Users>();
                   foreach (DataRow row in table.Rows)
                   {
                       Users users = new Users();
                       users.UserId = (Guid)row["UserId"];
                       users.UserName = row["UserName"].ToString();
                       users.CreateDate = Convert.ToDateTime(row["CreateDate"]);
                       users.Email = row["Email"].ToString();
                       users.LastLogin = Convert.ToDateTime(row["LastLoginDate"]);
                       listusers.Add(users);
                   }
               }
           }
           return listusers;
       }
       public List<Users> getallusersbyusername( string keyword)
       {
           
           List<Users> listusers = null;
           SqlParameter[] Pararmeters = new SqlParameter[]
           {
               new SqlParameter("@Keyword",keyword )
           };
           using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetAllUsersByName", CommandType.StoredProcedure, Pararmeters))
           {
               if (table.Rows.Count > 0)
               {
                   Users users = new Users();
                   listusers = new List<Users>();
                   foreach (DataRow row in table.Rows)
                   {
                       users.UserId = (Guid)row["UserId"];
                       users.UserName = row["UserName"].ToString();
                       listusers.Add(users);
                   }
               }
           }
           return listusers;
       }
    }
}
