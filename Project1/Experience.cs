using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Project1
{
    public class Experience : IMenu
    {

        //public Experience() 
        //{
        //    getExperience();
        //}
        public void Display()
        {
            Console.WriteLine("Select from the following : (-1 to go back/exit)");
            var path = @"C:/Users/p128612/source/repos/Project1/Project1/UserInformation.csv";

            var allDetails = FileOperations.SplittingLine(path);

            Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();
            dict = FileOperations.returnFieldNameDictionary("Experience");
            foreach (KeyValuePair<int, List<string>> item in dict)
            {
                Console.WriteLine($"{item.Key}. {item.Value[1]} ({item.Value[2]})");
            }

            bool isValid = false;
            var choice = "";
            int returnval = 0;

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

                    returnval = -1;
                    Subsections.SelectSubsectionGuestMode(returnval);
                    break;
                }

                if (parseSuccess && (choiceInt - 1) < allDetails.Count)
                {
                    isValid = true;
                    returnval = choiceInt;
                    //display job description
                    lastStep(returnval, "Experience");

                }
                else
                    Console.WriteLine("Invalid Input..enter again!");
               

            } while (isValid == false);
        }
        public static void lastStep(int choice, string fieldname)
        {
            Utilities.getDescriptionOrModule(choice, fieldname);
            Experience exp = new Experience();
            exp.Display();
        }
    }
}

