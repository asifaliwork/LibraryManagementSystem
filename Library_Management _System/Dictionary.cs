using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management__System.Models;

namespace LibraryManagementSystem
{
    internal class Dictionary
    {
        
       public static  Dictionary<ISBN, ModelClasses> Dict_Books = new Dictionary<ISBN, ModelClasses>();
       public static Dictionary<User_Id,User_Id> Dict_User = new Dictionary<User_Id, User_Id> ();
        

    }
 
}
