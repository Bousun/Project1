using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Subsections
    {

        public static void SelectSubsectionGuestMode(int choice)
        {
            IMenu menu;

            if (choice == 1)
            {
                //invoke experience 
                Console.WriteLine("experience");
                menu = new Experience();
                menu.Display();
               
            }
            else if (choice == 2)
            {
                //invoke education 
                Console.WriteLine("education");
                menu = new Education();
                menu.Display();
            }
            else if (choice == 3)
            {
                //invoke skills
                menu = new Skills();
                menu.Display();
            }
            else if (choice == 4)
            {
                //technological skills
                menu = new TechnologicalSkills();
                menu.Display();
            }
            else if (choice == 5)
            {
                //contact details 
                menu = new ContactDetails();
                menu.Display();
            }
            else if (choice == -1)
            {
                UserMode.getSubsectionsGuestMode();
            }
        }


        public static void SelectSubsectionAdminMode(int choice)
        {
            IMenu menu;
            IOperationsOfAdmin operation;

            if (choice == 1)
            {
                //create operation
                Console.WriteLine("create operation");
                MenuSubsections subsectionInstance = new MenuSubsections();
                var subsectionList = subsectionInstance.getSubsectionList;

                var subsection = Utilities.VerifyInputList(subsectionList);
                if (subsection == 1)
                {
                    //create new experience
                    operation = new AdminOperations();

                    Console.WriteLine("Enter company name :");
                    var companyName = Console.ReadLine();

                    bool isvalid = true;
                    int yearint = 0;
                    while (isvalid)
                    {
                        Console.WriteLine("Enter a year :");
                        string year = Console.ReadLine();
                        

                        if (!Int32.TryParse(year, out yearint))
                        {
                            isvalid = true;
                            Console.WriteLine("Enter a proper year");
                        }
                        else
                        {
                            Console.WriteLine("Your number is " + yearint);
                            isvalid = false;
                        }
                    }
                    
                    Console.WriteLine("Give a description");
                    var desciption = Console.ReadLine();


                    operation.Create(companyName,yearint.ToString(),desciption);
                    UserMode.getSubsectionAdminMode();
                }

            }
            else if (choice == 2)
            {
                //read operation
            }
            else if (choice == 3)
            {
                //update operation
                Console.WriteLine("Update operation");
                MenuSubsections subsectionInstance = new MenuSubsections();
                var subsectionList = subsectionInstance.getSubsectionList;

                var subsection = Utilities.VerifyInputList(subsectionList);

                if (subsection == 1)
                {
                    //experience
                }
                else if (subsection == 2)
                { 
                    //
                }

                UserMode.getSubsectionAdminMode();

            }
            else if (choice == 4)
            { 
                //delete operation
            }
            else if (choice == -1)
            {
                UserMode.getSubsectionAdminMode();
            }
        }
    }
}
