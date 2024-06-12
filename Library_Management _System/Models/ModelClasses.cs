using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management__System.Models
{
    internal class ModelClasses
    {
        public string title { get; set; }
        public string Author { get; set; }
        public bool status { get; set; }
    }

    class User_Id
    {
        public int user_Id { get; set; }
        public string Name { get; set; }
    }

    class ISBN : ModelClasses
    {
        public string Isnb_Number { get; set; }


    }



}
