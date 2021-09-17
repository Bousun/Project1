using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class User
    {
        public static void GuestOrAdmin()
        {

            UserMode usermode = new UserMode();

            ModeUser menu = new ModeUser();
            var UserMode = menu.getmodeUserList;

            bool isValid = false;
            var choice = "";
            int returnval = 0;           

            Console.WriteLine("Select from the following : (-1 to go back/exit)");


            foreach (var item in UserMode)
            {
                var index = UserMode.FindIndex(a => a == item);
                Console.WriteLine($"{index + 1} : {item}");
            }

            Console.WriteLine();
            Console.WriteLine("Enter your choice : ");
            do
            {
                choice = Console.ReadLine();
                int choiceInt;
                bool parseSuccess = int.TryParse(choice, out choiceInt);

                if (choiceInt == -1)
                {
                    Console.WriteLine("end");
                    Environment.Exit(0);
                    returnval = -1;
                    break;
                }

                if (parseSuccess && ((choiceInt - 1) < UserMode.Count) && choiceInt >-1)
                {
                    isValid = true;
                    returnval = choiceInt;
                    //parse choiceint into a function that will display menu guest for user.
                    usermode.getUserMode(choiceInt);                   
                    
                }
                else
                    Console.WriteLine("Invalid Input..enter again!");

            } while (isValid == false);

           

        }

        
    }
}
