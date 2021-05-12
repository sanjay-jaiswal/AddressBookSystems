using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================Welcome to Address Book System======================================");
            AddPersonDetails personDetailsOBJ = new AddPersonDetails();
            personDetailsOBJ.CreateMultipleUniqueAddressBook();


/*

            InterfaceDetails details = new AddPersonDetails();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("=============================Welcome ToAddress Book Program==========================");
                Console.WriteLine("==========Please Enter Your Choice==========");
                Console.WriteLine("1. Add Details");
                Console.WriteLine("2. Display Details");
                Console.WriteLine("3. Edit Details");
                Console.WriteLine("4. Delete Details");
                Console.WriteLine("5. Exit");
                Console.WriteLine("=============================================");


                string choice = Console.ReadLine();
                int ch = Convert.ToInt32(choice);

                switch (ch)
                {
                    case 1:
                        details.AddDetails();
                        break;
                    case 2:
                        details.Display();
                        break;
                    case 3:
                        Console.WriteLine("Please Enter First Name : ");
                        string name = Console.ReadLine();
                        details.Edit(name);
                        break;
                    case 4:
                        Console.WriteLine("Please Enter First Name : ");
                        string nameForDeletion = Console.ReadLine();
                        details.Delete(nameForDeletion);
                        break;
                    case 5:
                        return;
                }
            }

            */

        }
    }
}