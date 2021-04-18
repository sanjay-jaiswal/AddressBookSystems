using System;
using System.Collections.Generic;

namespace AddressBook
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================Welcome to Address Book System======================================");


            InterfaceDetails mydetail = new AddPersonDetails();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("========Please Enter Your Choice=========");
                Console.WriteLine("1.Add Person's Details");
                Console.WriteLine("2.Display Person's Details");
                Console.WriteLine("3.Edit Person's Details");
                Console.WriteLine("4.Delete Person's Details");

                string str = Console.ReadLine();
                int choice = Convert.ToInt32(str);

                switch (choice)
                {
                    case 1:
                        mydetail.AddDetails();
                        break;
                    case 2:
                        mydetail.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter firstName");
                        string name = Console.ReadLine();
                        mydetail.Edit(name);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name:");
                        string deletePerson = Console.ReadLine();
                        mydetail.Delete(deletePerson);
                        break;
                }
            }
        }
   }
}