using LibraryManagementSystem;

namespace Library
{
    class LibraryManagementSystem
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine(".........Library System.......... ");
                Console.WriteLine("1: View List of Books ");
                Console.WriteLine("2: Borrow of Book ");
                Console.WriteLine("3: Return of Book ");
                Console.WriteLine("4: Add new Book (Only Admin Can Add new Books) ");
                Console.WriteLine("5: Add New User");
                Console.WriteLine("6: Logout");
                var User_Input = Console.ReadLine();

                switch (User_Input)
                {
                    case "1":

                        View view = new View();
                        break;

                    case "2":
                        Borrow addBook = new Borrow();

                        break;
                    case "3":
                        Return Return = new Return();
                        break;
                    case "4":
                        AddBook addBook1 = new AddBook();
                        break;
                    case "5":
                        //  Console.WriteLine("You Enter 7 ");
                        break;
                    case "6":
                        Console.WriteLine("You Enter 6");
                        break;
                    default:
                        Console.WriteLine("Inviod Entry Please Enter Correct Number");
                        break;
                }
            }
        }
    }
} 

