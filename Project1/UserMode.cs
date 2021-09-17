using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{

    class UserMode
    {
        
        public static void DisplayIntroduction()
        {
            Console.WriteLine("This is the introduction");
            Console.WriteLine();
        }

        public  static void getSubsectionsGuestMode()
        {
            MenuSubsections subsectionInstance = new MenuSubsections();
            var subsectionList = subsectionInstance.getSubsectionList;

            var subsection = Utilities.VerifyInputList(subsectionList);

            if (subsection == -1)
            {
                //need to go back to choose between admin or guest
                User.GuestOrAdmin();
            }
            else
            {
                //based on subselection to specific menu

                Subsections.SelectSubsectionGuestMode(subsection);
            }
        }

        public static void getSubsectionAdminMode()
        {
            MenuSubsections subsectionInstance = new MenuSubsections();
            var subsectionList = subsectionInstance.getOperationList;

            var subsection = Utilities.VerifyInputList(subsectionList);

            if (subsection == -1)
            {
                User.GuestOrAdmin();
            }
            else
            {
                //based on subselection to specific menu
                Subsections.SelectSubsectionAdminMode(subsection);

            }

        }

        public  void getUserMode(int choice)
        {
            if (choice == 1)
            {                
                //Guest
                DisplayIntroduction();
                getSubsectionsGuestMode();
            }
            else if (choice == 2)
            {
                //Admin
                Console.WriteLine("Admin");
                getSubsectionAdminMode();


            }
        }

    
    }
}
