using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management__System.Models;

namespace LibraryManagementSystem
{
    internal class Return
    {
        public Return()
        {
             ISBN isss = new ISBN();
            
            Console.WriteLine(" .............. Enter ISBN Number ...............");
            string isbn = Console.ReadLine();


            var iss = Dictionary.Dict_Books
                   .Where(e => e.Key.Isnb_Number.Equals(isbn, StringComparison.OrdinalIgnoreCase)
                       ).ToList();

            foreach (var item in iss)
            {
                //isss.Isnb_Number = item.Key.Isnb_Number;
                item.Key.status = true;
                break;
            }


        }
    }
}
