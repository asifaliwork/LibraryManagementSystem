using Library_Management__System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class View
    {
        public  View()
        { 
           
            if (Dictionary.Dict_Books.Keys == null)
            {
                Console.WriteLine(".............No Book Found!: .............. ");
            }
            else
            {
                
                    if (Dictionary.Dict_Books.Keys.FirstOrDefault().status != true)

                    {
                        Console.WriteLine(" ........Don't Have Books Yet: .......... ");

                    }
                    else
                    {
                        foreach (var item in Dictionary.Dict_Books)
                        {
                            Console.WriteLine(" .......List Of Books....... \nISBN Number : " + item.Key.Isnb_Number + "\nBook Title : " + item.Value.title + "\nBook Author: " + item.Value.Author + "\n");
                        }

                    }
            }
                
        }
    }
}
