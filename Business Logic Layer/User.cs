using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_layer;
namespace Business_Logic_Layer
{
   public class User
    {
       Users_Method usersmethod =null ;
       public User()
       { usersmethod = new Users_Method(); }
       //----------- Get
       public List<Users> GetAllUsers()
       {
           return usersmethod.getallusers();
       }
       public List<Users> GetAllUsersByUserName(string keyword)
       {
           return usersmethod.getallusersbyusername(keyword);
       }
    }
}
