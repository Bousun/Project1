using System;
using System.IO;
using System.Linq;

namespace Project1
{
    class Program
    {

        public static int whatisthemode()
        {
            ModeUser menu = new ModeUser();
            var UserMode = menu.OptionsLists;
            var result = Utilities.VerifyInput(UserMode);

            return result;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var result = returnMenu();

            //MenuUserGuestMode.DisplayIntroduction();
            //var result = MenuUserGuestMode.DisplayMenuToUser();
            //var result = MenuModeUser.DisplayUserMode();
            //Console.WriteLine($"the result is {result}");

            
            GuestMode guest = new GuestMode();
            Experience experience = new Experience();
            JobDescription jobdescription = new JobDescription();
            

        whatsthemode:
            var mode = whatisthemode();            
            if (mode == 1)
            {
                //You are now in guest mode
                MenuUserGuestMode.DisplayIntroduction();
                
                var GuestList = guest.OptionsLists;
                whatstheexperience:
                var resultGuest = Utilities.VerifyInput(GuestList);
                if (resultGuest == -1) goto whatsthemode;

                switch (resultGuest)
                {
                    case 1:    
                        var resultExperience = Utilities.VerifyInput(experience.OptionsLists);
                        if (resultExperience == -1) goto whatstheexperience;
                        string job = "JobDescription.csv";
                        JobDescription.DisplayDescription(job, resultExperience);
                        Console.WriteLine();
                        goto whatstheexperience;
                        
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case -1:

                        break;

                }
                
            }
            else if (mode == -1)
            {
                Environment.Exit(0);
            }



      

            /*
            string exp = "Experience.csv";
            Experience.showExp(exp);

            Console.WriteLine("Enter choice : ");
            int choice = int.Parse(Console.ReadLine());


            string job = "JobDescription.csv";
            JobDescription.DisplayDescription(job,choice);
            */







        }
    }
}
