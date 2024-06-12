using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library_Management__System.Models;

namespace LibraryManagementSystem
{
    internal class AddBook
    {
        public  AddBook()
        {
            
            Dictionary dictionary = new Dictionary();
            ModelClasses model = new ModelClasses();
            ISBN Isbn = new ISBN();
            Console.WriteLine("Enter ISBN NUmber: ");
            do
            {
                string isbn = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(isbn))
                {
                    Console.WriteLine("ISBN Cannot be empty Please try Again");
                }
                else
                {
                    Isbn.Isnb_Number = isbn;
                }
                break;
            }while(true);
            Console.WriteLine("Enter Book Title: ");
            do
            {
                string Title = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Title))
                {
                    Console.WriteLine("Title Cannot be empty Please try Again");
                }
                else
                {
                    model.title = Title;
                }
                break;
            } while(true);

            Console.WriteLine("Enter Book Author: ");
            
            do
            {
                string author = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(author))
                {
                    Console.WriteLine("Author Cannot be empty Please try Again");
                }
                else
                {
                    model.Author = author;
                }
                break;
            } while (true);
            Dictionary.Dict_Books.Add(Isbn, model);
            Dictionary.Dict_Books.Keys.FirstOrDefault().status = true;
            Console.WriteLine("Book Has be Added  ");
        }

    }
}