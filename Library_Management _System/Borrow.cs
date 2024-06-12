using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Borrow
    {
        public Borrow()
        {
            Boolean ss = false;

            Console.WriteLine("Enter ISBN Number");
            string isnb_Number = Console.ReadLine();

           
                var iss = Dictionary.Dict_Books
                   .Where(e => e.Key.Isnb_Number.Equals(isnb_Number, StringComparison.OrdinalIgnoreCase)
                       ).ToList();

           // iss.FirstOrDefault().Key.status= false;

              // Dictionary.Dict_Books.Keys.FirstOrDefault(e => e.Isnb_Number ==isnb_Number).status = false;
           // Console.WriteLine("\n .................. Successfully Borrows ..................");

            
                foreach (var e in iss)
                {
                    e.Key.status = false;
                    Console.WriteLine("\n .................. Successfully Borrows ..................");
                    break;
                }

            
            
        }
            


    } 
}
