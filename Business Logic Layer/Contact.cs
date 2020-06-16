using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_layer;
namespace Business_Logic_Layer
{
   public  class Contact
    {
       Contact_Method contact =null ;
        public Contact()
        {
            contact = new Contact_Method();
        }
       public bool NewContact(Contacts cn)
        {
            return contact.newcontact(cn);
        }
       public List<Contacts> GetAllContacts()
       {
           return contact.GetAllContacts();
       }
    }
}
